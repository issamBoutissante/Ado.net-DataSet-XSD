
namespace DataSetXSD
{
    partial class Navigation_Compte
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumCompte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeCompte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Premier = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Precedent = new System.Windows.Forms.Button();
            this.Dernier = new System.Windows.Forms.Button();
            this.EnregistrerXML = new System.Windows.Forms.Button();
            this.ImporterXML = new System.Windows.Forms.Button();
            this.NombreComptes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.banqueDataSet = new DataSetXSD.BanqueDataSet();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteTableAdapter = new DataSetXSD.BanqueDataSetTableAdapters.CompteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation Comptes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImporterXML);
            this.groupBox1.Controls.Add(this.EnregistrerXML);
            this.groupBox1.Controls.Add(this.Dernier);
            this.groupBox1.Controls.Add(this.Precedent);
            this.groupBox1.Controls.Add(this.Suivant);
            this.groupBox1.Controls.Add(this.Premier);
            this.groupBox1.Controls.Add(this.TypeCompte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Solde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumClient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NumCompte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiche Compte";
            // 
            // NumCompte
            // 
            this.NumCompte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Num_Compte", true));
            this.NumCompte.Location = new System.Drawing.Point(177, 41);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(100, 22);
            this.NumCompte.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num de Compte";
            // 
            // NumClient
            // 
            this.NumClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Num_Client", true));
            this.NumClient.Location = new System.Drawing.Point(177, 88);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(100, 22);
            this.NumClient.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num de client";
            // 
            // Solde
            // 
            this.Solde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Solde", true));
            this.Solde.Location = new System.Drawing.Point(177, 137);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(100, 22);
            this.Solde.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Solde";
            // 
            // TypeCompte
            // 
            this.TypeCompte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "TypeC", true));
            this.TypeCompte.Location = new System.Drawing.Point(177, 181);
            this.TypeCompte.Name = "TypeCompte";
            this.TypeCompte.Size = new System.Drawing.Size(100, 22);
            this.TypeCompte.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type Compte";
            // 
            // Premier
            // 
            this.Premier.Location = new System.Drawing.Point(336, 39);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(75, 23);
            this.Premier.TabIndex = 12;
            this.Premier.Text = "Premier";
            this.Premier.UseVisualStyleBackColor = true;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(336, 85);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 13;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Precedent
            // 
            this.Precedent.Location = new System.Drawing.Point(336, 134);
            this.Precedent.Name = "Precedent";
            this.Precedent.Size = new System.Drawing.Size(75, 23);
            this.Precedent.TabIndex = 14;
            this.Precedent.Text = "Precedent";
            this.Precedent.UseVisualStyleBackColor = true;
            this.Precedent.Click += new System.EventHandler(this.Precedent_Click);
            // 
            // Dernier
            // 
            this.Dernier.Location = new System.Drawing.Point(336, 178);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(75, 23);
            this.Dernier.TabIndex = 15;
            this.Dernier.Text = "Dernier";
            this.Dernier.UseVisualStyleBackColor = true;
            this.Dernier.Click += new System.EventHandler(this.Dernier_Click);
            // 
            // EnregistrerXML
            // 
            this.EnregistrerXML.Location = new System.Drawing.Point(473, 39);
            this.EnregistrerXML.Name = "EnregistrerXML";
            this.EnregistrerXML.Size = new System.Drawing.Size(103, 70);
            this.EnregistrerXML.TabIndex = 16;
            this.EnregistrerXML.Text = "Enregistrer la table compte en xml";
            this.EnregistrerXML.UseVisualStyleBackColor = true;
            this.EnregistrerXML.Click += new System.EventHandler(this.EnregistrerXML_Click);
            // 
            // ImporterXML
            // 
            this.ImporterXML.Location = new System.Drawing.Point(473, 140);
            this.ImporterXML.Name = "ImporterXML";
            this.ImporterXML.Size = new System.Drawing.Size(103, 61);
            this.ImporterXML.TabIndex = 17;
            this.ImporterXML.Text = "importer la table compte en xml";
            this.ImporterXML.UseVisualStyleBackColor = true;
            this.ImporterXML.Click += new System.EventHandler(this.ImporterXML_Click);
            // 
            // NombreComptes
            // 
            this.NombreComptes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreComptes.Location = new System.Drawing.Point(556, 86);
            this.NombreComptes.Name = "NombreComptes";
            this.NombreComptes.Size = new System.Drawing.Size(100, 22);
            this.NombreComptes.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre des comptes";
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
            // Navigation_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.NombreComptes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Navigation_Compte";
            this.Text = "Navigation_Compte";
            this.Load += new System.EventHandler(this.Navigation_Compte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImporterXML;
        private System.Windows.Forms.Button EnregistrerXML;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button Precedent;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.TextBox TypeCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreComptes;
        private System.Windows.Forms.Label label6;
        private BanqueDataSet banqueDataSet;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private BanqueDataSetTableAdapters.CompteTableAdapter compteTableAdapter;
    }
}