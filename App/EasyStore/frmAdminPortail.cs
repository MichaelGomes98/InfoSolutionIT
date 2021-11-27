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
    public partial class frmAdminPortail : Form
    {

        public frmAdminPortail()
        {
            InitializeComponent();

        }

        private void frmAdminPortail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.VW_PRODUIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PRODUITTableAdapter.Fill(this.dataSet1.VW_PRODUIT);
        }


        private void btnGestionClient_Click(object sender, EventArgs e)
        {
            frmAdminGestionClient form = new frmAdminGestionClient();
            this.Close();
            form.Show();
        } 

        private void btnGestionCommande_Click(object sender, EventArgs e)
        {
            frmAdminGestionCommandes form = new frmAdminGestionCommandes();
            this.Close();
            form.Show();
        }

        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            frmAdminAjoutProduit form = new frmAdminAjoutProduit();
            form.ShowDialog();
        }

        private void btnDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Session.DestroySession();
            frmShop.getShopInstance().Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmShop.getShopInstance().Show();
        }

        private void frmAdminPortail_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }
            
        private void txtFiltreProduit_TextChanged(object sender, EventArgs e)
        {
            this.vW_PRODUITTableAdapter.FillByNom(this.dataSet1.VW_PRODUIT, txtFiltreProduit.Text);
        }

        private void dtgProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAdminUpdateProduit frm = new frmAdminUpdateProduit(dtgProduit.SelectedCells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
