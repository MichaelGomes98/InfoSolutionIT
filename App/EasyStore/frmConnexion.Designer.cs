namespace EasyStore
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblCreationCompte = new System.Windows.Forms.LinkLabel();
            this.btnPanier = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AccessibleName = "";
            this.lblConnexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConnexion.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(519, 82);
            this.lblConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(346, 54);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connectez-vous";
            this.lblConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreationCompte
            // 
            this.lblCreationCompte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreationCompte.AutoSize = true;
            this.lblCreationCompte.LinkColor = System.Drawing.Color.Black;
            this.lblCreationCompte.Location = new System.Drawing.Point(650, 561);
            this.lblCreationCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationCompte.Name = "lblCreationCompte";
            this.lblCreationCompte.Size = new System.Drawing.Size(85, 13);
            this.lblCreationCompte.TabIndex = 5;
            this.lblCreationCompte.TabStop = true;
            this.lblCreationCompte.Text = "Créer &un compte";
            this.lblCreationCompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreationCompte_LinkClicked);
            // 
            // btnPanier
            // 
            this.btnPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPanier.FlatAppearance.BorderSize = 0;
            this.btnPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanier.ForeColor = System.Drawing.Color.Black;
            this.btnPanier.Location = new System.Drawing.Point(-4, 147);
            this.btnPanier.Margin = new System.Windows.Forms.Padding(2);
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.Size = new System.Drawing.Size(169, 40);
            this.btnPanier.TabIndex = 2;
            this.btnPanier.Text = "&Panier";
            this.btnPanier.UseVisualStyleBackColor = false;
            this.btnPanier.Click += new System.EventHandler(this.btnPanier_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShop.ForeColor = System.Drawing.Color.Black;
            this.btnShop.Location = new System.Drawing.Point(-4, 109);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 40);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.pnlStyle);
            this.pnlMenu.Controls.Add(this.btnPanier);
            this.pnlMenu.Controls.Add(this.btnShop);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(161, 761);
            this.pnlMenu.TabIndex = 6;
            // 
            // pnlStyle
            // 
            this.pnlStyle.BackColor = System.Drawing.Color.Maroon;
            this.pnlStyle.Location = new System.Drawing.Point(-1, 109);
            this.pnlStyle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStyle.Name = "pnlStyle";
            this.pnlStyle.Size = new System.Drawing.Size(6, 40);
            this.pnlStyle.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(618, 230);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMotDePasse.Location = new System.Drawing.Point(618, 274);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(148, 20);
            this.txtMotDePasse.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnexion.Location = new System.Drawing.Point(645, 338);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(94, 40);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Se &connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click_1);
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitre.Controls.Add(this.lblSlogan);
            this.pnlTitre.Controls.Add(this.lblMarque);
            this.pnlTitre.Controls.Add(this.picEntreprise);
            this.pnlTitre.Location = new System.Drawing.Point(211, 20);
            this.pnlTitre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(96, 116);
            this.pnlTitre.TabIndex = 8;
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(161, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1223, 20);
            this.pnlHeader.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(502, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "&Email :";
            // 
            // lblMDP
            // 
            this.lblMDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(502, 277);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(77, 13);
            this.lblMDP.TabIndex = 2;
            this.lblMDP.Text = "&Mot de passe :";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCreationCompte);
            this.Controls.Add(this.lblConnexion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "frmConnexion";
            this.Text = "Connectez-vous";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConnexion_FormClosed);
            this.Load += new System.EventHandler(this.EasyShop_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.LinkLabel lblCreationCompte;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMDP;
    }
}

