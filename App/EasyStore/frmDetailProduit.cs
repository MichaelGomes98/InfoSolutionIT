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
    public partial class frmDetailProduit : Form
    {
        int id;
        string description;
        string moniteur;
        string prix;
        string marque;
        private static frmDetailProduit uniqueInstance = null;

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_PRODUITTableAdapter vwProduit = new DataSet1TableAdapters.VW_PRODUITTableAdapter();
        DataSet1TableAdapters.VW_PANIERTableAdapter vwPanier = new DataSet1TableAdapters.VW_PANIERTableAdapter();


        public frmDetailProduit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            //vwPanier.InsertPanier(id, 1, 10, DateTime.Now, Convert.ToDecimal(prix), Session.Id, Convert.ToDecimal(prix));
            MessageBox.Show("Article ajouté au panier !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmShop.getShopInstance().Show();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmConnexion form = new frmConnexion();
            this.Close();
            form.Show();
        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            frmPanier form = new frmPanier();
            this.Close();
            form.Show();
        }

        private void frmDetailProduit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }

        private void frmDetailProduit_Load(object sender, EventArgs e)
        {
            lblDescription.Text = description;
            lblPrix.Text = prix + " CHF";
            lblModele.Text = moniteur;
            notConnected();

            if((decimal)vwProduit.GetDetailProduit(bdd.VW_PRODUIT, id) > 0 ){
                DataTable dt = vwProduit.GetDataByDetailProduit(id);
                description = dt.Rows[0]["DESCRIPTION"].ToString();
                prix = dt.Rows[0]["PRIX"].ToString();
                moniteur = dt.Rows[0]["TYPE"].ToString();
                marque = dt.Rows[0]["MARQUE"].ToString();
                lblDescription.Text = description;
                lblMarqueProduit.Text = marque;
                lblPrix.Text = prix + " CHF";
                lblModele.Text = moniteur;
            }
        }

        private void notConnected()
        {
            if(Session.Nom == null)
            {
                btnAjoutPanier.Enabled = false;
                nudQuantite.Enabled = false;
                lblSeConnecterPourCommander.Text = "Veuillez vous connecter pour pouvoir passer commande";
            }
        
        }

        public static frmDetailProduit getShopInstance(int id)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new frmDetailProduit(id);
            }
            return uniqueInstance;
        }
    }
}
