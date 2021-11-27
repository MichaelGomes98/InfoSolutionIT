namespace EasyStore
{
    partial class frmClientCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientCommande));
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMonCompte = new System.Windows.Forms.Button();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.btnMesInformations = new System.Windows.Forms.Button();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMesCommandes = new System.Windows.Forms.Label();
            this.dtgCommande = new System.Windows.Forms.DataGridView();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCommande)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTitre.TabIndex = 6;
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnMonCompte);
            this.pnlMenu.Controls.Add(this.btnSeDeconnecter);
            this.pnlMenu.Controls.Add(this.btnMesInformations);
            this.pnlMenu.Controls.Add(this.pnlStyle);
            this.pnlMenu.Controls.Add(this.btnShop);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(161, 761);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnMonCompte
            // 
            this.btnMonCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMonCompte.FlatAppearance.BorderSize = 0;
            this.btnMonCompte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonCompte.ForeColor = System.Drawing.Color.Black;
            this.btnMonCompte.Location = new System.Drawing.Point(-7, 148);
            this.btnMonCompte.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonCompte.Name = "btnMonCompte";
            this.btnMonCompte.Size = new System.Drawing.Size(169, 40);
            this.btnMonCompte.TabIndex = 2;
            this.btnMonCompte.Text = "Mon &compte";
            this.btnMonCompte.UseVisualStyleBackColor = false;
            this.btnMonCompte.Click += new System.EventHandler(this.btnMonCompte_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.Black;
            this.btnSeDeconnecter.Location = new System.Drawing.Point(-3, 226);
            this.btnSeDeconnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(169, 40);
            this.btnSeDeconnecter.TabIndex = 4;
            this.btnSeDeconnecter.Text = "Se &déconnecter";
            this.btnSeDeconnecter.UseVisualStyleBackColor = false;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // btnMesInformations
            // 
            this.btnMesInformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesInformations.FlatAppearance.BorderSize = 0;
            this.btnMesInformations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesInformations.ForeColor = System.Drawing.Color.Black;
            this.btnMesInformations.Location = new System.Drawing.Point(-3, 187);
            this.btnMesInformations.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesInformations.Name = "btnMesInformations";
            this.btnMesInformations.Size = new System.Drawing.Size(169, 40);
            this.btnMesInformations.TabIndex = 3;
            this.btnMesInformations.Text = "Mes &informations";
            this.btnMesInformations.UseVisualStyleBackColor = false;
            this.btnMesInformations.Click += new System.EventHandler(this.btnMesInformations_Click);
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
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShop.ForeColor = System.Drawing.Color.Black;
            this.btnShop.Location = new System.Drawing.Point(-2, 109);
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
            this.pnlHeader.Location = new System.Drawing.Point(161, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1223, 20);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblMesCommandes
            // 
            this.lblMesCommandes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMesCommandes.AutoSize = true;
            this.lblMesCommandes.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesCommandes.Location = new System.Drawing.Point(512, 76);
            this.lblMesCommandes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesCommandes.Name = "lblMesCommandes";
            this.lblMesCommandes.Size = new System.Drawing.Size(360, 60);
            this.lblMesCommandes.TabIndex = 7;
            this.lblMesCommandes.Text = "Mes commandes";
            // 
            // dtgCommande
            // 
            this.dtgCommande.AllowUserToAddRows = false;
            this.dtgCommande.AllowUserToDeleteRows = false;
            this.dtgCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCommande.Location = new System.Drawing.Point(334, 213);
            this.dtgCommande.Name = "dtgCommande";
            this.dtgCommande.ReadOnly = true;
            this.dtgCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCommande.Size = new System.Drawing.Size(716, 416);
            this.dtgCommande.TabIndex = 3;
            this.dtgCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCommande_CellContentClick);
            // 
            // frmClientCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblMesCommandes);
            this.Controls.Add(this.dtgCommande);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "frmClientCommande";
            this.Text = "Mes commandes";
            this.Load += new System.EventHandler(this.frmClientCommande_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMesCommandes;
        private System.Windows.Forms.DataGridView dtgCommande;
        private System.Windows.Forms.Button btnMesInformations;
        private System.Windows.Forms.Button btnSeDeconnecter;
        private System.Windows.Forms.Button btnMonCompte;
    }
}