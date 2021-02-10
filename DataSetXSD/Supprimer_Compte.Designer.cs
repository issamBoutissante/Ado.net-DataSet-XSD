
namespace DataSetXSD
{
    partial class Supprimer_Compte
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
            this.NumCompte = new System.Windows.Forms.ComboBox();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EnregistrerEtQuitter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.banqueDataSet = new DataSetXSD.BanqueDataSet();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteTableAdapter = new DataSetXSD.BanqueDataSetTableAdapters.CompteTableAdapter();
            this.numCompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCompte
            // 
            this.NumCompte.DataSource = this.compteBindingSource1;
            this.NumCompte.DisplayMember = "Num_Compte";
            this.NumCompte.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NumCompte.FormattingEnabled = true;
            this.NumCompte.Location = new System.Drawing.Point(249, 126);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(172, 24);
            this.NumCompte.TabIndex = 46;
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
            this.ComptedataGridView.Location = new System.Drawing.Point(140, 230);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(443, 157);
            this.ComptedataGridView.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Supprimer Compte";
            // 
            // EnregistrerEtQuitter
            // 
            this.EnregistrerEtQuitter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.EnregistrerEtQuitter.Location = new System.Drawing.Point(437, 151);
            this.EnregistrerEtQuitter.Name = "EnregistrerEtQuitter";
            this.EnregistrerEtQuitter.Size = new System.Drawing.Size(146, 28);
            this.EnregistrerEtQuitter.TabIndex = 43;
            this.EnregistrerEtQuitter.Text = "Enregistrer et Quitter";
            this.EnregistrerEtQuitter.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Supprimer.Location = new System.Drawing.Point(437, 105);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(146, 28);
            this.Supprimer.TabIndex = 42;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(139, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Num de Compte";
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
            // compteBindingSource1
            // 
            this.compteBindingSource1.DataMember = "Compte";
            this.compteBindingSource1.DataSource = this.banqueDataSet;
            // 
            // Supprimer_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnregistrerEtQuitter);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supprimer_Compte";
            this.Text = "Supprimer_Compte";
            this.Load += new System.EventHandler(this.Supprimer_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox NumCompte;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnregistrerEtQuitter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label2;
        private BanqueDataSet banqueDataSet;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private BanqueDataSetTableAdapters.CompteTableAdapter compteTableAdapter;
        private System.Windows.Forms.BindingSource compteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCDataGridViewTextBoxColumn;
    }
}