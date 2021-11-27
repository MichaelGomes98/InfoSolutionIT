using Oracle.ManagedDataAccess.Client;
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
    public partial class frmDetailCommande : Form
    {
        string idCommande;
        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter vwDetail = new DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter();

        public frmDetailCommande(string idCommande)
        {
            InitializeComponent();
            this.idCommande = idCommande;
            lblNumero.Text = idCommande;

        }

        private void frmDetailCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.VW_COMMANDEDETAIL'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_COMMANDEDETAILTableAdapter.Fill(this.dataSet1.VW_COMMANDEDETAIL);
            dtgDetailCommande.DataSource = vwDetail.GetDataByDetailCommande(Convert.ToDecimal(idCommande));
            dtgDetailCommande.Columns[0].Visible = false;
            dtgDetailCommande.Columns[1].Visible = false;
            dtgDetailCommande.Columns[2].Visible = false;
            dtgDetailCommande.Columns[3].Visible = false;
            dtgDetailCommande.Columns[4].HeaderText = "N° de commande";
            dtgDetailCommande.Columns[5].HeaderText = "Status";
            dtgDetailCommande.Columns[6].HeaderText = "Quantité";
            dtgDetailCommande.Columns[7].Visible = false;
            dtgDetailCommande.Columns[8].HeaderText = "Type de produit";
            dtgDetailCommande.Columns[9].HeaderText = "Modèle du produit";
            dtgDetailCommande.Columns[10].HeaderText = "Marque du produit";
        }

    }
}
