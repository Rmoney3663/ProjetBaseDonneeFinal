using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                            new { Id = 1, DisplayName = "Magasin Pro Shop pour un employé Pro Shop" },
                            new { Id = 2, DisplayName = "Restaurant pour un employé Restaurant" },
                            new { Id = 3, DisplayName = "Leçon de golf pour un employé professeur de golf" }
                        };
                        break;
                    case 4:
                        break;
                    case 5:
                        comboBoxItems = new[]
                        {
                            new { Id = 1, DisplayName = "Magasin Pro Shop pour un employé Pro Shop" }
                        };
                        break;
                    case 6:
                        comboBoxItems = new[]
                        {
                            new { Id = 2, DisplayName = "Restaurant pour un employé Restaurant" }
                        };
                        break;
                    case 7:
                        comboBoxItems = new[]
                        {
                            new { Id = 3, DisplayName = "Leçon de golf pour un employé professeur de golf" }
                        };
                        break;
                    default:
                        MessageBox.Show("Le type d'employe n'est pas existant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                typeServiceComboBox.DataSource = comboBoxItems.ToList();
                typeServiceComboBox.DisplayMember = "DisplayName";
                typeServiceComboBox.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
