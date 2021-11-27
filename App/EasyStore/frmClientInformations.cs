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
    public partial class frmClientInformations : Form
    {
        public frmClientInformations()
        {
            InitializeComponent();
            txtPrenom.Text = Session.Prenom;
            txtNom.Text = Session.Nom;
            txtAdresse.Text = Session.Adresse;
            txtCodePostal.Text = Session.CodePostal.ToString();
            txtEmail.Text = Session.Email;
        }

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();
            this.Close();
        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            Session.DestroySession();
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

        private void frmClientInformations_Load(object sender, EventArgs e)
        {
            frmShop.getShopInstance().Show();

        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            changeTextBox();
            changePassword();                      
        }

        private void changeTextBox()
        {
            if (!txtAdresse.Text.Equals(Session.Adresse) || !txtNom.Text.Equals(Session.Nom) || !txtPrenom.Text.Equals(Session.Prenom) || !txtEmail.Text.Equals(Session.Email) || !Convert.ToInt32(txtCodePostal.Text).Equals(Session.CodePostal))
            {
                System.Diagnostics.Debug.WriteLine(Session.Nom);
                System.Diagnostics.Debug.WriteLine(Session.Prenom);
                System.Diagnostics.Debug.WriteLine(Session.Adresse);
                System.Diagnostics.Debug.WriteLine(Session.CodePostal);
                System.Diagnostics.Debug.WriteLine(Session.Email);
                if ((decimal)vwClient.UpdateInformationUser(txtNom.Text, txtPrenom.Text, txtAdresse.Text, Convert.ToDecimal(txtCodePostal.Text), txtEmail.Text,  Convert.ToInt32(Session.Id)) > 0){
                    Session.Nom = txtNom.Text;
                    Session.Prenom = txtPrenom.Text;
                    Session.Adresse = txtAdresse.Text;
                    Session.CodePostal = Convert.ToInt32(txtCodePostal.Text);
                    Session.Email = txtEmail.Text;
                    MessageBox.Show("Vos données ont été mises à jour !", "Succès");
                    this.Refresh();
                }
            }
        }

        private void changePassword()
        {
            if (!String.IsNullOrEmpty(txtNouveauMDP.Text))
            {
                if (!String.IsNullOrEmpty(txtConfirmationMDP.Text))
                {
                    if (samePassword())
                    {
                        if (!samePasswordSession())
                        {
                            if ((decimal)vwClient.UpdateMotdepasse(txtNouveauMDP.Text, Convert.ToInt32(Session.Id)) > 0)
                            {
                                Session.Password = txtNouveauMDP.Text;
                                MessageBox.Show("Mot de passe modifié", "Succes");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les deux champs pour modifier le mot de passe", "Error");
                }
            }
        }

        private Boolean samePasswordSession()
        {
            if(txtNouveauMDP.Text.Equals(Session.Password))
            {
                MessageBox.Show("Le mot de passe est le même que le précédent", "Warning");
                return true;
            }
            return false;
        }

        private Boolean samePassword()
        {
            if (txtNouveauMDP.Text.Equals(txtConfirmationMDP.Text)){
                return true;
            }
            MessageBox.Show("Le mot de passe et la confirmation ne correspondent pas", "Erreur");
            return false;
        }

            private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCodePostal.Text, "[^0-9]"))
            {
                MessageBox.Show("Veuillez rentrer uniquement des numéros");
                txtCodePostal.Text = txtCodePostal.Text.Remove(txtCodePostal.Text.Length - 1);
            }
        }
    }
}
