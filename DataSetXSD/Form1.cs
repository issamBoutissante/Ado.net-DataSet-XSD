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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Navigation_Compte());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajout_Compte());
        }

        private void suToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Supprimer_Compte());
        }
    }
}
