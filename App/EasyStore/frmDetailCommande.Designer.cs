namespace EasyStore
{
    partial class frmDetailCommande
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailCommande));
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDetailCommande = new System.Windows.Forms.Label();
            this.dtgDetailCommande = new System.Windows.Forms.DataGridView();
            this.vWCOMMANDEDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EasyStore.DataSet1();
            this.lblNumero = new System.Windows.Forms.Label();
            this.vW_COMMANDEDETAILTableAdapter = new EasyStore.DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetailCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitre.Controls.Add(this.lblSlogan);
            this.pnlTitre.Controls.Add(this.lblMarque);
            this.pnlTitre.Controls.Add(this.picEntreprise);
            this.pnlTitre.Location = new System.Drawing.Point(20, 20);
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
            this.pnlHeader.Size = new System.Drawing.Size(784, 20);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblDetailCommande
            // 
            this.lblDetailCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetailCommande.AutoSize = true;
            this.lblDetailCommande.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailCommande.Location = new System.Drawing.Point(212, 76);
            this.lblDetailCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailCommande.Name = "lblDetailCommande";
            this.lblDetailCommande.Size = new System.Drawing.Size(308, 60);
            this.lblDetailCommande.TabIndex = 7;
            this.lblDetailCommande.Text = "Commande n° ";
            // 
            // dtgDetailCommande
            // 
            this.dtgDetailCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgDetailCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetailCommande.Location = new System.Drawing.Point(34, 172);
            this.dtgDetailCommande.Name = "dtgDetailCommande";
            this.dtgDetailCommande.Size = new System.Drawing.Size(716, 416);
            this.dtgDetailCommande.TabIndex = 8;
            // 
            // vWCOMMANDEDETAILBindingSource
            // 
            this.vWCOMMANDEDETAILBindingSource.DataMember = "VW_COMMANDEDETAIL";
            this.vWCOMMANDEDETAILBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(499, 76);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 60);
            this.lblNumero.TabIndex = 10;
            // 
            // vW_COMMANDEDETAILTableAdapter
            // 
            this.vW_COMMANDEDETAILTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dtgDetailCommande);
            this.Controls.Add(this.lblDetailCommande);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 700);
            this.Name = "frmDetailCommande";
            this.Text = "Commande n° 000";
            this.Load += new System.EventHandler(this.frmDetailCommande_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetailCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDetailCommande;
        private System.Windows.Forms.DataGridView dtgDetailCommande;
        private System.Windows.Forms.Label lblNumero;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vWCOMMANDEDETAILBindingSource;
        private DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter vW_COMMANDEDETAILTableAdapter;
    }
}