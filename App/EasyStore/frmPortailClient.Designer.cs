namespace EasyStore
{
    partial class frmPortailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortailClient));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnMesInfo = new System.Windows.Forms.Button();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnMesCommandes = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblInfoClient = new System.Windows.Forms.Label();
            this.btnRetourAchat = new System.Windows.Forms.Button();
            this.picShop = new System.Windows.Forms.PictureBox();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.btnDeconnexion);
            this.pnlNavigation.Controls.Add(this.btnMesInfo);
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnMesCommandes);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(165, 761);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeconnexion.ForeColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Location = new System.Drawing.Point(-2, 222);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(169, 40);
            this.btnDeconnexion.TabIndex = 4;
            this.btnDeconnexion.Text = "Se &déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnMesInfo
            // 
            this.btnMesInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesInfo.FlatAppearance.BorderSize = 0;
            this.btnMesInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesInfo.ForeColor = System.Drawing.Color.Black;
            this.btnMesInfo.Location = new System.Drawing.Point(-2, 183);
            this.btnMesInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesInfo.Name = "btnMesInfo";
            this.btnMesInfo.Size = new System.Drawing.Size(169, 40);
            this.btnMesInfo.TabIndex = 3;
            this.btnMesInfo.Text = "Mes &informations";
            this.btnMesInfo.UseVisualStyleBackColor = false;
            this.btnMesInfo.Click += new System.EventHandler(this.btnMesInfo_Click);
            // 
            // pnlStyle
            // 
            this.pnlStyle.BackColor = System.Drawing.Color.Maroon;
            this.pnlStyle.Location = new System.Drawing.Point(-1, 105);
            this.pnlStyle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStyle.Name = "pnlStyle";
            this.pnlStyle.Size = new System.Drawing.Size(6, 40);
            this.pnlStyle.TabIndex = 1;
            // 
            // btnMesCommandes
            // 
            this.btnMesCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesCommandes.FlatAppearance.BorderSize = 0;
            this.btnMesCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesCommandes.ForeColor = System.Drawing.Color.Black;
            this.btnMesCommandes.Location = new System.Drawing.Point(-2, 144);
            this.btnMesCommandes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesCommandes.Name = "btnMesCommandes";
            this.btnMesCommandes.Size = new System.Drawing.Size(169, 40);
            this.btnMesCommandes.TabIndex = 2;
            this.btnMesCommandes.Text = "&Mes commandes";
            this.btnMesCommandes.UseVisualStyleBackColor = false;
            this.btnMesCommandes.Click += new System.EventHandler(this.btnMesCommandes_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShop.ForeColor = System.Drawing.Color.Black;
            this.btnShop.Location = new System.Drawing.Point(-2, 105);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 40);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(165, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1219, 20);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblInfoClient
            // 
            this.lblInfoClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoClient.AutoSize = true;
            this.lblInfoClient.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoClient.Location = new System.Drawing.Point(306, 450);
            this.lblInfoClient.Name = "lblInfoClient";
            this.lblInfoClient.Size = new System.Drawing.Size(963, 26);
            this.lblInfoClient.TabIndex = 5;
            this.lblInfoClient.Text = "Vous trouverez ici toutes les mises à jour concernant vos commandes ainsi que vos" +
    " informations personnelles.";
            // 
            // btnRetourAchat
            // 
            this.btnRetourAchat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRetourAchat.Location = new System.Drawing.Point(717, 587);
            this.btnRetourAchat.Name = "btnRetourAchat";
            this.btnRetourAchat.Size = new System.Drawing.Size(140, 40);
            this.btnRetourAchat.TabIndex = 0;
            this.btnRetourAchat.Text = "&Continuer mes achats";
            this.btnRetourAchat.UseVisualStyleBackColor = true;
            this.btnRetourAchat.Click += new System.EventHandler(this.btnRetourAchat_Click);
            // 
            // picShop
            // 
            this.picShop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picShop.Image = ((System.Drawing.Image)(resources.GetObject("picShop.Image")));
            this.picShop.Location = new System.Drawing.Point(717, 219);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(140, 142);
            this.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShop.TabIndex = 36;
            this.picShop.TabStop = false;
            // 
            // lblBonjour
            // 
            this.lblBonjour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBonjour.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.Location = new System.Drawing.Point(306, 144);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(164, 28);
            this.lblBonjour.TabIndex = 4;
            this.lblBonjour.Text = "Bonjour User,";
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitre.Controls.Add(this.lblSlogan);
            this.pnlTitre.Controls.Add(this.lblMarque);
            this.pnlTitre.Controls.Add(this.picEntreprise);
            this.pnlTitre.Location = new System.Drawing.Point(215, 20);
            this.pnlTitre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(96, 116);
            this.pnlTitre.TabIndex = 37;
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
            // frmPortailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.picShop);
            this.Controls.Add(this.btnRetourAchat);
            this.Controls.Add(this.lblInfoClient);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmPortailClient";
            this.Text = "Espace client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPortailClient_FormClosed);
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnMesInfo;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnMesCommandes;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblInfoClient;
        private System.Windows.Forms.Button btnRetourAchat;
        private System.Windows.Forms.PictureBox picShop;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
    }
}