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
    public partial class frmPanier : Form
    {
        public frmPanier()
        {
            InitializeComponent();
            lblInfo.Visible = false;
        }

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_PANIERTableAdapter vwPanier = new DataSet1TableAdapters.VW_PANIERTableAdapter();
        DataSet1TableAdapters.VW_COMMANDETableAdapter vwCommande= new DataSet1TableAdapters.VW_COMMANDETableAdapter();
        decimal totalPrix = 0;
        decimal idCommande = 0;


        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmConnexion form = new frmConnexion();
            this.Close();
            form.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmShop.getShopInstance().Show();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {

            vwCommande.ResetStatus();


            if ((decimal)vwCommande.UpdateCommande(Convert.ToDecimal(Session.Id), idCommande) > 0)
            {
                dtgPanier.DataSource = null;
                dtgPanier.Refresh();
                MessageBox.Show("La commande a été effectuée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            };


        }

        private void frmPanier_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }

        private void frmPanier_Load(object sender, EventArgs e)
        {
            if(Session.Nom == null)
            {
                dtgPanier.Visible = false;
                btnCommander.Visible = false;
                lblTotalPrix.Visible = false;
                lblTotalArticle.Visible = false;
                lblInfo.Visible = true;
            }
            else
            {
                if((decimal) vwPanier.PanierUser(bdd.VW_PANIER, Convert.ToDecimal(Session.Id)) > 0)
                {
                    decimal totalPrix = 0;
                    DataTable dt = vwPanier.GetDataPanierUser(Convert.ToDecimal(Session.Id));
                    totalPrix = totalPrix + Convert.ToDecimal(dt.Rows[0]["LIGPRIX"]);
                    idCommande = Convert.ToDecimal(dt.Rows[0]["ID"]);
                    dtgPanier.DataSource = dt;
                    dtgPanier.Columns[5].HeaderText = "Quantité commandée";
                    dtgPanier.Columns[6].HeaderText = "Prix";
                    dtgPanier.Columns[7].HeaderText = "Modèle";
                    dtgPanier.Columns[8].HeaderText = "Marque";
                    lblTotalPrix.Text = totalPrix.ToString();
                    totalPrix = 0;
                }

            }
        }
    }
}
