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

                // Erreur dans la rangée
                if (booErreurRow == true)
                {
                    row.ErrorText = "Il y a une erreur dans au moins une des cellules de cet abonnement";
                }
                else
                {
                    row.ErrorText = "";
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

        private void dgAbonnements_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
