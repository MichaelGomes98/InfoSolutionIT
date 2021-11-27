namespace EasyStore
{
    partial class frmAdminAjoutProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAjoutProduit));
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblMarqueProduit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblAjoutProduit = new System.Windows.Forms.Label();
            this.btnTelecharger = new System.Windows.Forms.Button();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.lblModele = new System.Windows.Forms.Label();
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.cboTypeProduit = new System.Windows.Forms.ComboBox();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.commandeTableAdapter1 = new EasyStore.DataSet1TableAdapters.COMMANDETableAdapter();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTitre.TabIndex = 14;
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
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 20);
            this.pnlHeader.TabIndex = 13;
            // 
            // txtPrix
            // 
            this.txtPrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrix.Location = new System.Drawing.Point(274, 377);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(136, 20);
            this.txtPrix.TabIndex = 9;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // txtMarque
            // 
            this.txtMarque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMarque.Location = new System.Drawing.Point(274, 342);
            this.txtMarque.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(136, 20);
            this.txtMarque.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(274, 307);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // lblImage
            // 
            this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(194, 420);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 13);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "&Image :";
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(194, 384);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 13);
            this.lblPrix.TabIndex = 8;
            this.lblPrix.Text = "P&rix :";
            // 
            // lblMarqueProduit
            // 
            this.lblMarqueProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarqueProduit.AutoSize = true;
            this.lblMarqueProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueProduit.Location = new System.Drawing.Point(194, 348);
            this.lblMarqueProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarqueProduit.Name = "lblMarqueProduit";
            this.lblMarqueProduit.Size = new System.Drawing.Size(49, 13);
            this.lblMarqueProduit.TabIndex = 6;
            this.lblMarqueProduit.Text = "&Marque :";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(194, 312);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "&Description :";
            // 
            // lblProduit
            // 
            this.lblProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.Location = new System.Drawing.Point(194, 240);
            this.lblProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(46, 13);
            this.lblProduit.TabIndex = 0;
            this.lblProduit.Text = "&Produit :";
            // 
            // lblAjoutProduit
            // 
            this.lblAjoutProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAjoutProduit.AutoSize = true;
            this.lblAjoutProduit.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutProduit.Location = new System.Drawing.Point(202, 76);
            this.lblAjoutProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAjoutProduit.Name = "lblAjoutProduit";
            this.lblAjoutProduit.Size = new System.Drawing.Size(280, 60);
            this.lblAjoutProduit.TabIndex = 15;
            this.lblAjoutProduit.Text = "Ajout produit";
            // 
            // btnTelecharger
            // 
            this.btnTelecharger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTelecharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelecharger.Location = new System.Drawing.Point(274, 412);
            this.btnTelecharger.Margin = new System.Windows.Forms.Padding(2);
            this.btnTelecharger.Name = "btnTelecharger";
            this.btnTelecharger.Size = new System.Drawing.Size(136, 28);
            this.btnTelecharger.TabIndex = 11;
            this.btnTelecharger.Text = "&Télécharger image";
            this.btnTelecharger.UseVisualStyleBackColor = true;
            this.btnTelecharger.Click += new System.EventHandler(this.btnTelecharger_Click);
            // 
            // txtModele
            // 
            this.txtModele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModele.Location = new System.Drawing.Point(274, 273);
            this.txtModele.Margin = new System.Windows.Forms.Padding(2);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(136, 20);
            this.txtModele.TabIndex = 3;
            // 
            // lblModele
            // 
            this.lblModele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModele.AutoSize = true;
            this.lblModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModele.Location = new System.Drawing.Point(194, 276);
            this.lblModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(48, 13);
            this.lblModele.TabIndex = 2;
            this.lblModele.Text = "M&odele :";
            // 
            // picProduit
            // 
            this.picProduit.Location = new System.Drawing.Point(418, 405);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(39, 47);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 16;
            this.picProduit.TabStop = false;
            this.picProduit.Visible = false;
            // 
            // cboTypeProduit
            // 
            this.cboTypeProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTypeProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeProduit.FormattingEnabled = true;
            this.cboTypeProduit.Items.AddRange(new object[] {
            "Moniteur Gaming",
            "Moniteur Bureau"});
            this.cboTypeProduit.Location = new System.Drawing.Point(274, 237);
            this.cboTypeProduit.Name = "cboTypeProduit";
            this.cboTypeProduit.Size = new System.Drawing.Size(136, 21);
            this.cboTypeProduit.TabIndex = 17;
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAjoutProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutProduit.Location = new System.Drawing.Point(228, 507);
            this.btnAjoutProduit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(229, 41);
            this.btnAjoutProduit.TabIndex = 12;
            this.btnAjoutProduit.Text = "&Ajouter produit";
            this.btnAjoutProduit.UseVisualStyleBackColor = true;
            this.btnAjoutProduit.Click += new System.EventHandler(this.btnAjoutProduit_Click);
            // 
            // commandeTableAdapter1
            // 
            this.commandeTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAdminAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.cboTypeProduit);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.btnTelecharger);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblMarqueProduit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.btnAjoutProduit);
            this.Controls.Add(this.lblAjoutProduit);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmAdminAjoutProduit";
            this.Text = "Ajout produit";
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblMarqueProduit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblAjoutProduit;
        private System.Windows.Forms.Button btnTelecharger;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.PictureBox picProduit;
        private DataSet1TableAdapters.COMMANDETableAdapter commandeTableAdapter1;
        private System.Windows.Forms.ComboBox cboTypeProduit;
        private System.Windows.Forms.Button btnAjoutProduit;
    }
}