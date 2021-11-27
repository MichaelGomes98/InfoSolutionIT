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
    public partial class frmPortailClient : Form
    {
        public frmPortailClient()
        {
            InitializeComponent();
            lblBonjour.Text = "Bonjour " + Session.Nom + ",";
        }

        private void btnShop_Click(object sender, EventArgs e)
        { 
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnMesCommandes_Click(object sender, EventArgs e)
        {
            frmClientCommande form = new frmClientCommande();
            form.Show();
            this.Close();
        }

        private void btnMesInfo_Click(object sender, EventArgs e)
        {
            frmClientInformations form = new frmClientInformations();
            form.Show();
            this.Close();
        }

        private void btnMonCompte_Click(object sender, EventArgs e)
        {
            frmPortailClient form = new frmPortailClient();
            form.Show();
            this.Close();
        }

        private void btnRetourAchat_Click(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Session.DestroySession();
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void frmPortailClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }

    }
}
