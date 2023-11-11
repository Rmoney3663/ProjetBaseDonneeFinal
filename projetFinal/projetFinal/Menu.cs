using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGestionEmp_Click(object sender, EventArgs e)
        {
            Options.GestionEmployes gestionEmployes = new Options.GestionEmployes();
            splitContainer1.Panel2.Controls.Clear();

            Panel panneau = new Panel();
            panneau.Dock = DockStyle.Fill;
            gestionEmployes.TopLevel = false;
            panneau.Controls.Add(gestionEmployes);

            splitContainer1.Panel2.Controls.Add(panneau);

            gestionEmployes.Show();
        }
    }
}
