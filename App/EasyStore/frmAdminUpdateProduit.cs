using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAdminUpdateProduit : Form
    {
        string id;
        string bitmapString = null;
        string ProduitType;
        string ProduitDescription;
        string ProduitMarque;
        string ProduitModele;
        string ProduitPrix;
        string ProduitImage;

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_PRODUITTableAdapter vwProduit = new DataSet1TableAdapters.VW_PRODUITTableAdapter();
        int count;

        public frmAdminUpdateProduit(string id)
        {
            InitializeComponent();
            this.id = id;
            chargementDonnee();
        }

        private void chargementDonnee()
        {
            if ((decimal)vwProduit.SelectProduitById(bdd.VW_PRODUIT, Convert.ToDecimal(id)) > 0)
            {
                DataTable dt = vwProduit.GetProduitById(Convert.ToDecimal(id));
                cboTypeProduit.Text = dt.Rows[0]["TYPE"].ToString();
                txtDescription.Text = dt.Rows[0]["DESCRIPTION"].ToString();
                txtMarque.Text = dt.Rows[0]["MARQUE"].ToString();
                txtModele.Text = dt.Rows[0]["MODELE"].ToString();
                txtPrix.Text = dt.Rows[0]["PRIX"].ToString();
                bitmapString = dt.Rows[0]["IMAGE"].ToString();
                getInfosUserDepuisBDD(dt.Rows[0]["TYPE"].ToString(), dt.Rows[0]["DESCRIPTION"].ToString(), dt.Rows[0]["MARQUE"].ToString(), dt.Rows[0]["MODELE"].ToString(), dt.Rows[0]["PRIX"].ToString(), dt.Rows[0]["IMAGE"].ToString());
            };
        }

        private void getInfosUserDepuisBDD(string type, string description, string marque, string modele, string prix, string image)
        {
            ProduitType = type;
            ProduitDescription = description;
            ProduitMarque = marque;
            ProduitModele = modele;
            ProduitPrix = prix;
            ProduitImage = image;
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(countProduit()<= 7)
            {
                MessageBox.Show("Vous devez avoir un nombre minimum de 7 produit dans le panier, veuillez en rajouter pour pouvoir en supprimer",  "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((decimal)vwProduit.UpdateSuppressionLogiqueProduit(Convert.ToDecimal(id)) > 0)
                {
                    MessageBox.Show("Suppresion effectuée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        //Erreur chargement du data gridView une fois la modification effectuée
        /*private void btnTelecharger_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif, *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bImage = new Bitmap(open.FileName);
                bitmapString = ConvertImage(bImage);
                System.Diagnostics.Debug.WriteLine(bitmapString);
                pbProduit.Visible = true;
                pbProduit.Image = bImage;
                System.Diagnostics.Debug.WriteLine("ma pics " + bitmapString);
            }

        }*/

        public string ConvertImage(Bitmap tempBitmap)
        {
            MemoryStream objStream = new MemoryStream();
            tempBitmap.Save(objStream, ImageFormat.Jpeg);
            return Convert.ToBase64String(objStream.ToArray());
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrix.Text, "[^0-9-.]"))
            {
                MessageBox.Show("Veuillez indiquer une valeur valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrix.Text = txtPrix.Text.Remove(txtPrix.Text.Length - 1);
            }
        }

        private int countProduit()
        {
            string constr = "DATA SOURCE=localhost;PERSIST SECURITY INFO=True;USER ID=EasyStore_data; password=EasyStore_data;";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            IDbCommand command = new OracleCommand();
            command.CommandText = "Select count(*) from EASYSTORE_DATA.VW_PRODUIT WHERE ISENABLE = 0";
            command.CommandType = CommandType.Text;
            command.Connection = con;
            count = Convert.ToInt32(command.ExecuteScalar());
            return count;

        }

        private void btnUpdateProduit_Click_1(object sender, EventArgs e)
        {
            if (donneeModifiee())
            {
                if (String.IsNullOrEmpty(cboTypeProduit.Text) || String.IsNullOrEmpty(txtPrix.Text) || String.IsNullOrEmpty(txtModele.Text) || String.IsNullOrEmpty(txtMarque.Text) || String.IsNullOrEmpty(bitmapString))
                {
                    MessageBox.Show("Les champs ne peuvent pas etre vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((decimal)vwProduit.UpdateProduit(cboTypeProduit.Text, txtModele.Text, txtDescription.Text, txtMarque.Text, Convert.ToDecimal(txtPrix.Text), bitmapString, Convert.ToDecimal(id)) > 0)
                    {
                        MessageBox.Show("Modification enregistrée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun élément a été modifié", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean donneeModifiee()
        {
            if(ProduitDescription != txtDescription.Text || ProduitMarque != txtMarque.Text || ProduitModele != txtModele.Text || ProduitPrix != txtPrix.Text || ProduitType != cboTypeProduit.Text)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
