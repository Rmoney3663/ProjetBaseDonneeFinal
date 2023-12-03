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
    public partial class MiseAJourAbos : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public MiseAJourAbos()
        {
            InitializeComponent();
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {

        }

        private void MiseAJourAbos_Load(object sender, EventArgs e)
        {
            var abonnements = dataContext.Abonnements;
            abonnementsBindingSource.DataSource = abonnements;

            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;
            provincesBindingSource.DataSource = dataContext.Provinces;
        }

        private void dgAbonnements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgAbonnements.SelectedRows.Count == 1 && !dgAbonnements.SelectedRows[0].IsNewRow)
            {
                string idAbonnement = dgAbonnements.SelectedRows[0].Cells[0].Value.ToString();

                dependantsBindingSource.DataSource = from unDependant in dataContext.Dependants
                                                     where unDependant.IdAbonnement == idAbonnement
                                                     select unDependant;
            }
            else
            {
                dependantsBindingSource.DataSource = null;
            }*/
        }
    }
}
