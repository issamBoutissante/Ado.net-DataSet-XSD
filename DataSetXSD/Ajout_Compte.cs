using System;
using System.Data;
using System.Windows.Forms;

namespace DataSetXSD
{
    public partial class Ajout_Compte : Form
    {
        public Ajout_Compte()
        {
            InitializeComponent();
        }

        private void Ajout_Compte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banqueDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.banqueDataSet.Client);
            // TODO: This line of code loads data into the 'banqueDataSet.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.banqueDataSet.Compte);
            NumClient.Text = "-Fites votre choix-";
            TypeCompte.Text = "-Fites votre choix-";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row=this.banqueDataSet.Compte.NewRow();
                row.BeginEdit();
                row[0] = NumCompte.Text;
                row[1] = NumClient.Text;
                row[2] = Solde.Text;
                row[3] = TypeCompte.Text;
                row.EndEdit();
                this.banqueDataSet.Compte.Rows.Add(row);
                MessageBox.Show("L'ajout a ete effectue");
                Effacer();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Effacer()
        {
            NumCompte.Clear();
            Solde.Clear();
            NumClient.Text = "-Fites votre choix-";
            TypeCompte.Text = "-Fites votre choix-";
        }

        private void EnregistrerEtQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                this.compteTableAdapter.Update(this.banqueDataSet.Compte);
                MessageBox.Show("La mise a jout a ete effectue","Termine",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
