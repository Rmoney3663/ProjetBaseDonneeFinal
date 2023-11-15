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
                            join province in dataContext.Provinces on employe.IdProvince equals province.Id
                            join typeEmploye in dataContext.TypesEmploye on employe.NoTypeEmploye equals typeEmploye.No
                            select new
                            {
                                employe.No,
                                employe.Nom,
                                employe.MotDePasse,
                                employe.Prenom,
                                employe.Sexe,
                                employe.Age,
                                employe.NoCivique,
                                employe.Rue,
                                employe.Ville,
                                employe.IdProvince,
                                employe.NoTypeEmploye,
                                ProvinceName = province.Nom, 
                                employe.CodePostal,
                                employe.Telephone,
                                employe.Cellulaire,
                                employe.Courriel,
                                employe.SalaireHoraire,
                                TypeEmployeDescription = typeEmploye.Description,
                                employe.Remarque
                            };

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
            GestionEmploye.ModifierEmploye formulaire = new GestionEmploye.ModifierEmploye();
            DataGridViewRow selectedRow = employesDataGridView.SelectedRows[0];
            int No = (int)selectedRow.Cells["No"].Value;
            

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Gestion des employés";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            formulaire.ID = No;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employesDataGridView.SelectedRows[0];
            int No = (int)selectedRow.Cells["No"].Value;
            int type = (int)selectedRow.Cells["type"].Value;

            if (No != LoginUser && type !=1)
            {
                var servicesForEmployee = dataContext.Services
                .Where(service => service.NoEmploye == No)
                .ToList(); 

                if (servicesForEmployee.Count > 0)
                {
                    MessageBox.Show("Ne peut pas supprimer, puisqu'il a des services", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GestionEmploye.SupprimerEmploye formulaire = new GestionEmploye.SupprimerEmploye();
                    SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

                    splitContainer.Parent.Text = "Gestion des employés";

                    formulaire.TopLevel = false;
                    formulaire.FormBorderStyle = FormBorderStyle.None;
                    formulaire.Dock = DockStyle.Fill;
                    formulaire.ID = No;
                    splitContainer.Panel2.Controls.Clear();
                    splitContainer.Panel2.Controls.Add(formulaire);

                    formulaire.Show();
                }

                
            }
            else
            {
                if (type == 1)
                {
                    MessageBox.Show("Ne peut pas supprimer l'admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ne peut pas supprimer soi-même", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
        }

       
    }
}
