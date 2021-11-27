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
    public partial class frmClientCommande : Form
    {
        public frmClientCommande()
        {
            InitializeComponent();
        }

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_COMMANDETableAdapter vwCommande = new DataSet1TableAdapters.VW_COMMANDETableAdapter();

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnMonCompte_Click(object sender, EventArgs e)
        {
            frmPortailClient form = new frmPortailClient();
            form.Show();
            this.Close();
        }

        private void btnMesCommandes_Click(object sender, EventArgs e)
        {
            frmClientCommande form = new frmClientCommande();
            form.Show();
            this.Close();
        }

        private void btnMesInformations_Click(object sender, EventArgs e)
        {
            frmClientInformations form = new frmClientInformations();
            form.Show();
            this.Close();
        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            Session.DestroySession();
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void frmClientCommande_Load(object sender, EventArgs e)
        {
            
            DataTable dt = vwCommande.GetDataUserCommande(Session.Id);
            dtgCommande.DataSource = dt;
            dtgCommande.Columns["ID"].Visible = false;
            dtgCommande.Columns["USERID"].Visible = false;
            frmShop.getShopInstance().Show();

        }

        private void dtgCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmDetailCommande form = new frmDetailCommande(dtgCommande.SelectedCells[1].Value.ToString());
            form.ShowDialog();
            
        }

        private void cboStatusCommande_SelectedValueChanged(object sender, EventArgs e)
        {
 
            //vwCommande.FiltreNumeroEtStatut(bdd.VW_COMMANDE, cboStatusCommande.Text);
            //btnViderLesFiltres.Visible = true;
        }
    }
}
