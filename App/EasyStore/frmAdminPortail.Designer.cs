namespace EasyStore
{
    partial class frmAdminPortail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPortail));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnGestionCommande = new System.Windows.Forms.Button();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnGestionClient = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.dtgProduit = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWPRODUITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EasyStore.DataSet1();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.lblGestionProduit = new System.Windows.Forms.Label();
            this.txtFiltreProduit = new System.Windows.Forms.TextBox();
            this.lblFiltreProduit = new System.Windows.Forms.Label();
            this.vW_PRODUITTableAdapter = new EasyStore.DataSet1TableAdapters.VW_PRODUITTableAdapter();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.btnDeconnexion);
            this.pnlNavigation.Controls.Add(this.btnGestionCommande);
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnGestionClient);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(161, 761);
            this.pnlNavigation.TabIndex = 3;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeconnexion.ForeColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Location = new System.Drawing.Point(-6, 224);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(169, 40);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Se &déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click_1);
            // 
            // btnGestionCommande
            // 
            this.btnGestionCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionCommande.FlatAppearance.BorderSize = 0;
            this.btnGestionCommande.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionCommande.ForeColor = System.Drawing.Color.Black;
            this.btnGestionCommande.Location = new System.Drawing.Point(-2, 185);
            this.btnGestionCommande.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionCommande.Name = "btnGestionCommande";
            this.btnGestionCommande.Size = new System.Drawing.Size(169, 40);
            this.btnGestionCommande.TabIndex = 2;
            this.btnGestionCommande.Text = "Gestion &commande";
            this.btnGestionCommande.UseVisualStyleBackColor = false;
            this.btnGestionCommande.Click += new System.EventHandler(this.btnGestionCommande_Click);
            // 
            // pnlStyle
            // 
            this.pnlStyle.BackColor = System.Drawing.Color.Maroon;
            this.pnlStyle.Location = new System.Drawing.Point(-1, 107);
            this.pnlStyle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStyle.Name = "pnlStyle";
            this.pnlStyle.Size = new System.Drawing.Size(6, 40);
            this.pnlStyle.TabIndex = 4;
            // 
            // btnGestionClient
            // 
            this.btnGestionClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionClient.FlatAppearance.BorderSize = 0;
            this.btnGestionClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionClient.ForeColor = System.Drawing.Color.Black;
            this.btnGestionClient.Location = new System.Drawing.Point(-2, 146);
            this.btnGestionClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionClient.Name = "btnGestionClient";
            this.btnGestionClient.Size = new System.Drawing.Size(169, 40);
            this.btnGestionClient.TabIndex = 1;
            this.btnGestionClient.Text = "&Gestion client";
            this.btnGestionClient.UseVisualStyleBackColor = false;
            this.btnGestionClient.Click += new System.EventHandler(this.btnGestionClient_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShop.ForeColor = System.Drawing.Color.Black;
            this.btnShop.Location = new System.Drawing.Point(-2, 107);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 40);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // dtgProduit
            // 
            this.dtgProduit.AllowUserToAddRows = false;
            this.dtgProduit.AllowUserToDeleteRows = false;
            this.dtgProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgProduit.AutoGenerateColumns = false;
            this.dtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn,
            this.mODELEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.mARQUEDataGridViewTextBoxColumn,
            this.pRIXDataGridViewTextBoxColumn,
            this.IMAGE});
            this.dtgProduit.DataSource = this.vWPRODUITBindingSource;
            this.dtgProduit.Location = new System.Drawing.Point(334, 172);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.ReadOnly = true;
            this.dtgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProduit.Size = new System.Drawing.Size(716, 416);
            this.dtgProduit.TabIndex = 4;
            this.dtgProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduit_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "Type";
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            this.tYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELEDataGridViewTextBoxColumn
            // 
            this.mODELEDataGridViewTextBoxColumn.DataPropertyName = "MODELE";
            this.mODELEDataGridViewTextBoxColumn.HeaderText = "Modèle";
            this.mODELEDataGridViewTextBoxColumn.Name = "mODELEDataGridViewTextBoxColumn";
            this.mODELEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mARQUEDataGridViewTextBoxColumn
            // 
            this.mARQUEDataGridViewTextBoxColumn.DataPropertyName = "MARQUE";
            this.mARQUEDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.mARQUEDataGridViewTextBoxColumn.Name = "mARQUEDataGridViewTextBoxColumn";
            this.mARQUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIXDataGridViewTextBoxColumn
            // 
            this.pRIXDataGridViewTextBoxColumn.DataPropertyName = "PRIX";
            this.pRIXDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.pRIXDataGridViewTextBoxColumn.Name = "pRIXDataGridViewTextBoxColumn";
            this.pRIXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            // 
            // vWPRODUITBindingSource
            // 
            this.vWPRODUITBindingSource.DataMember = "VW_PRODUIT";
            this.vWPRODUITBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAjoutProduit.Location = new System.Drawing.Point(889, 678);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(161, 41);
            this.btnAjoutProduit.TabIndex = 2;
            this.btnAjoutProduit.Text = "&Ajouter produit";
            this.btnAjoutProduit.UseVisualStyleBackColor = true;
            this.btnAjoutProduit.Click += new System.EventHandler(this.btnAjoutProduit_Click);
            // 
            // lblGestionProduit
            // 
            this.lblGestionProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestionProduit.AutoSize = true;
            this.lblGestionProduit.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProduit.Location = new System.Drawing.Point(528, 76);
            this.lblGestionProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionProduit.Name = "lblGestionProduit";
            this.lblGestionProduit.Size = new System.Drawing.Size(330, 60);
            this.lblGestionProduit.TabIndex = 7;
            this.lblGestionProduit.Text = "Gestion produit";
            // 
            // txtFiltreProduit
            // 
            this.txtFiltreProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltreProduit.Location = new System.Drawing.Point(383, 147);
            this.txtFiltreProduit.Name = "txtFiltreProduit";
            this.txtFiltreProduit.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreProduit.TabIndex = 1;
            this.txtFiltreProduit.TextChanged += new System.EventHandler(this.txtFiltreProduit_TextChanged);
            // 
            // lblFiltreProduit
            // 
            this.lblFiltreProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltreProduit.AutoSize = true;
            this.lblFiltreProduit.Location = new System.Drawing.Point(331, 150);
            this.lblFiltreProduit.Name = "lblFiltreProduit";
            this.lblFiltreProduit.Size = new System.Drawing.Size(46, 13);
            this.lblFiltreProduit.TabIndex = 0;
            this.lblFiltreProduit.Text = "&Produit :";
            // 
            // vW_PRODUITTableAdapter
            // 
            this.vW_PRODUITTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminPortail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblFiltreProduit);
            this.Controls.Add(this.txtFiltreProduit);
            this.Controls.Add(this.lblGestionProduit);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.btnAjoutProduit);
            this.Controls.Add(this.dtgProduit);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 760);
            this.Name = "frmAdminPortail";
            this.Text = "Gestion produit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminPortail_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminPortail_Load);
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnGestionClient;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.DataGridView dtgProduit;
        private System.Windows.Forms.Button btnGestionCommande;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAjoutProduit;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblGestionProduit;
        private System.Windows.Forms.TextBox txtFiltreProduit;
        private System.Windows.Forms.Label lblFiltreProduit;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vWPRODUITBindingSource;
        private DataSet1TableAdapters.VW_PRODUITTableAdapter vW_PRODUITTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
    }
}