namespace EasyStore
{
    partial class frmAdminModifierCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminModifierCommande));
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.txtTotalCommande = new System.Windows.Forms.TextBox();
            this.lblTotalCommande = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblModificationCommande = new System.Windows.Forms.Label();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNum = new System.Windows.Forms.Label();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStatut
            // 
            this.cboStatut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStatut.FormattingEnabled = true;
            this.cboStatut.Items.AddRange(new object[] {
            "En preparation",
            "Annulé",
            "Prête à être retiré",
            "Panier"});
            this.cboStatut.Location = new System.Drawing.Point(278, 243);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(136, 21);
            this.cboStatut.TabIndex = 1;
            // 
            // txtTotalCommande
            // 
            this.txtTotalCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalCommande.Location = new System.Drawing.Point(278, 279);
            this.txtTotalCommande.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCommande.Name = "txtTotalCommande";
            this.txtTotalCommande.Size = new System.Drawing.Size(136, 20);
            this.txtTotalCommande.TabIndex = 3;
            this.txtTotalCommande.TextChanged += new System.EventHandler(this.txtTotalCommande_TextChanged);
            // 
            // lblTotalCommande
            // 
            this.lblTotalCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalCommande.AutoSize = true;
            this.lblTotalCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCommande.Location = new System.Drawing.Point(198, 282);
            this.lblTotalCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCommande.Name = "lblTotalCommande";
            this.lblTotalCommande.Size = new System.Drawing.Size(37, 13);
            this.lblTotalCommande.TabIndex = 2;
            this.lblTotalCommande.Text = "&Total :";
            // 
            // lblStatut
            // 
            this.lblStatut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(198, 246);
            this.lblStatut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 0;
            this.lblStatut.Text = "&Statut :";
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(245, 387);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(195, 41);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblModificationCommande
            // 
            this.lblModificationCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModificationCommande.AutoSize = true;
            this.lblModificationCommande.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificationCommande.Location = new System.Drawing.Point(153, 82);
            this.lblModificationCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificationCommande.Name = "lblModificationCommande";
            this.lblModificationCommande.Size = new System.Drawing.Size(378, 60);
            this.lblModificationCommande.TabIndex = 7;
            this.lblModificationCommande.Text = "Edit commande n°";
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 20);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblNum
            // 
            this.lblNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(518, 82);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 60);
            this.lblNum.TabIndex = 8;
            // 
            // frmAdminModifierCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.cboStatut);
            this.Controls.Add(this.txtTotalCommande);
            this.Controls.Add(this.lblTotalCommande);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblModificationCommande);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAdminModifierCommande";
            this.Text = "frmAdminModifierCommande";
            this.Load += new System.EventHandler(this.frmAdminModifierCommande_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.TextBox txtTotalCommande;
        private System.Windows.Forms.Label lblTotalCommande;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblModificationCommande;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNum;
    }
}