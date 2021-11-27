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
    public partial class frmConnexion : Form
    {

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void EasyShop_Load(object sender, EventArgs e)
        {
            DataSet1 bdd = new DataSet1();
            DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();
            vwClient.FillBy(bdd.VW_CLIENT);
        }


        private void lblCreationCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreationCompte form = new frmCreationCompte();
            this.Close();
            form.Show();
        }

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            DataSet1 bdd = new DataSet1();
            DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();
            DataSet1TableAdapters.VW_UTILISATEURTableAdapter vwUser = new DataSet1TableAdapters.VW_UTILISATEURTableAdapter();
      

            string constr = "DATA SOURCE=localhost;PERSIST SECURITY INFO=True;USER ID=EasyStore_data; password=EasyStore_data;";
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM EASYSTORE_DATA.VW_CLIENT WHERE(EMAIL LIKE :Parametre) AND(PASSWORD LIKE :Parametre2)", con);

            OracleParameter dp = new OracleParameter();
            dp.OracleDbType = OracleDbType.Varchar2;
            dp.ParameterName = "Parametre";
            dp.Value = txtEmail.Text;
            cmd.Parameters.Add(dp);

            OracleParameter mdp = new OracleParameter();
            mdp.OracleDbType = OracleDbType.Varchar2;
            mdp.ParameterName = "Parametre2";
            mdp.Value = txtMotDePasse.Text;
            cmd.Parameters.Add(mdp);

            OracleDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                Session.genererSession(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetString(5), reader.GetString(6), reader.GetInt16(7), reader.GetInt16(8));

                System.Diagnostics.Debug.WriteLine(reader.GetString(2));
                frmPortailClient form = new frmPortailClient();
                this.Close();
                form.Show();
            }
            else if ((decimal)vwUser.VerificationLoginAdmin(bdd.VW_UTILISATEUR, txtEmail.Text, txtMotDePasse.Text) > 0)
            {
                DataTable dt = vwUser.GetDataAdmin(txtEmail.Text, txtMotDePasse.Text);
                Session.genererSession(Convert.ToInt32(dt.Rows[0]["ID"]), Convert.ToString(dt.Rows[0]["NOM"]), Convert.ToString(dt.Rows[0]["PRENOM"]), Convert.ToString(dt.Rows[0]["ADRESSE"]), Convert.ToInt32(dt.Rows[0]["CODEPOSTAL"]), Convert.ToString(dt.Rows[0]["EMAIL"]), Convert.ToString(dt.Rows[0]["PASSWORD"]), Convert.ToInt32(dt.Rows[0]["CONNECTED"]), Convert.ToInt32(dt.Rows[0]["ROLE"]));
                frmAdminPortail form = new frmAdminPortail();
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Utilisateur inconnu !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmShop.getShopInstance().Show();
            
        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPanier form = new frmPanier();
            form.Show();
        }

        private void frmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }




    }
}
