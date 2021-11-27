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
    public partial class frmAdminUpdateClient : Form
    {
        string id;
        string adresseUser;
        string codePostalUser;
        string emailUser;
        string nomUser;
        string prenomUser;
        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();
        private DataTable dbDatatable;

        public frmAdminUpdateClient(string id)
        {

            InitializeComponent();
            this.id = id;
            chargementDonneeUser();    

        }

        private void chargementDonneeUser()
        {
            DataTable dt = vwClient.GetClientByid(Convert.ToDecimal(id));
            txtAdresse.Text = dt.Rows[0]["ADRESSE"].ToString();
            txtCodePostal.Text = dt.Rows[0]["CODEPOSTAL"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            txtNom.Text = dt.Rows[0]["NOM"].ToString();
            txtPrenom.Text = dt.Rows[0]["PRENOM"].ToString();
            lblIdUser.Text = id;
            getInfosUserDepuisBDD(dt.Rows[0]["ADRESSE"].ToString(), dt.Rows[0]["CODEPOSTAL"].ToString(), dt.Rows[0]["EMAIL"].ToString(), dt.Rows[0]["NOM"].ToString(), dt.Rows[0]["PRENOM"].ToString());
        }

        private void getInfosUserDepuisBDD(string adresse, string codepostal, string email, string nom, string prenom)
        {
            adresseUser = adresse;
            codePostalUser = codepostal;
            emailUser = email;
            nomUser = nom;
            prenomUser = prenom;
        }

        private Boolean donneOnChanger()
        {
            if (adresseUser != txtAdresse.Text || codePostalUser != txtCodePostal.Text || emailUser != txtEmail.Text || nomUser != txtNom.Text || prenomUser != txtPrenom.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (donneOnChanger())
            {
                if (String.IsNullOrEmpty(txtAdresse.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtPrenom.Text) || String.IsNullOrEmpty(txtCodePostal.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((decimal)vwClient.UpdateUserInfoAdmin(txtNom.Text, txtPrenom.Text, txtAdresse.Text, Convert.ToDecimal(txtCodePostal.Text), txtEmail.Text, Convert.ToDecimal(id)) > 0)
                    {
                        MessageBox.Show("Modification des informations du client effectuée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    };
                }
            }
            else
            {
                MessageBox.Show("Aucune données a été changée !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSuppimerClient_Click(object sender, EventArgs e)
        {
            if ((decimal)vwClient.UpdateSuppresionLogique(Convert.ToDecimal(id)) > 0) {
                MessageBox.Show("Client supprimé !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
           }
        }

        private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCodePostal.Text, "[^0-9]"))
            {
                MessageBox.Show("Veuillez indiquer une valeur valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodePostal.Text = txtCodePostal.Text.Remove(txtCodePostal.Text.Length - 1);
            }
        }
    }
}
