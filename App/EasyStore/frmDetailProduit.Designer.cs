namespace EasyStore
{
    partial class frmDetailProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailProduit));
            this.picImageProduit = new System.Windows.Forms.PictureBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblSeulement = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMarqueProduit = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnPanier = new System.Windows.Forms.Button();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.lblSeConnecterPourCommander = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduit)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageProduit
            // 
            this.picImageProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picImageProduit.Image = ((System.Drawing.Image)(resources.GetObject("picImageProduit.Image")));
            this.picImageProduit.Location = new System.Drawing.Point(217, 193);
            this.picImageProduit.Margin = new System.Windows.Forms.Padding(2);
            this.picImageProduit.Name = "picImageProduit";
            this.picImageProduit.Size = new System.Drawing.Size(334, 334);
            this.picImageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduit.TabIndex = 6;
            this.picImageProduit.TabStop = false;
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrix.Location = new System.Drawing.Point(701, 208);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(331, 80);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "200.00 CHF";
            // 
            // lblSeulement
            // 
            this.lblSeulement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeulement.AutoSize = true;
            this.lblSeulement.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeulement.ForeColor = System.Drawing.Color.Maroon;
            this.lblSeulement.Location = new System.Drawing.Point(712, 193);
            this.lblSeulement.Name = "lblSeulement";
            this.lblSeulement.Size = new System.Drawing.Size(65, 15);
            this.lblSeulement.TabIndex = 6;
            this.lblSeulement.Text = "Seulement à";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.Location = new System.Drawing.Point(712, 360);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(588, 140);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblMarqueProduit
            // 
            this.lblMarqueProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarqueProduit.AutoSize = true;
            this.lblMarqueProduit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueProduit.Location = new System.Drawing.Point(710, 313);
            this.lblMarqueProduit.Name = "lblMarqueProduit";
            this.lblMarqueProduit.Size = new System.Drawing.Size(92, 26);
            this.lblMarqueProduit.TabIndex = 8;
            this.lblMarqueProduit.Text = "Samsung";
            // 
            // lblModele
            // 
            this.lblModele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModele.AutoSize = true;
            this.lblModele.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModele.Location = new System.Drawing.Point(808, 313);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(192, 26);
            this.lblModele.TabIndex = 9;
            this.lblModele.Text = "QLED Gaming Monitor";
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAjoutPanier.Location = new System.Drawing.Point(1132, 590);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(168, 40);
            this.btnAjoutPanier.TabIndex = 2;
            this.btnAjoutPanier.Text = "&Ajouter au panier";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
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
            this.pnlTitre.TabIndex = 5;
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
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.btnPanier);
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnSeConnecter);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(161, 761);
            this.pnlNavigation.TabIndex = 3;
            // 
            // btnPanier
            // 
            this.btnPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPanier.FlatAppearance.BorderSize = 0;
            this.btnPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanier.ForeColor = System.Drawing.Color.Black;
            this.btnPanier.Location = new System.Drawing.Point(-4, 185);
            this.btnPanier.Margin = new System.Windows.Forms.Padding(2);
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.Size = new System.Drawing.Size(169, 40);
            this.btnPanier.TabIndex = 3;
            this.btnPanier.Text = "&Panier";
            this.btnPanier.UseVisualStyleBackColor = false;
            this.btnPanier.Click += new System.EventHandler(this.btnPanier_Click);
            // 
            // pnlStyle
            // 
            this.pnlStyle.BackColor = System.Drawing.Color.Maroon;
            this.pnlStyle.Location = new System.Drawing.Point(-1, 107);
            this.pnlStyle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStyle.Name = "pnlStyle";
            this.pnlStyle.Size = new System.Drawing.Size(6, 40);
            this.pnlStyle.TabIndex = 1;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeConnecter.ForeColor = System.Drawing.Color.Black;
            this.btnSeConnecter.Location = new System.Drawing.Point(-4, 146);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(169, 40);
            this.btnSeConnecter.TabIndex = 2;
            this.btnSeConnecter.Text = "Se &connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShop.ForeColor = System.Drawing.Color.Black;
            this.btnShop.Location = new System.Drawing.Point(-4, 107);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 40);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(161, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1223, 20);
            this.pnlHeader.TabIndex = 4;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudQuantite.Location = new System.Drawing.Point(1073, 599);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(39, 20);
            this.nudQuantite.TabIndex = 1;
            // 
            // lblQuantité
            // 
            this.lblQuantité.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantité.Location = new System.Drawing.Point(989, 599);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(78, 20);
            this.lblQuantité.TabIndex = 0;
            this.lblQuantité.Text = "&Quantité :";
            // 
            // lblSeConnecterPourCommander
            // 
            this.lblSeConnecterPourCommander.AutoSize = true;
            this.lblSeConnecterPourCommander.ForeColor = System.Drawing.Color.Red;
            this.lblSeConnecterPourCommander.Location = new System.Drawing.Point(1015, 633);
            this.lblSeConnecterPourCommander.Name = "lblSeConnecterPourCommander";
            this.lblSeConnecterPourCommander.Size = new System.Drawing.Size(0, 13);
            this.lblSeConnecterPourCommander.TabIndex = 11;
            // 
            // frmDetailProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblSeConnecterPourCommander);
            this.Controls.Add(this.lblQuantité);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblMarqueProduit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSeulement);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.picImageProduit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmDetailProduit";
            this.Text = "Détail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetailProduit_FormClosed);
            this.Load += new System.EventHandler(this.frmDetailProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduit)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picImageProduit;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblSeulement;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMarqueProduit;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Button btnAjoutPanier;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.Label lblSeConnecterPourCommander;
    }
}