namespace EasyStore
{
    partial class frmAdminGestionClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGestionClient));
            this.btnGestionCommande = new System.Windows.Forms.Button();
            this.pnlStyle = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnGestionProduit = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.picEntreprise = new System.Windows.Forms.PictureBox();
            this.dtgClient = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEPOSTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWCLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EasyStore.DataSet1();
            this.vWCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGestionClient = new System.Windows.Forms.Label();
            this.lblFiltreClient = new System.Windows.Forms.Label();
            this.txtFiltreClient = new System.Windows.Forms.TextBox();
            this.vW_CLIENTTableAdapter = new EasyStore.DataSet1TableAdapters.VW_CLIENTTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNavigation.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCLIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.pnlNavigation.Controls.Add(this.btnGestionProduit);
            this.pnlNavigation.Controls.Add(this.pnlStyle);
            this.pnlNavigation.Controls.Add(this.btnShop);
            this.pnlNavigation.Controls.Add(this.btnGestionCommande);
            this.pnlNavigation.Controls.Add(this.btnDeconnexion);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(161, 761);
            this.pnlNavigation.TabIndex = 2;
            // 
            // btnGestionProduit
            // 
            this.btnGestionProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionProduit.FlatAppearance.BorderSize = 0;
            this.btnGestionProduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionProduit.ForeColor = System.Drawing.Color.Black;
            this.btnGestionProduit.Location = new System.Drawing.Point(-6, 146);
            this.btnGestionProduit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionProduit.Name = "btnGestionProduit";
            this.btnGestionProduit.Size = new System.Drawing.Size(169, 40);
            this.btnGestionProduit.TabIndex = 1;
            this.btnGestionProduit.Text = "&Gestion produit";
            this.btnGestionProduit.UseVisualStyleBackColor = false;
            this.btnGestionProduit.Click += new System.EventHandler(this.btnGestionProduit_Click);
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
            // dtgClient
            // 
            this.dtgClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgClient.AutoGenerateColumns = false;
            this.dtgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.aDRESSEDataGridViewTextBoxColumn,
            this.cODEPOSTALDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn});
            this.dtgClient.DataSource = this.vWCLIENTBindingSource1;
            this.dtgClient.Location = new System.Drawing.Point(334, 172);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.ReadOnly = true;
            this.dtgClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClient.Size = new System.Drawing.Size(716, 416);
            this.dtgClient.TabIndex = 3;
            this.dtgClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClient_CellClick);
            this.dtgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClient_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            this.pRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESSEDataGridViewTextBoxColumn
            // 
            this.aDRESSEDataGridViewTextBoxColumn.DataPropertyName = "ADRESSE";
            this.aDRESSEDataGridViewTextBoxColumn.HeaderText = "ADRESSE";
            this.aDRESSEDataGridViewTextBoxColumn.Name = "aDRESSEDataGridViewTextBoxColumn";
            this.aDRESSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODEPOSTALDataGridViewTextBoxColumn
            // 
            this.cODEPOSTALDataGridViewTextBoxColumn.DataPropertyName = "CODEPOSTAL";
            this.cODEPOSTALDataGridViewTextBoxColumn.HeaderText = "CODEPOSTAL";
            this.cODEPOSTALDataGridViewTextBoxColumn.Name = "cODEPOSTALDataGridViewTextBoxColumn";
            this.cODEPOSTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWCLIENTBindingSource1
            // 
            this.vWCLIENTBindingSource1.DataMember = "VW_CLIENT";
            this.vWCLIENTBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWCLIENTBindingSource
            // 
            this.vWCLIENTBindingSource.DataMember = "VW_CLIENT";
            this.vWCLIENTBindingSource.DataSource = this.dataSet1;
            // 
            // lblGestionClient
            // 
            this.lblGestionClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestionClient.AutoSize = true;
            this.lblGestionClient.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient.Location = new System.Drawing.Point(542, 82);
            this.lblGestionClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionClient.Name = "lblGestionClient";
            this.lblGestionClient.Size = new System.Drawing.Size(300, 60);
            this.lblGestionClient.TabIndex = 6;
            this.lblGestionClient.Text = "Gestion client";
            // 
            // lblFiltreClient
            // 
            this.lblFiltreClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltreClient.AutoSize = true;
            this.lblFiltreClient.Location = new System.Drawing.Point(331, 150);
            this.lblFiltreClient.Name = "lblFiltreClient";
            this.lblFiltreClient.Size = new System.Drawing.Size(76, 13);
            this.lblFiltreClient.TabIndex = 0;
            this.lblFiltreClient.Text = "&Nom/Prenom :";
            // 
            // txtFiltreClient
            // 
            this.txtFiltreClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltreClient.Location = new System.Drawing.Point(413, 147);
            this.txtFiltreClient.Name = "txtFiltreClient";
            this.txtFiltreClient.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreClient.TabIndex = 1;
            this.txtFiltreClient.TextChanged += new System.EventHandler(this.txtFiltreClient_TextChanged);
            // 
            // vW_CLIENTTableAdapter
            // 
            this.vW_CLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // frmAdminGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.txtFiltreClient);
            this.Controls.Add(this.lblFiltreClient);
            this.Controls.Add(this.lblGestionClient);
            this.Controls.Add(this.dtgClient);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmAdminGestionClient";
            this.Text = "Gestion client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminGestionClient_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminGestionClient_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCLIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionCommande;
        private System.Windows.Forms.Panel pnlStyle;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.PictureBox picEntreprise;
        private System.Windows.Forms.DataGridView dtgClient;
        private System.Windows.Forms.Label lblGestionClient;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnGestionProduit;
        private System.Windows.Forms.Label lblFiltreClient;
        private System.Windows.Forms.TextBox txtFiltreClient;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vWCLIENTBindingSource;
        private DataSet1TableAdapters.VW_CLIENTTableAdapter vW_CLIENTTableAdapter;
        private System.Windows.Forms.BindingSource vWCLIENTBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEPOSTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
    }
}