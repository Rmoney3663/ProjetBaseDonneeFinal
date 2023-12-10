using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
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
            bool booValide = true;

            foreach (DataGridViewRow row in dgAbonnements.Rows)
            {
                bool booErreurRow = false;

                // Prénom
                if (row.Cells[3].Value == null || row.Cells[3].Value.ToString().Trim() == "")
                {
                    row.Cells[3].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    row.Cells[3].ErrorText = "";
                }

                // Numéro civique
                if (row.Cells[6].Value == null || row.Cells[6].Value.ToString().Trim() == "")
                {
                    row.Cells[6].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    if (int.TryParse(row.Cells[6].Value.ToString(),out int res) == false)
                    {
                        row.Cells[6].ErrorText = "Cette valeur doit être un entier";
                        booErreurRow = true;
                    }
                    else
                    {
                        row.Cells[6].ErrorText = "";
                    }
                }

                // Rue
                if (row.Cells[7].Value == null || row.Cells[7].Value.ToString().Trim() == "")
                {
                    row.Cells[7].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    row.Cells[7].ErrorText = "";
                }

                // Ville
                if (row.Cells[8].Value == null || row.Cells[8].Value.ToString().Trim() == "")
                {
                    row.Cells[8].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    row.Cells[8].ErrorText = "";
                }

                // Code postal
                if (row.Cells[10].Value == null || row.Cells[10].Value.ToString().Trim() == "")
                {
                    row.Cells[10].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    Regex rgx = new Regex(@"^[A-Z]\d[A-Z]\d[A-Z]\d$");
                    if (!rgx.IsMatch(row.Cells[10].Value.ToString().ToUpper()))
                    {
                        row.Cells[10].ErrorText = "La valeur ne correspond pas au format accepté (aucun tiret ni espace)";
                        booErreurRow = true;
                    }
                    else
                    {
                        row.Cells[10].ErrorText = "";
                        row.Cells[10].Value = row.Cells[10].Value.ToString().ToUpper();
                    }
                }

                // Téléphone
                if (row.Cells[11].Value == null || row.Cells[11].Value.ToString().Trim() == "")
                {
                    row.Cells[11].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    Regex rgx = new Regex(@"^\d{10}$");
                    if (!rgx.IsMatch(row.Cells[11].Value.ToString()))
                    {
                        row.Cells[11].ErrorText = "La valeur ne correspond pas au format accepté";
                        booErreurRow = true;
                    }
                    else
                    {
                        row.Cells[11].ErrorText = "";
                    }
                }

                // Cellulaire
                Regex format = new Regex(@"^\d{10}$");
                if (row.Cells[12].Value != null && !format.IsMatch(row.Cells[12].Value.ToString()))
                {
                    row.Cells[12].ErrorText = "La valeur ne correspond pas au format accepté";
                    booErreurRow = true;
                }
                else
                {
                    row.Cells[12].ErrorText = "";
                }

                // Courriel
                if (row.Cells[13].Value == null || row.Cells[13].Value.ToString().Trim() == "")
                {
                    row.Cells[13].ErrorText = "Veuillez remplir cette zone";
                    booErreurRow = true;
                }
                else
                {
                    row.Cells[13].ErrorText = "";
                }

                verifDependants();
                foreach (DataGridViewRow row2 in dgDependants.Rows)
                {
                    if (row2.ErrorText != "")
                    {
                        booErreurRow = true;
                    }
                }

                // Erreur dans la rangée
                if (booErreurRow == true)
                {
                    row.ErrorText = "Il y a une erreur dans au moins une des cellules de cet abonnement ou de ses dépendants";
                    booValide = false;
                }
                else
                {
                    row.ErrorText = "";
                }
            }

            if (booValide == true)
            {
                using (var porteeTransaction = new TransactionScope())
                {
                    // enregistre les modifications dans la base de données
                    try
                    {
                        dataContext.SubmitChanges();

                        MessageBox.Show("Les modifications ont été enregistrées.", "Enregistrement des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        porteeTransaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MiseAJourAbos_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;
            provincesBindingSource.DataSource = dataContext.Provinces;

            var abonnements = dataContext.Abonnements;
            abonnementsBindingSource.DataSource = abonnements;
        }

        private void dgAbonnements_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }

        private void verifDependants()
        {
            /* Vérifications des dépendants */
            foreach (DataGridViewRow row in dgDependants.Rows)
            {
                bool booErreurDependant = false;

                if (row.Cells[1].Value == null || row.Cells[1].ToString().Trim() == "")
                {
                    row.Cells[1].ErrorText = "Veuillez remplir cette zone";
                    booErreurDependant = true;
                }
                else
                {
                    row.Cells[1].ErrorText = "";
                }

                if (row.Cells[2].Value == null || row.Cells[2].ToString().Trim() == "")
                {
                    row.Cells[2].ErrorText = "Veuillez remplir cette zone";
                    booErreurDependant = true;
                }
                else
                {
                    row.Cells[2].ErrorText = "";
                }

                if (booErreurDependant == true)
                {
                    row.ErrorText = "Il y a une erreur dans au moins une des cellules de ce dépendant";
                }
                else
                {
                    row.ErrorText = "";
                }
            }
        }

        private void dgDependants_Validating(object sender, CancelEventArgs e)
        {
            verifDependants();

            foreach (DataGridViewRow row in dgDependants.Rows)
            {
                if (row.ErrorText != "")
                {
                    MessageBox.Show("Veuillez résoudre toutes les erreurs des dépendants de cet abonné avant d'effectuer d'autres changements.",
                        "Erreur(s) dans les dépendants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    break;
                }
            }
        }
    }
}
