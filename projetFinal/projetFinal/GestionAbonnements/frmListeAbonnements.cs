using projetFinal.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.GestionAbonnements
{
    public partial class frmListeAbonnements : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public frmListeAbonnements()
        {
            InitializeComponent();
        }

        private void frmListeAbonnements_Load(object sender, EventArgs e)
        {
            var abonnements = dataContext.Abonnements;
            abonnementsBindingSource.DataSource = abonnements;

            // Remplir les valeurs de province et type d'abonnement dans le tableau
            foreach (DataGridViewRow rangee in dgAbonnements.Rows)
            {
                Abonnements abonnement = (from abonne in dataContext.Abonnements
                                    where abonne.Id == rangee.Cells[0].Value.ToString()
                                    select abonne).ToArray()[0];

                string nomProvince = (from province in dataContext.Provinces
                               where province.Id == abonnement.IdProvince
                               select province.Nom).ToArray()[0];
                string typeAbonnement = (from typeAbo in dataContext.TypesAbonnement
                                  where typeAbo.No == abonnement.NoTypeAbonnement
                                  select typeAbo.Description).ToArray()[0];

                rangee.Cells[9].Value = nomProvince;
                rangee.Cells[14].Value = typeAbonnement;
            }
        }

        private void dgAbonnements_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAbonnements.SelectedRows.Count == 1)
            {
                string idAbonnement = dgAbonnements.SelectedRows[0].Cells[0].Value.ToString();

                dependantsBindingSource.DataSource = from unDependant in dataContext.Dependants
                                                     where unDependant.IdAbonnement == idAbonnement
                                                     select unDependant;
            }
            else
            {
                dependantsBindingSource.DataSource = null;
            }
        }
    }
}
