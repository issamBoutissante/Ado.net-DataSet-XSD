
namespace DataSetXSD
{
    partial class Ajout_Compte
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
            this.EnregistrerEtQuitter = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumCompte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.TypeCompte = new System.Windows.Forms.ComboBox();
            this.banqueDataSet = new DataSetXSD.BanqueDataSet();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteTableAdapter = new DataSetXSD.BanqueDataSetTableAdapters.CompteTableAdapter();
            this.numCompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new DataSetXSD.BanqueDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EnregistrerEtQuitter
            // 
            this.EnregistrerEtQuitter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.EnregistrerEtQuitter.Location = new System.Drawing.Point(420, 149);
            this.EnregistrerEtQuitter.Name = "EnregistrerEtQuitter";
            this.EnregistrerEtQuitter.Size = new System.Drawing.Size(146, 29);
            this.EnregistrerEtQuitter.TabIndex = 27;
            this.EnregistrerEtQuitter.Text = "Enregistrer et Quitter";
            this.EnregistrerEtQuitter.UseVisualStyleBackColor = true;
            this.EnregistrerEtQuitter.Click += new System.EventHandler(this.EnregistrerEtQuitter_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Ajouter.Location = new System.Drawing.Point(420, 103);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(146, 29);
            this.Ajouter.TabIndex = 26;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(120, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Type Compte";
            // 
            // Solde
            // 
            this.Solde.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Solde.Location = new System.Drawing.Point(230, 146);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(172, 22);
            this.Solde.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(120, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Solde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(120, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Num de client";
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NumCompte.Location = new System.Drawing.Point(230, 71);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(172, 22);
            this.NumCompte.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(120, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Num de Compte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ajout Compte";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.AutoGenerateColumns = false;
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCompteDataGridViewTextBoxColumn,
            this.numClientDataGridViewTextBoxColumn,
            this.soldeDataGridViewTextBoxColumn,
            this.typeCDataGridViewTextBoxColumn});
            this.ComptedataGridView.DataSource = this.compteBindingSource;
            this.ComptedataGridView.Location = new System.Drawing.Point(123, 228);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(443, 157);
            this.ComptedataGridView.TabIndex = 33;
            // 
            // NumClient
            // 
            this.NumClient.DataSource = this.clientBindingSource;
            this.NumClient.DisplayMember = "Num_client";
            this.NumClient.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(230, 109);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(172, 24);
            this.NumClient.TabIndex = 34;
            // 
            // TypeCompte
            // 
            this.TypeCompte.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TypeCompte.FormattingEnabled = true;
            this.TypeCompte.Items.AddRange(new object[] {
            "education",
            "prof"});
            this.TypeCompte.Location = new System.Drawing.Point(230, 184);
            this.TypeCompte.Name = "TypeCompte";
            this.TypeCompte.Size = new System.Drawing.Size(172, 24);
            this.TypeCompte.TabIndex = 35;
            // 
            // banqueDataSet
            // 
            this.banqueDataSet.DataSetName = "BanqueDataSet";
            this.banqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataMember = "Compte";
            this.compteBindingSource.DataSource = this.banqueDataSet;
            // 
            // compteTableAdapter
            // 
            this.compteTableAdapter.ClearBeforeFill = true;
            // 
            // numCompteDataGridViewTextBoxColumn
            // 
            this.numCompteDataGridViewTextBoxColumn.DataPropertyName = "Num_Compte";
            this.numCompteDataGridViewTextBoxColumn.HeaderText = "Num_Compte";
            this.numCompteDataGridViewTextBoxColumn.Name = "numCompteDataGridViewTextBoxColumn";
            // 
            // numClientDataGridViewTextBoxColumn
            // 
            this.numClientDataGridViewTextBoxColumn.DataPropertyName = "Num_Client";
            this.numClientDataGridViewTextBoxColumn.HeaderText = "Num_Client";
            this.numClientDataGridViewTextBoxColumn.Name = "numClientDataGridViewTextBoxColumn";
            // 
            // soldeDataGridViewTextBoxColumn
            // 
            this.soldeDataGridViewTextBoxColumn.DataPropertyName = "Solde";
            this.soldeDataGridViewTextBoxColumn.HeaderText = "Solde";
            this.soldeDataGridViewTextBoxColumn.Name = "soldeDataGridViewTextBoxColumn";
            // 
            // typeCDataGridViewTextBoxColumn
            // 
            this.typeCDataGridViewTextBoxColumn.DataPropertyName = "TypeC";
            this.typeCDataGridViewTextBoxColumn.HeaderText = "TypeC";
            this.typeCDataGridViewTextBoxColumn.Name = "typeCDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.banqueDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Ajout_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.TypeCompte);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnregistrerEtQuitter);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Compte";
            this.Text = "Ajout_Compte";
            this.Load += new System.EventHandler(this.Ajout_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnregistrerEtQuitter;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.ComboBox TypeCompte;
        private BanqueDataSet banqueDataSet;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private BanqueDataSetTableAdapters.CompteTableAdapter compteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BanqueDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}