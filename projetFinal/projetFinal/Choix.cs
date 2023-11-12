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
    public partial class Choix : Form
    {
        public Choix()
        {
            InitializeComponent();
        }

        private void btnGestionEmp_Click(object sender, EventArgs e)
        {
            Options.GestionEmployes gestionEmployes = new Options.GestionEmployes();

            Form topLevelForm = (Form)this.FindForm().Parent.Parent.Parent;

            topLevelForm.Dispose();

            gestionEmployes.ShowDialog();
        }
    }
}
