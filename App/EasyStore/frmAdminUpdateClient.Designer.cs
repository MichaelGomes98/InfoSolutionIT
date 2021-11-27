namespace EasyStore
{
    partial class frmAdminUpdateClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUpdateClient));
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.lblEditClient = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.commandeTableAdapter1 = new EasyStore.DataSet1TableAdapters.COMMANDETableAdapter();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.btnSuppimerClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(228, 457);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(229, 41);
            this.btnUpdateClient.TabIndex = 29;
            this.btnUpdateClient.Text = "&Modifier informations";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // lblEditClient
            // 
            this.lblEditClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.Location = new System.Drawing.Point(202, 77);
            this.lblEditClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(193, 60);
            this.lblEditClient.TabIndex = 32;
            this.lblEditClient.Text = "Client n°";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 20);
            this.pnlHeader.TabIndex = 30;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(39, 90);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(16, 16);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "IT";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.ForeColor = System.Drawing.Color.White;
            this.lblMarque.Location = new System.Drawing.Point(-1, 68);
            this.lblMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(104, 21);
            this.lblMarque.TabIndex = 0;
            this.lblMarque.Text = "InfoSolution";
            // 
            // picEntreprise
            // 
            this.picEntreprise.Image = ((System.Drawing.Image)(resources.GetObject("picEntreprise.Image")));
            this.picEntreprise.Location = new System.Drawing.Point(19, 10);
            this.picEntreprise.Margin = new System.Windows.Forms.Padding(2);
            this.picEntreprise.Name = "picEntreprise";
            this.picEntreprise.Size = new System.Drawing.Size(58, 56);
            this.picEntreprise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEntreprise.TabIndex = 2;
            this.picEntreprise.TabStop = false;
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitre.Controls.Add(this.lblSlogan);
            this.pnlTitre.Controls.Add(this.lblMarque);
            this.pnlTitre.Controls.Add(this.picEntreprise);
            this.pnlTitre.Location = new System.Drawing.Point(50, 20);
            this.pnlTitre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(96, 116);
            this.pnlTitre.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(274, 371);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodePostal.Location = new System.Drawing.Point(274, 334);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodePostal.MaxLength = 5;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(136, 20);
            this.txtCodePostal.TabIndex = 40;
            this.txtCodePostal.TextChanged += new System.EventHandler(this.txtCodePostal_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAdresse.Location = new System.Drawing.Point(274, 297);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(136, 20);
            this.txtAdresse.TabIndex = 38;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNom.Location = new System.Drawing.Point(274, 260);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(136, 20);
            this.txtNom.TabIndex = 36;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrenom.Location = new System.Drawing.Point(274, 223);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(136, 20);
            this.txtPrenom.TabIndex = 34;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(195, 374);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 13);
            this.lblMail.TabIndex = 41;
            this.lblMail.Text = "&Email :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(195, 337);
            this.lblCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(69, 13);
            this.lblCodePostal.TabIndex = 39;
            this.lblCodePostal.Text = "C&ode postal :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(195, 300);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 37;
            this.lblAdresse.Text = "&Adresse :";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(195, 263);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 35;
            this.lblNom.Text = "&Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(195, 226);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 33;
            this.lblPrenom.Text = "&Prénom :";
            // 
            // commandeTableAdapter1
            // 
            this.commandeTableAdapter1.ClearBeforeFill = true;
            // 
            // lblIdUser
            // 
            this.lblIdUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.Location = new System.Drawing.Point(399, 77);
            this.lblIdUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(0, 60);
            this.lblIdUser.TabIndex = 43;
            // 
            // btnSuppimerClient
            // 
            this.btnSuppimerClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuppimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppimerClient.Location = new System.Drawing.Point(228, 502);
            this.btnSuppimerClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppimerClient.Name = "btnSuppimerClient";
            this.btnSuppimerClient.Size = new System.Drawing.Size(229, 41);
            this.btnSuppimerClient.TabIndex = 44;
            this.btnSuppimerClient.Text = "&Supprimer client";
            this.btnSuppimerClient.UseVisualStyleBackColor = true;
            this.btnSuppimerClient.Click += new System.EventHandler(this.btnSuppimerClient_Click);
            // 
            // frmAdminUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.btnSuppimerClient);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.lblEditClient);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTitre);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmAdminUpdateClient";
            this.Text = "Modification information client";
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Label lblEditClient;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private DataSet1TableAdapters.COMMANDETableAdapter commandeTableAdapter1;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Button btnSuppimerClient;
    }
}