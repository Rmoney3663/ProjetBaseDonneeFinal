using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class Reabonnement : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public Reabonnement()
        {
            InitializeComponent();
        }

        private void Reabonnement_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource = from unAbonnement in dataContext.Abonnements
                                                  where unAbonnement.Reabonnements
                                                  .Where(r => r.DateRenouvellement.AddYears(1) > DateTime.Today).Count() == 0 &&
                                                  unAbonnement.DateAbonnement.AddYears(1) <= DateTime.Today
                                                  select new
                                                  {
                                                      unAbonnement.Id,
                                                      NomComplet = unAbonnement.Prenom + ' ' + unAbonnement.Nom
                                                  };
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            string id = (string)dgAbonnements.SelectedRows[0].Cells[0].Value;

            Reabonnements reabonnement = new Reabonnements
            {
                IdAbonnement = id,
                DateRenouvellement = DateTime.Today,
                Remarque = tbRemarque.Text
            };

            dataContext.Reabonnements.InsertOnSubmit(reabonnement);

            using (var porteeTransaction = new TransactionScope())
            {
                // enregistre l'abonnement et les dépendants dans la base de données
                try
                {
                    dataContext.SubmitChanges();
                    
                    MessageBox.Show("L'abonnement " + id + " a été renouvelé avec succès.", "enregistrement du réabonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    InitializeComponent();
                    Reabonnement_Load(null, null);

                    porteeTransaction.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
