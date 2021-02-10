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
    public partial class Supprimer_Compte : Form
    {
        public Supprimer_Compte()
        {
            InitializeComponent();
        }

        private void Supprimer_Compte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banqueDataSet.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.banqueDataSet.Compte);

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.compteBindingSource.RemoveAt(this.compteBindingSource.Position);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
