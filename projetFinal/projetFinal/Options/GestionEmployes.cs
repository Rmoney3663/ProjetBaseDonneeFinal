using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;

namespace projetFinal.Options
{
    public partial class GestionEmployes : Form
    {
        public Panel panel1;
        public int LoginUser { get; set; }
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public GestionEmployes()
        {
            InitializeComponent();
        }

        private void GestionEmployes_Load(object sender, EventArgs e)
        {
            var employees = from employe in dataContext.Employes
                            select employe;
            employesBindingSource.DataSource = employees.ToList();
            employesDataGridView.DataSource = employesBindingSource;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {         
            GestionEmploye.AjouterEmploye formulaire = new GestionEmploye.AjouterEmploye();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Gestion des employés";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
