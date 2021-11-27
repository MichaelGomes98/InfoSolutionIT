using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class frmAdminAjoutProduit : Form
    {
        string bitmapString = null;
        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_PRODUITTableAdapter vwProduit = new DataSet1TableAdapters.VW_PRODUITTableAdapter();

        public frmAdminAjoutProduit()
        {
            InitializeComponent();
            cboTypeProduit.SelectedIndex = 0;
        }
        
        //Probleme avec la longeur du champs de l'image. Etant donnée l'encryption en base64 du bitmap et malgré que le champs soit de type clob dans la base de donnée, le texte est trop long pour le datagrid view.
        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboTypeProduit.Text) || String.IsNullOrEmpty(txtPrix.Text) || String.IsNullOrEmpty(txtModele.Text) || String.IsNullOrEmpty(txtMarque.Text) || String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrEmpty(bitmapString))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((decimal)vwProduit.InsertProduit(cboTypeProduit.Text, txtModele.Text, txtDescription.Text, txtMarque.Text, Convert.ToDecimal(txtPrix.Text), "bitmapString") > 0)
                {
                    MessageBox.Show("Article " + cboTypeProduit.Text + " ajouté au panier !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrix.Text, "[^0-9-.]"))
            {
                MessageBox.Show("Veuillez indiquer une valeur valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrix.Text = txtPrix.Text.Remove(txtPrix.Text.Length - 1);
            }
        }

        private void btnTelecharger_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif, *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bImage = new Bitmap(open.FileName);
                bitmapString = ConvertImage(bImage);
                picProduit.Visible = true;
                picProduit.Image = bImage;
            }

        }

        public string ConvertImage(Bitmap tempBitmap)
        {
            MemoryStream objStream = new MemoryStream();
            tempBitmap.Save(objStream, ImageFormat.Jpeg);
            return Convert.ToBase64String(objStream.ToArray());
        }
    }
}

//https://www.codeproject.com/Questions/161692/How-to-convert-image-to-string
