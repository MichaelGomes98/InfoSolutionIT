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
    public partial class frmAdminGestionClient : Form
    {
        

        public frmAdminGestionClient()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();
            this.Close();
        }


        private void btnGestionCommande_Click(object sender, EventArgs e)
        {
           frmAdminGestionCommandes form = new frmAdminGestionCommandes();
           form.Show();
           this.Close();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Session.DestroySession();
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnGestionProduit_Click(object sender, EventArgs e)
        {
            frmAdminPortail form = new frmAdminPortail();
            form.Show();
            this.Close();
        }

        private void frmAdminGestionClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }


        private void txtFiltreClient_TextChanged(object sender, EventArgs e)
        {
            this.vW_CLIENTTableAdapter.FiltreNomPrenom(this.dataSet1.VW_CLIENT, txtFiltreClient.Text);
        }

        private void frmAdminGestionClient_Load(object sender, EventArgs e)
        {
            this.vW_CLIENTTableAdapter.FillBy(this.dataSet1.VW_CLIENT);
        }

        private void dtgClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAdminUpdateClient frm = new frmAdminUpdateClient(dtgClient.SelectedCells[0].Value.ToString()) ;
            frm.ShowDialog();
        }

        private void dtgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAdminUpdateClient frm = new frmAdminUpdateClient(dtgClient.SelectedCells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
