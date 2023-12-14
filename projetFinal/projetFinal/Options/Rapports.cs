using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class Rapports : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public Rapports()
        {
            InitializeComponent();
        }

        private void Rapports_Load(object sender, EventArgs e)
        {
            var query1 = from employe in dataContext.Employes
                         select new
                         {
                             DisplayName = employe.Prenom + " " + employe.Nom,
                             No = employe.No
                         };

            employeeComboBox.DataSource = query1.ToList();
            employeeComboBox.DisplayMember = "DisplayName";
            employeeComboBox.ValueMember = "No";


            var query2 = from abonnements in dataContext.Abonnements
                         select new
                         {
                             DisplayName = abonnements.Prenom + " " + abonnements.Nom,
                             No = abonnements.Id
                         };
            abonnementcomboBox.DataSource = query2.ToList();
            abonnementcomboBox.DisplayMember = "DisplayName";
            abonnementcomboBox.ValueMember = "No";


            AnnecomboBox.DisplayMember = "Year";
            AnnecomboBox.ValueMember = "Year";
            int currentYear = DateTime.Now.Year;
            List<int> years = new List<int>();
            for (int year = 2022; year <= currentYear; year++)
            {
                years.Add(year);
            }
            AnnecomboBox.DataSource = years.Select(year => new { Year = year }).ToList();


            var query3 = from terrains in dataContext.Terrains
                         select new
                         {
                             DisplayName = terrains.Nom,
                             No = terrains.No
                         };

            TerraincomboBox.DataSource = query3.ToList();
            TerraincomboBox.DisplayMember = "DisplayName";
            TerraincomboBox.ValueMember = "No";


            comboBox2.DataSource = query2.ToList();
            comboBox2.DisplayMember = "DisplayName";
            comboBox2.ValueMember = "No";

            comboBox1.DisplayMember = "Year"; 
            comboBox1.ValueMember = "Year";
            var distinctYearsQuery = (from partie in dataContext.PartiesJouees
                                      select partie.DatePartie.Year).Distinct();
            comboBox1.DataSource = distinctYearsQuery.Select(year => new { Year = year }).ToList();
            
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedValue != null)
            {
                dynamic selectedEmployee = employeeComboBox.SelectedItem;
                int selectedEmployeeId = selectedEmployee.No;

                var query = from service in dataContext.Services
                            join depense in dataContext.Depenses on service.No equals depense.NoService
                            join abonnement in dataContext.Abonnements on depense.IdAbonnement equals abonnement.Id
                            where service.NoEmploye == selectedEmployeeId
                            select new
                            {
                                TypeService = service.TypeService,
                                Montant = depense.Montant,
                                DateDepense = depense.DateDepense,
                                Abonnement = abonnement.Prenom + " " + abonnement.Nom
                            };

                depensesDataGridView.DataSource = query.ToList();
            }
        }

        private void abonnementcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (abonnementcomboBox.SelectedValue != null)
            {
                dynamic selectedAbonnement = abonnementcomboBox.SelectedItem;
                string selectedAbonnementId = selectedAbonnement.No;

                var query = from depense in dataContext.Depenses
                            join service in dataContext.Services on depense.NoService equals service.No
                            join abonnement in dataContext.Abonnements on depense.IdAbonnement equals abonnement.Id
                            join employe in dataContext.Employes on service.NoEmploye equals employe.No
                            where abonnement.Id == selectedAbonnementId
                            select new
                            {
                                Montant = depense.Montant,
                                DateDepense = depense.DateDepense,
                                TypeService = service.TypeService,
                                EmployeName = employe.Prenom + " " + employe.Nom
                            };

                abondataGridView.DataSource = query.ToList();
            }
        }

        private void AnnecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnnecomboBox.SelectedValue != null)
            {
                int selectedYearID = (int)AnnecomboBox.SelectedValue;

                var query = from depense in dataContext.Depenses
                            join service in dataContext.Services on depense.NoService equals service.No
                            join abonnement in dataContext.Abonnements on depense.IdAbonnement equals abonnement.Id
                            join employe in dataContext.Employes on service.NoEmploye equals employe.No
                            where depense.DateDepense.Year == selectedYearID
                            select new
                            {
                                Montant = depense.Montant,
                                DateDepense = depense.DateDepense,
                                TypeService = service.TypeService,
                                AbonnementNom = abonnement.Prenom + " " + abonnement.Nom,
                                EmployeName = employe.Prenom + " " + employe.Nom
                            };

                dataGridView2.DataSource = query.ToList();
            }
        }

        private void TerraincomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TerraincomboBox.SelectedValue != null)
            {
                dynamic selectedTerrain = TerraincomboBox.SelectedItem;
                int selectedTerrainId = selectedTerrain.No;

                var query = from terrains in dataContext.Terrains
                            join parties in dataContext.PartiesJouees on terrains.No equals parties.NoTerrain
                            join abonnement in dataContext.Abonnements on parties.IdAbonnement equals abonnement.Id
                            where terrains.No == selectedTerrainId
                            select new
                            {
                                DatePartie = parties.DatePartie,
                                Pointage = parties.Pointage,
                                Abonnements = abonnement.Prenom + " " + abonnement.Nom
                            };

                partiesJoueesDataGridView.DataSource = query.ToList();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                dynamic selectedAbonne = comboBox2.SelectedItem;
                string selectedAbonneId = selectedAbonne.No;

                var query = from terrains in dataContext.Terrains
                            join parties in dataContext.PartiesJouees on terrains.No equals parties.NoTerrain
                            join abonnement in dataContext.Abonnements on parties.IdAbonnement equals abonnement.Id
                            where abonnement.Id == selectedAbonneId
                            select new
                            {
                                DatePartie = parties.DatePartie,
                                Pointage = parties.Pointage,
                                Terrains = terrains.Nom
                            };

                partiesDataGridView.DataSource = query.ToList();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                dynamic selectedAnne = comboBox1.SelectedItem;
                int selectedAnnee = selectedAnne.Year;

                var query = from terrains in dataContext.Terrains
                            join parties in dataContext.PartiesJouees on terrains.No equals parties.NoTerrain
                            join abonnement in dataContext.Abonnements on parties.IdAbonnement equals abonnement.Id
                            where parties.DatePartie.Year == selectedAnnee
                            select new
                            {
                                DatePartie = parties.DatePartie,
                                Pointage = parties.Pointage,
                                Terrains = terrains.Nom,
                                Abonnement = abonnement.Prenom + " " + abonnement.Nom
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
