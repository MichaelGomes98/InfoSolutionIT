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
    public partial class frmCreationCompte : Form
    {
        public frmCreationCompte()
        {
            InitializeComponent();
        }

        DataSet1 bdd = new DataSet1();
        DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();



        private void frmCreationCompte_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShop.getShopInstance().Show();
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrenom.Text) || String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtAdresse.Text) || String.IsNullOrEmpty(txtEmail.Text)|| String.IsNullOrEmpty(txtCodePostal.Text) || String.IsNullOrEmpty(txtMDP.Text) || String.IsNullOrEmpty(txtConfimMDP.Text))
            {
                MessageBox.Show("Veuillez completer tout les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMDP.Text == txtConfimMDP.Text)
                {
                    if ((decimal)vwClient.EmailUnique(bdd.VW_CLIENT, txtEmail.Text) > 0)
                    {
                        txtEmail.Text = "";
                        txtEmail.BackColor = Color.Red;
                        MessageBox.Show("Un compte avec cette adresse email existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        if ((decimal)vwClient.InsertClient(txtNom.Text, txtPrenom.Text, txtAdresse.Text, Convert.ToDecimal(txtCodePostal.Text), txtEmail.Text, txtMDP.Text) > 0)
                        {
                            frmConnexion form = new frmConnexion();
                            MessageBox.Show("Compte créé !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            form.Show();

                        }
                        else
                        {
                            MessageBox.Show("Une erreur est apparu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }             
                }
                else
                {
                    MessageBox.Show("Le mot de passe et la confirmation ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnConnexion_Click(object sender, EventArgs e)
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



        private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCodePostal.Text, "[^0-9]"))
            {
                MessageBox.Show("Veuillez rentrer uniquement des numéros", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodePostal.Text = txtCodePostal.Text.Remove(txtCodePostal.Text.Length - 1);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.Empty;
        }
    }
}
