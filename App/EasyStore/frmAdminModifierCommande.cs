using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class frmAdminModifierCommande : Form
    {
        int id;
        string statut;
        string total;
        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_COMMANDETableAdapter vwCommande = new DataSet1TableAdapters.VW_COMMANDETableAdapter();

        public frmAdminModifierCommande(int id)
        {
            InitializeComponent();
            this.id = id;
            lblNum.Text = id.ToString();
        }

        private void frmAdminModifierCommande_Load(object sender, EventArgs e)
        {                
                DataTable dt = vwCommande.GetDataByNumeroCommande(id);
                cboStatut.Text = dt.Rows[0]["STATUTCOMMANDE"].ToString();
                txtTotalCommande.Text = dt.Rows[0]["TOTALCOMMANDE"].ToString();
                statut = dt.Rows[0]["STATUTCOMMANDE"].ToString();
                total = dt.Rows[0]["TOTALCOMMANDE"].ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(txtTotalCommande.Text != total || cboStatut.Text != statut)
            {
                if ((decimal)vwCommande.UpdateStatutCommande(cboStatut.Text, Convert.ToDecimal(txtTotalCommande.Text), id) > 0)
                {
                    MessageBox.Show("Modification de commande effectuée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Aucun élément a été modifié", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtTotalCommande_TextChanged(object sender, EventArgs e)
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtTotalCommande.Text, "[^0-9-.]"))
                {
                    MessageBox.Show("Veuillez indiquer une valeur valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalCommande.Text = txtTotalCommande.Text.Remove(txtTotalCommande.Text.Length - 1);
                }
        }
    }
}
