using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.GestionEmploye
{
    public partial class AjouterEmploye : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public AjouterEmploye()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Options.GestionEmployes formulaire = new Options.GestionEmployes();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Gestion des employés";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void AjouterEmploye_Load(object sender, EventArgs e)
        {
            List<string> sexOptions = new List<string> { "H", "F" };
            sexeComboBox.DataSource = sexOptions;
            sexeComboBox.SelectedIndex = -1;

            var provinces = from p in dataContext.Provinces
                            select p;

            idProvinceComboBox.DisplayMember = "Nom"; 
            idProvinceComboBox.ValueMember = "Id";   
            idProvinceComboBox.DataSource = provinces.ToList();

            var typesEmploye = from t in dataContext.TypesEmploye
                               where t.No != 1
                               select t;
            noTypeEmployeComboBox.DisplayMember = "Description"; 
            noTypeEmployeComboBox.ValueMember = "No";          
            noTypeEmployeComboBox.DataSource = typesEmploye.ToList();


        }
    }
}
