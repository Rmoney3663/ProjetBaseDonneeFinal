using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class InscriptionDepense : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public int LoginUser { get; set; }
        public InscriptionDepense()
        {
            InitializeComponent();
        }

        private void InscriptionDepense_Load(object sender, EventArgs e)
        {
            try
            {
                var query = from abonnement in dataContext.Abonnements
                            select new 
                            {
                                Id = abonnement.Id,
                                DisplayName = $"({abonnement.Id}) {abonnement.Prenom} {abonnement.Nom}"
                            };

                idComboBox.DataSource = query.ToList();
                idComboBox.DisplayMember = "DisplayName";
                idComboBox.ValueMember = "Id";

                var noTypeEmploye = dataContext.Employes
                     .Where(employ => employ.No == LoginUser)
                     .Select(employ => employ.NoTypeEmploye)
                     .FirstOrDefault();

                IEnumerable<object> comboBoxItems = Enumerable.Empty<object>();

                switch (noTypeEmploye)
                {
                    case 1:
                    case 2:
                    case 3:
                        comboBoxItems = new[]
                        {
                            new { Id = 1, DisplayName = "Magasin Pro Shop" },
                            new { Id = 2, DisplayName = "Restaurant" },
                            new { Id = 3, DisplayName = "Leçon de golf" }
                        };
                        break;
                    case 4:
                        break;
                    case 5:
                        comboBoxItems = new[]
                        {
                            new { Id = 1, DisplayName = "Magasin Pro Shop" }
                        };
                        break;
                    case 6:
                        comboBoxItems = new[]
                        {
                            new { Id = 2, DisplayName = "Restaurant" }
                        };
                        break;
                    case 7:
                        comboBoxItems = new[]
                        {
                            new { Id = 3, DisplayName = "Leçon de golf" }
                        };
                        break;
                    default:
                        MessageBox.Show("Le type d'employe n'est pas existant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                typeServiceComboBox.DataSource = comboBoxItems.ToList();
                typeServiceComboBox.DisplayMember = "DisplayName";
                typeServiceComboBox.ValueMember = "Id";

                var query2 = from depense in dataContext.Depenses
                             join service in dataContext.Services on depense.NoService equals service.No
                             join abonnement in dataContext.Abonnements on depense.IdAbonnement equals abonnement.Id
                             join employe in dataContext.Employes on service.NoEmploye equals employe.No
                             select new
                             {
                                 depense.DateDepense,
                                 depense.Montant,
                                 depense.Remarque,
                                 Services = service.TypeService,
                                 Abonnements = abonnement.Prenom + ' ' + abonnement.Nom,
                                 NomEmployer = employe.Prenom + ' ' + employe.Nom,
                             };

                depensesBindingSource.DataSource = query2.ToList();
                depensesDataGridView.DataSource = depensesBindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var selectedItem = (dynamic)typeServiceComboBox.SelectedItem;
                    var idtype = (int)typeServiceComboBox.SelectedValue;
                    var type = "";

                    if (selectedItem != null)
                    {
                        type = selectedItem.DisplayName;
                        //MessageBox.Show(type.ToString(), "Display Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    var selectedValue = idComboBox.SelectedValue;
                    var id = "";
                    if (selectedValue != null)
                    {
                        id = selectedValue.ToString(); 
                        //MessageBox.Show(id, "Value Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    var serviceExists = dataContext.Services.Any(services => services.NoEmploye == LoginUser && services.TypeService == type);

                    if (!serviceExists)
                    {
                        int largestNumber = dataContext.Services.Any() ? dataContext.Services.Max(services => (int?)services.No).GetValueOrDefault() + 1 : 1;
                        Services newServices = new Services
                        {
                            No = largestNumber,
                            TypeService = type,
                            NoEmploye = LoginUser
                        };
                        dataContext.Services.InsertOnSubmit(newServices);
                        dataContext.SubmitChanges();
                    }

                    int largestNumber2 = dataContext.Services.Any() ? dataContext.Depenses.Max(depenses => (int?)depenses.No).GetValueOrDefault() + 1 : 1;
                    Depenses newDepenses = new Depenses
                    {
                        No = largestNumber2,
                        IdAbonnement = id,
                        DateDepense = DateTime.Now,
                        Montant = numericUpDown1.Value,
                        NoService = idtype,
                        Remarque = remarqueTextBox.Text
                    };
                    dataContext.Depenses.InsertOnSubmit(newDepenses);
                    dataContext.SubmitChanges();

                  

                    var query2 = from depense in dataContext.Depenses
                                 join service in dataContext.Services on depense.NoService equals service.No
                                 join abonnement in dataContext.Abonnements on depense.IdAbonnement equals abonnement.Id
                                 join employe in dataContext.Employes on service.NoEmploye equals employe.No
                                 select new
                                 {
                                     depense.DateDepense,
                                     depense.Montant,
                                     depense.Remarque,
                                     Services = service.TypeService,
                                     Abonnements = abonnement.Prenom + ' ' + abonnement.Nom,
                                     NomEmployer = employe.Prenom + ' ' + employe.Nom,
                                 };

                    depensesBindingSource.DataSource = query2.ToList();
                    depensesDataGridView.DataSource = depensesBindingSource;
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
