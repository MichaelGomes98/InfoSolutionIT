namespace EasyStore
{
    partial class frmAdminGestionCommandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGestionCommandes));
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnGestionClient = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnPortailAdmin = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGestionCommande = new System.Windows.Forms.Label();
            this.dtgCommandes = new System.Windows.Forms.DataGridView();
            this.NUMEROCOMMANDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECOMMANDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUTCOMMANDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALCOMMANDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWCOMMANDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EasyStore.DataSet1();
            this.cboStatusCommande = new System.Windows.Forms.ComboBox();
            this.vWCOMMANDEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vWCOMMANDEDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_COMMANDEDETAILTableAdapter = new EasyStore.DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter();
            this.vW_COMMANDETableAdapter = new EasyStore.DataSet1TableAdapters.VW_COMMANDETableAdapter();
            this.vWCOMMANDEDETAILBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnViderLesFiltres = new System.Windows.Forms.Button();
            this.pnlNavigation.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.btnGestionClient.Location = new System.Drawing.Point(-2, 185);
            this.btnGestionClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionClient.Name = "btnGestionClient";
            this.btnGestionClient.Size = new System.Drawing.Size(169, 40);
            this.btnGestionClient.TabIndex = 2;
            this.btnGestionClient.Text = "&Gestion client";
            this.btnGestionClient.UseVisualStyleBackColor = false;
            this.btnGestionClient.Click += new System.EventHandler(this.btnGestionClient_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeconnexion.ForeColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Location = new System.Drawing.Point(-2, 224);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(169, 40);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Se &déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.btnPortailAdmin);
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Controls.Add(this.btnGestionClient);
            this.pnlNavigation.Controls.Add(this.btnDeconnexion);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(161, 761);
            this.pnlNavigation.TabIndex = 4;
            // 
            // btnPortailAdmin
            // 
            this.btnPortailAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPortailAdmin.FlatAppearance.BorderSize = 0;
            this.btnPortailAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortailAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnPortailAdmin.Location = new System.Drawing.Point(-6, 146);
            this.btnPortailAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPortailAdmin.Name = "btnPortailAdmin";
            this.btnPortailAdmin.Size = new System.Drawing.Size(169, 40);
            this.btnPortailAdmin.TabIndex = 1;
            this.btnPortailAdmin.Text = "Gestion &produit";
            this.btnPortailAdmin.UseVisualStyleBackColor = false;
            this.btnPortailAdmin.Click += new System.EventHandler(this.btnPortailAdmin_Click);
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
            // lblGestionCommande
            // 
            this.lblGestionCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestionCommande.AutoSize = true;
            this.lblGestionCommande.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCommande.Location = new System.Drawing.Point(489, 76);
            this.lblGestionCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionCommande.Name = "lblGestionCommande";
            this.lblGestionCommande.Size = new System.Drawing.Size(407, 60);
            this.lblGestionCommande.TabIndex = 7;
            this.lblGestionCommande.Text = "Gestion commande";
            // 
            // dtgCommandes
            // 
            this.dtgCommandes.AllowUserToAddRows = false;
            this.dtgCommandes.AllowUserToDeleteRows = false;
            this.dtgCommandes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgCommandes.AutoGenerateColumns = false;
            this.dtgCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMEROCOMMANDE,
            this.DATECOMMANDE,
            this.STATUTCOMMANDE,
            this.TOTALCOMMANDE,
            this.USERID,
            this.iDDataGridViewTextBoxColumn,
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn,
            this.dATECOMMANDEDataGridViewTextBoxColumn,
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn,
            this.tOTALCOMMANDEDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn});
            this.dtgCommandes.DataSource = this.vWCOMMANDEBindingSource;
            this.dtgCommandes.Location = new System.Drawing.Point(334, 172);
            this.dtgCommandes.Name = "dtgCommandes";
            this.dtgCommandes.ReadOnly = true;
            this.dtgCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCommandes.Size = new System.Drawing.Size(716, 416);
            this.dtgCommandes.TabIndex = 3;
            this.dtgCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCommandes_CellContentClick);
            this.dtgCommandes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCommandes_CellDoubleClick);
            // 
            // NUMEROCOMMANDE
            // 
            this.NUMEROCOMMANDE.DataPropertyName = "NUMEROCOMMANDE";
            this.NUMEROCOMMANDE.HeaderText = "NUMEROCOMMANDE";
            this.NUMEROCOMMANDE.Name = "NUMEROCOMMANDE";
            this.NUMEROCOMMANDE.ReadOnly = true;
            // 
            // DATECOMMANDE
            // 
            this.DATECOMMANDE.DataPropertyName = "DATECOMMANDE";
            this.DATECOMMANDE.HeaderText = "DATECOMMANDE";
            this.DATECOMMANDE.Name = "DATECOMMANDE";
            this.DATECOMMANDE.ReadOnly = true;
            // 
            // STATUTCOMMANDE
            // 
            this.STATUTCOMMANDE.DataPropertyName = "STATUTCOMMANDE";
            this.STATUTCOMMANDE.HeaderText = "STATUTCOMMANDE";
            this.STATUTCOMMANDE.Name = "STATUTCOMMANDE";
            this.STATUTCOMMANDE.ReadOnly = true;
            // 
            // TOTALCOMMANDE
            // 
            this.TOTALCOMMANDE.DataPropertyName = "TOTALCOMMANDE";
            this.TOTALCOMMANDE.HeaderText = "TOTALCOMMANDE";
            this.TOTALCOMMANDE.Name = "TOTALCOMMANDE";
            this.TOTALCOMMANDE.ReadOnly = true;
            // 
            // USERID
            // 
            this.USERID.DataPropertyName = "USERID";
            this.USERID.HeaderText = "USERID";
            this.USERID.Name = "USERID";
            this.USERID.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROCOMMANDEDataGridViewTextBoxColumn
            // 
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "NUMEROCOMMANDE";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.HeaderText = "NUMEROCOMMANDE";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.Name = "nUMEROCOMMANDEDataGridViewTextBoxColumn";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATECOMMANDEDataGridViewTextBoxColumn
            // 
            this.dATECOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "DATECOMMANDE";
            this.dATECOMMANDEDataGridViewTextBoxColumn.HeaderText = "DATECOMMANDE";
            this.dATECOMMANDEDataGridViewTextBoxColumn.Name = "dATECOMMANDEDataGridViewTextBoxColumn";
            this.dATECOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUTCOMMANDEDataGridViewTextBoxColumn
            // 
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "STATUTCOMMANDE";
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn.HeaderText = "STATUTCOMMANDE";
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn.Name = "sTATUTCOMMANDEDataGridViewTextBoxColumn";
            this.sTATUTCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALCOMMANDEDataGridViewTextBoxColumn
            // 
            this.tOTALCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "TOTALCOMMANDE";
            this.tOTALCOMMANDEDataGridViewTextBoxColumn.HeaderText = "TOTALCOMMANDE";
            this.tOTALCOMMANDEDataGridViewTextBoxColumn.Name = "tOTALCOMMANDEDataGridViewTextBoxColumn";
            this.tOTALCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWCOMMANDEBindingSource
            // 
            this.vWCOMMANDEBindingSource.DataMember = "VW_COMMANDE";
            this.vWCOMMANDEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboStatusCommande
            // 
            this.cboStatusCommande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStatusCommande.FormattingEnabled = true;
            this.cboStatusCommande.Items.AddRange(new object[] {
            "En attente",
            "Annulé",
            "Prête à être retirée",
            "En préparation",
            "Panier"});
            this.cboStatusCommande.Location = new System.Drawing.Point(334, 147);
            this.cboStatusCommande.Name = "cboStatusCommande";
            this.cboStatusCommande.Size = new System.Drawing.Size(121, 21);
            this.cboStatusCommande.TabIndex = 2;
            this.cboStatusCommande.SelectedValueChanged += new System.EventHandler(this.cboStatusCommande_SelectedValueChanged);
            // 
            // vWCOMMANDEBindingSource1
            // 
            this.vWCOMMANDEBindingSource1.DataMember = "VW_COMMANDE";
            this.vWCOMMANDEBindingSource1.DataSource = this.dataSet1;
            // 
            // vWCOMMANDEDETAILBindingSource
            // 
            this.vWCOMMANDEDETAILBindingSource.DataMember = "VW_COMMANDEDETAIL";
            this.vWCOMMANDEDETAILBindingSource.DataSource = this.dataSet1;
            // 
            // vW_COMMANDEDETAILTableAdapter
            // 
            this.vW_COMMANDEDETAILTableAdapter.ClearBeforeFill = true;
            // 
            // vW_COMMANDETableAdapter
            // 
            this.vW_COMMANDETableAdapter.ClearBeforeFill = true;
            // 
            // vWCOMMANDEDETAILBindingSource1
            // 
            this.vWCOMMANDEDETAILBindingSource1.DataMember = "VW_COMMANDEDETAIL";
            this.vWCOMMANDEDETAILBindingSource1.DataSource = this.dataSet1;
            // 
            // btnViderLesFiltres
            // 
            this.btnViderLesFiltres.Location = new System.Drawing.Point(937, 145);
            this.btnViderLesFiltres.Name = "btnViderLesFiltres";
            this.btnViderLesFiltres.Size = new System.Drawing.Size(113, 23);
            this.btnViderLesFiltres.TabIndex = 8;
            this.btnViderLesFiltres.Text = "Vider les filtres";
            this.btnViderLesFiltres.UseVisualStyleBackColor = true;
            this.btnViderLesFiltres.Click += new System.EventHandler(this.btnViderLesFiltres_Click);
            // 
            // frmAdminGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnViderLesFiltres);
            this.Controls.Add(this.cboStatusCommande);
            this.Controls.Add(this.lblGestionCommande);
            this.Controls.Add(this.dtgCommandes);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmAdminGestionCommandes";
            this.Text = "Gestion commande";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminGestionCommandes_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminGestionCommandes_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCOMMANDEDETAILBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnGestionClient;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblGestionCommande;
        private System.Windows.Forms.DataGridView dtgCommandes;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnPortailAdmin;
        private System.Windows.Forms.ComboBox cboStatusCommande;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vWCOMMANDEDETAILBindingSource;
        private DataSet1TableAdapters.VW_COMMANDEDETAILTableAdapter vW_COMMANDEDETAILTableAdapter;
        private System.Windows.Forms.BindingSource vWCOMMANDEBindingSource;
        private DataSet1TableAdapters.VW_COMMANDETableAdapter vW_COMMANDETableAdapter;
        private System.Windows.Forms.BindingSource vWCOMMANDEDETAILBindingSource1;
        private System.Windows.Forms.BindingSource vWCOMMANDEBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROCOMMANDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECOMMANDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUTCOMMANDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALCOMMANDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUTCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnViderLesFiltres;
    }
}