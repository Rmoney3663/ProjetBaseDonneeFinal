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
    public partial class SupprimerEmploye : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public int ID { get; set; }
        public SupprimerEmploye()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {    
            try
            {
                var employeeToDelete = dataContext.Employes.SingleOrDefault(employ => employ.No == ID);

                if (employeeToDelete != null)
                {
                    var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet employé ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        dataContext.Employes.DeleteOnSubmit(employeeToDelete);
                        dataContext.SubmitChanges();
                        MessageBox.Show("Employee supprimer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("Suppression annulée.", "Annuler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pour supprimer employé: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SupprimerEmploye_Load(object sender, EventArgs e)
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

            var employeeToDelete = dataContext.Employes.SingleOrDefault(employ => employ.No == ID);

            if (employeeToDelete != null)
            {
                tbPassword.Text = employeeToDelete.MotDePasse;
                nomTextBox.Text = employeeToDelete.Nom;
                prenomTextBox.Text = employeeToDelete.Prenom;
                sexeComboBox.SelectedItem = employeeToDelete.Sexe;
                numAge.Value = employeeToDelete.Age;
                noCiviqueTextBox.Text = employeeToDelete.NoCivique.ToString();
                rueTextBox.Text = employeeToDelete.Rue;
                villeTextBox.Text = employeeToDelete.Ville;
                idProvinceComboBox.SelectedValue = employeeToDelete.IdProvince;
                codePostalTextBox.Text = employeeToDelete.CodePostal;
                telephoneTextBox.Text = employeeToDelete.Telephone.ToString();
                cellulaireTextBox.Text = employeeToDelete.Cellulaire.ToString();
                courrielTextBox.Text = employeeToDelete.Courriel;
                numSalaire.Value = employeeToDelete.SalaireHoraire;
                remarqueTextBox.Text = employeeToDelete.Remarque;

            };
        }
    }
}
