using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetXSD
{
    public partial class Navigation_Compte : Form
    {
        public Navigation_Compte()
        {
            InitializeComponent();
        }

        private void Navigation_Compte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banqueDataSet.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.banqueDataSet.Compte);
            NombreComptes.Text = this.banqueDataSet.Compte.Count.ToString();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position = 0;
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position++;
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position = this.compteBindingSource.Count - 1;
        }

        private void Precedent_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position--;
        }


        private void EnregistrerXML_Click(object sender, EventArgs e)
        {
            try
            {
                this.banqueDataSet.Compte.WriteXml("compte.xml");
                MessageBox.Show("Enregistrement en Xml a ete effectue");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ImporterXML_Click(object sender, EventArgs e)
        {
            try
            {
                this.banqueDataSet.Compte.Clear();
                this.banqueDataSet.Compte.ReadXml("compte.xml");
                NombreComptes.Text= this.banqueDataSet.Compte.Count.ToString();
                MessageBox.Show("Importation en Xml a ete effectue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
