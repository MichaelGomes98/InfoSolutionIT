namespace EasyStore
{
    partial class frmPanier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanier));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.dtgPanier = new System.Windows.Forms.DataGridView();
            this.lblPanier = new System.Windows.Forms.Label();
            this.btnCommander = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTotalArticle = new System.Windows.Forms.Label();
            this.lblTotalPrix = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPanier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnSeConnecter);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(165, 761);
            this.pnlNavigation.TabIndex = 1;
            // 
            // pnlStyle
            // 
            this.pnlStyle.BackColor = System.Drawing.Color.Maroon;
            this.pnlStyle.Location = new System.Drawing.Point(-1, 116);
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
            this.btnSeConnecter.Location = new System.Drawing.Point(-2, 154);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(169, 40);
            this.btnSeConnecter.TabIndex = 2;
            this.btnSeConnecter.Text = "S&e connecter";
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
            this.btnShop.Location = new System.Drawing.Point(-2, 116);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 40);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // dtgPanier
            // 
            this.dtgPanier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPanier.Location = new System.Drawing.Point(409, 185);
            this.dtgPanier.Margin = new System.Windows.Forms.Padding(2);
            this.dtgPanier.Name = "dtgPanier";
            this.dtgPanier.RowTemplate.Height = 33;
            this.dtgPanier.Size = new System.Drawing.Size(566, 297);
            this.dtgPanier.TabIndex = 2;
            // 
            // lblPanier
            // 
            this.lblPanier.AccessibleName = "";
            this.lblPanier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPanier.AutoSize = true;
            this.lblPanier.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanier.Location = new System.Drawing.Point(569, 76);
            this.lblPanier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(246, 60);
            this.lblPanier.TabIndex = 5;
            this.lblPanier.Text = "Mon panier";
            // 
            // btnCommander
            // 
            this.btnCommander.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCommander.Location = new System.Drawing.Point(645, 509);
            this.btnCommander.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(94, 36);
            this.btnCommander.TabIndex = 0;
            this.btnCommander.Text = "&Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
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
            this.pnlTitre.Location = new System.Drawing.Point(215, 20);
            this.pnlTitre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(96, 116);
            this.pnlTitre.TabIndex = 4;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(165, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1219, 20);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTotalArticle
            // 
            this.lblTotalArticle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalArticle.AutoSize = true;
            this.lblTotalArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArticle.Location = new System.Drawing.Point(411, 484);
            this.lblTotalArticle.Name = "lblTotalArticle";
            this.lblTotalArticle.Size = new System.Drawing.Size(45, 13);
            this.lblTotalArticle.TabIndex = 6;
            this.lblTotalArticle.Text = "0 Article";
            // 
            // lblTotalPrix
            // 
            this.lblTotalPrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPrix.AutoSize = true;
            this.lblTotalPrix.Location = new System.Drawing.Point(918, 484);
            this.lblTotalPrix.Name = "lblTotalPrix";
            this.lblTotalPrix.Size = new System.Drawing.Size(52, 13);
            this.lblTotalPrix.TabIndex = 7;
            this.lblTotalPrix.Text = "0.00 CHF";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(456, 154);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(472, 18);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Veuillez vous connecter pour pouvoir passer des commandes";
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTotalPrix);
            this.Controls.Add(this.lblTotalArticle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.lblPanier);
            this.Controls.Add(this.dtgPanier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmPanier";
            this.Text = "Panier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPanier_FormClosed);
            this.Load += new System.EventHandler(this.frmPanier_Load);
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPanier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.DataGridView dtgPanier;
        private System.Windows.Forms.Label lblPanier;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTotalArticle;
        private System.Windows.Forms.Label lblTotalPrix;
        private System.Windows.Forms.Label lblInfo;
    }
}