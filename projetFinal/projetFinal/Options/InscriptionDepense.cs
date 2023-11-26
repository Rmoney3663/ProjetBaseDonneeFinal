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
                /*
                var serviceList = new[]
                {
                    new { Id = 1, DisplayName = "Magasin Pro Shop pour un employé Pro Shop" },
                    new { Id = 2, DisplayName = "Restaurant pour un employé Restaurant" },
                    new { Id = 3, DisplayName = "Leçon de golf pour un employé professeur de golf" }
                };*/

                var query2 = from services in dataContext.Services
                             where services.NoEmploye == LoginUser
                             select new
                             {
                                 Id = services.No,
                                 DisplayName = services.TypeService
                             };

                typeServiceComboBox.DataSource = query2.ToList();
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
