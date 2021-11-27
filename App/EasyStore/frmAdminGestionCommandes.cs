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
    public partial class frmAdminGestionCommandes : Form
    {
        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_COMMANDETableAdapter vwCommande = new DataSet1TableAdapters.VW_COMMANDETableAdapter();
        private DataTable dbDatatable;

        public frmAdminGestionCommandes()
        {
            InitializeComponent();
        }

        private void frmAdminGestionCommandes_Load(object sender, EventArgs e)
        {
            // sTODO: cette ligne de code charge les données dans la table 'dataSet1.VW_COMMANDE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_COMMANDETableAdapter.Fill(this.dataSet1.VW_COMMANDE);
            btnViderLesFiltres.Visible = false;
            StyleDatagrid();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnGestionClient_Click(object sender, EventArgs e)
        {
            frmAdminGestionClient form = new frmAdminGestionClient();
            form.Show();
            this.Close();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Session.DestroySession();
            frmShop.getShopInstance().Show();
            this.Close();
        }
        
        private void btnPortailAdmin_Click(object sender, EventArgs e)
        {
            frmAdminPortail form = new frmAdminPortail();
            form.Show();
            this.Close();
        }

        private void frmAdminGestionCommandes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }

        private void StyleDatagrid()
        {
            dtgCommandes.Columns["NUMEROCOMMANDE"].HeaderText = "N° de commande";
            dtgCommandes.Columns["DATECOMMANDE"].HeaderText = "Date de commande";
            dtgCommandes.Columns["STATUTCOMMANDE"].HeaderText = "Statut de la commande";
            dtgCommandes.Columns["TOTALCOMMANDE"].HeaderText = "Total de la commande";
            dtgCommandes.Columns["USERID"].HeaderText = "Identifiant de l'utilisateur";
            //dtgCommandes.Columns["ID"].HeaderText = "Identifiant de la commande";
            dtgCommandes.Columns[6].Visible = false;
            dtgCommandes.Columns[7].Visible = false;
            dtgCommandes.Columns[8].Visible = false;
            dtgCommandes.Columns[9].Visible = false;
            dtgCommandes.Columns[10].Visible = false;
        }


        private void dtgCommandes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetailCommande form = new frmDetailCommande(dtgCommandes.SelectedCells[0].Value.ToString());
            form.ShowDialog();
        }

        private void dtgCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgCommandes.SelectedCells[0].Value.ToString());
            frmAdminModifierCommande form = new frmAdminModifierCommande(id);
            form.ShowDialog();

        }

        private void cboStatusCommande_SelectedValueChanged(object sender, EventArgs e)
        {
            
            vwCommande.FiltreNumeroEtStatut(this.dataSet1.VW_COMMANDE, cboStatusCommande.Text); 
            btnViderLesFiltres.Visible = true;
            
        }

        private void btnViderLesFiltres_Click(object sender, EventArgs e)
        {
            
            this.vW_COMMANDETableAdapter.Fill(this.dataSet1.VW_COMMANDE);
            cboStatusCommande.Refresh();
            cboStatusCommande.ResetText();
            btnViderLesFiltres.Visible = false;
        }
    }
}
