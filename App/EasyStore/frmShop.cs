using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class frmShop : Form
    {
        private static frmShop uniqueInstance = null;
        int cpt = 0;
        string moniteur;
        string description;
        string prix;
        int id;
        int id2;
        int id3;
        int id4;
        int id5;
        int id6;
        string end = "6";
        string init = "0";
        int count;
        int pageDebut = 1;
        int pageFin;
        EventHandler handler;
        EventHandler handler2;
        EventHandler handler3;
        EventHandler handler4;
        EventHandler handler5;
        EventHandler handler6;

        private frmShop()
        {
            InitializeComponent();
        }


        public static frmShop getShopInstance() {
            if (uniqueInstance == null)
            {
                uniqueInstance = new frmShop();
            }
            return uniqueInstance;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (Session.Role == 1)
            {
                frmAdminPortail form = new frmAdminPortail();
                form.Show();
            }
            else if (Session.Nom == null)
            {
                frmConnexion form = new frmConnexion();
                form.Show();
            }
            else
            {
                frmPortailClient form = new frmPortailClient();
                form.Show();
            }


        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            frmPanier form = new frmPanier();
            form.Show();
        }


        private void frmShop_Load(object sender, EventArgs e)
        {
            nettoyage();
            DataSet1 bdd = new DataSet1();
            DataSet1TableAdapters.VW_CLIENTTableAdapter vwClient = new DataSet1TableAdapters.VW_CLIENTTableAdapter();
            DataSet1TableAdapters.VW_UTILISATEURTableAdapter vwUser = new DataSet1TableAdapters.VW_UTILISATEURTableAdapter();
            DataSet1TableAdapters.VW_PRODUITTableAdapter vwProduit = new DataSet1TableAdapters.VW_PRODUITTableAdapter();

            string constr = "DATA SOURCE=localhost;PERSIST SECURITY INFO=True;USER ID=EasyStore_data; password=EasyStore_data;";
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            BackTest();
            NextTest(con);
            countProduit(con);
            gestinnairePage(count);

            
            OracleCommand cmd = new OracleCommand("SELECT* from(select m.*, rownum r from EASYSTORE_DATA.VW_PRODUIT m where ISENABLE = 0) where r >" +  init+ " and r <= "+end, con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                {
         
                System.Diagnostics.Debug.WriteLine(" ININT _ END " +init + " " + end);
                System.Diagnostics.Debug.WriteLine("mon cpt " + cpt);
                switch (cpt){
                    case 0:
                        pnlFond.Visible = true;
                        id = Convert.ToInt32(reader["ID"]);
                        lblDescription.Text = reader["DESCRIPTION"].ToString();
                        lblMoniteur.Text = reader["TYPE"].ToString();
                        lblPrix.Text = reader["PRIX"].ToString() + " CHF";
                        handler = new EventHandler((s, ev) => openDetail(s, ev, id));
                        btnDetail.Click += handler;
                        break;
                    case 1:
                        pnlFond2.Visible = true;
                        id2 = Convert.ToInt32(reader["ID"]);
                        lblDescription2.Text = reader["DESCRIPTION"].ToString();
                        lblMotieur2.Text = reader["TYPE"].ToString();
                        //picProduit2.Image = Base64StringToBitmap(reader["IMAGE"].ToString());
                        lblPrix2.Text = reader["PRIX"].ToString() + " CHF";
                        handler2 = new EventHandler((s, ev) => openDetail(s, ev, id2));
                        btnDetail2.Click += handler2;
                        break;
                    case 2:
                        pnlFond3.Visible = true;
                        id3 = Convert.ToInt32(reader["ID"]);
                        lblDescription3.Text = reader["DESCRIPTION"].ToString();
                        lblMoniteur3.Text = reader["TYPE"].ToString();
                        //picProduit3.Image = Base64StringToBitmap(reader["IMAGE"].ToString());
                        lblPrix3.Text = reader["PRIX"].ToString() + " CHF";
                        handler3 = new EventHandler((s, ev) => openDetail(s, ev, id3));
                        btnDetail3.Click += handler3;
                        break;
                    case 3:
                        pnlFond4.Visible = true;
                        id4 = Convert.ToInt32(reader["ID"]);
                        lblDescription4.Text = reader["DESCRIPTION"].ToString();
                        lblMoniteur4.Text = reader["TYPE"].ToString();
                        //picProduit4.Image = Base64StringToBitmap(reader["IMAGE"].ToString());
                        lblPrix4.Text = reader["PRIX"].ToString() + " CHF";
                        handler4 = new EventHandler((s, ev) => openDetail(s, ev, id4));
                        btnDetail4.Click += handler4;
                        break;
                    case 4:
                        pnlFond5.Visible = true;
                        id5 = Convert.ToInt32(reader["ID"]);
                        lblDescription5.Text = reader["DESCRIPTION"].ToString();
                        lblMoniteur5.Text = reader["TYPE"].ToString();
                        //picProduit5.Image = Base64StringToBitmap(reader["IMAGE"].ToString());
                        lblPrix5.Text = reader["PRIX"].ToString() + " CHF";

                        handler5 = new EventHandler((s, ev) => openDetail(s, ev, id5));
                        btnDetail5.Click += handler5;

                        break;
                    case 5:
                        pnlFond6.Visible = true;
                        System.Diagnostics.Debug.WriteLine(" IDDDD" + reader["ID"]);
                        id6 = Convert.ToInt32(reader["ID"]);
                        lblDescription6.Text = reader["DESCRIPTION"].ToString();
                        lblMoniteur6.Text = reader["TYPE"].ToString();
                        //picProduit6.Image = Base64StringToBitmap(reader["IMAGE"].ToString());
                        lblPrix6.Text = reader["PRIX"].ToString() + " CHF";
                        handler6 = new EventHandler((s, ev) => openDetail(s, ev, id6));
                        btnDetail6.Click += handler6;
                        break;
                }    
                cpt = cpt + 1;
                }
                cpt = 0;
            
            }



        private void nettoyage()
        {
         pnlFond.Visible = false;
         pnlFond2.Visible = false;
         pnlFond3.Visible = false;
         pnlFond4.Visible = false;
         pnlFond5.Visible = false;
         pnlFond6.Visible = false;
        }

        private void gestinnairePage(int count)
        {
            double result = (double)count / (double)6;
            lblPageDebut.Text = pageDebut.ToString();
            lblPageFin.Text = Math.Ceiling(result).ToString();
        }

        private void NextTest(OracleConnection con)
        {
            if (Convert.ToInt32(end) >= (countProduit(con)))
            {
                picNext.Visible = false;
            }
            else
            {
                picNext.Visible = true;
            }
        }

        private int countProduit(OracleConnection con)
        {
            IDbCommand command = new OracleCommand();
            command.CommandText = "Select count(*) from EASYSTORE_DATA.VW_PRODUIT WHERE ISENABLE = 0";
            command.CommandType = CommandType.Text;
            command.Connection = con;
            count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }

        private void BackTest()
        {
            if (init.Equals("0")){
                picPrevious.Visible = false;
            }
            else
            {
                picPrevious.Visible = true;
            }
        }

        private void openDetail(object sender, EventArgs e, int id)
        {
            
            frmDetailProduit form = new frmDetailProduit(id);
            form.Show();
        }

        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;
            //Convert Base64 string to byte[]
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        public void refresh()
        {
            this.Refresh();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            cleanHandler();
            pageDebut = pageDebut + 1;
            init = (Convert.ToUInt32(init) + 6).ToString();
            end = (Convert.ToUInt32(end) + 6).ToString();
            frmShop_Load(null, null);
            refresh();
        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            cleanHandler();
            pageDebut = pageDebut - 1;
            init = (Convert.ToUInt32(init) - 6).ToString();
            end = (Convert.ToUInt32(end) - 6).ToString();
            frmShop_Load(null, null);
            refresh();
        }


        private void cleanHandler()
        {
            btnDetail.Click -= handler;
            btnDetail2.Click -= handler2;
            btnDetail3.Click -= handler3;
            btnDetail4.Click -= handler4;
            btnDetail5.Click -= handler5;
            btnDetail6.Click -= handler6;
        }


    }
}
