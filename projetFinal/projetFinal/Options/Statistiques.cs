using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class Statistiques : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public Statistiques()
        {
            InitializeComponent();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            loadAbosParAnnee();
            loadAbosParMois();
            loadPartiesParAnnee();
            loadPartiesParMois();
        }


    private void loadAbosParAnnee ()
    {
            // Charger abonnements par année

            var donnees = (from unType in dataContext.TypesAbonnement
                           join unAbonne in dataContext.Abonnements
                           on unType.No equals unAbonne.NoTypeAbonnement
                           select new
                           {
                               type = unType.Description,
                               annee = unAbonne.DateAbonnement.Year,
                               nbAbo = unType.Abonnements
                               .Where(a => a.DateAbonnement.Year == unAbonne.DateAbonnement.Year).Count()
                           }).GroupBy(types => new { types.annee, types.type, types.nbAbo });

            foreach (var rangee in donnees.Select(d => d.Key))
            {
                dgAbosParAnneeEtType.Rows.Add(rangee.annee, rangee.type, rangee.nbAbo);
            }

            int sousTotal = 0;
            int total = 0;
            int annee = -1;

            // Sous-totaux
            foreach (DataGridViewRow row in dgAbosParAnneeEtType.Rows)
            {

                if (annee != int.Parse(row.Cells[0].Value.ToString()) && annee != -1)
                {
                    dgAbosParAnneeEtType.Rows.Insert(row.Index, annee, "Sous-total", sousTotal);
                    sousTotal = 0;
                    dgAbosParAnneeEtType.Rows[row.Index - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    dgAbosParAnneeEtType.Rows[row.Index - 1].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                    annee = int.Parse(row.Cells[0].Value.ToString());
                }
                else
                {
                    annee = int.Parse(row.Cells[0].Value.ToString());

                    if (row.Cells[1].Value.ToString() != "Sous-total")
                    {
                        total += int.Parse(row.Cells[2].Value.ToString());
                        sousTotal += int.Parse(row.Cells[2].Value.ToString());
                    }
                }
            }

            // Dernier sous-total
            int index = dgAbosParAnneeEtType.Rows.Add(annee, "Sous-total", sousTotal);
            dgAbosParAnneeEtType.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
            dgAbosParAnneeEtType.Rows[index].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            //dgAbosParAnneeEtType.Sort(colonneAnnee, ListSortDirection.Descending);
            //colonneAnnee.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Total
            int indexTot = dgAbosParAnneeEtType.Rows.Add("", "TOTAL", total);
            dgAbosParAnneeEtType.Rows[indexTot].DefaultCellStyle.BackColor = Color.Black;
            dgAbosParAnneeEtType.Rows[indexTot].DefaultCellStyle.ForeColor = Color.White;
            dgAbosParAnneeEtType.Rows[indexTot].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            dgAbosParAnneeEtType.ClearSelection();
        }

        private void loadAbosParMois()
        {
            // Charger abonnements par mois

            var donnees = (from unType in dataContext.TypesAbonnement
                           join unAbonne in dataContext.Abonnements
                           on unType.No equals unAbonne.NoTypeAbonnement
                           where unAbonne.DateAbonnement.Year == DateTime.Today.Year
                           select new
                           {
                               type = unType.Description,
                               mois = unAbonne.DateAbonnement.Month,
                               nbAbo = unType.Abonnements
                               .Where(a => a.DateAbonnement.Month == unAbonne.DateAbonnement.Month).Count()
                           }).GroupBy(types => new { types.mois, types.type, types.nbAbo });

            foreach (var rangee in donnees.Select(d => d.Key))
            {
                string moisEnTexte = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(rangee.mois).ToString().ToUpper();
                dgAbosParMoisEtType.Rows.Add(moisEnTexte, rangee.type, rangee.nbAbo);
            }

            int sousTotal = 0;
            int total = 0;
            string mois = "";

            // Sous-totaux
            foreach (DataGridViewRow row in dgAbosParMoisEtType.Rows)
            {

                if (mois != row.Cells[0].Value.ToString() && mois != "")
                {
                    dgAbosParMoisEtType.Rows.Insert(row.Index, mois, "Sous-total", sousTotal);
                    sousTotal = 0;
                    dgAbosParMoisEtType.Rows[row.Index - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    dgAbosParMoisEtType.Rows[row.Index - 1].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                    mois = row.Cells[0].Value.ToString();
                }
                else
                {
                    mois = row.Cells[0].Value.ToString();

                    if (row.Cells[1].Value.ToString() != "Sous-total")
                    {
                        total += int.Parse(row.Cells[2].Value.ToString());
                        sousTotal += int.Parse(row.Cells[2].Value.ToString());
                    }
                }
            }

            // Dernier sous-total
            int index = dgAbosParMoisEtType.Rows.Add(mois, "Sous-total", sousTotal);
            dgAbosParMoisEtType.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
            dgAbosParMoisEtType.Rows[index].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            // Total
            int indexTot = dgAbosParMoisEtType.Rows.Add("", "TOTAL", total);
            dgAbosParMoisEtType.Rows[indexTot].DefaultCellStyle.BackColor = Color.Black;
            dgAbosParMoisEtType.Rows[indexTot].DefaultCellStyle.ForeColor = Color.White;
            dgAbosParMoisEtType.Rows[indexTot].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            dgAbosParMoisEtType.ClearSelection();
        }

        private void loadPartiesParAnnee ()
        {
            // Charger les parties par année

            var donnees = (from unTerrain in dataContext.Terrains
                           join unePartie in dataContext.PartiesJouees
                           on unTerrain.No equals unePartie.NoTerrain
                           select new
                           {
                               terrain = unTerrain.Nom,
                               annee = unePartie.DatePartie.Year,
                               nbParties = unTerrain.PartiesJouees
                               .Where(a => a.DatePartie.Year == unePartie.DatePartie.Year).Count()
                           }).GroupBy(parties => new { parties.annee, parties.terrain, parties.nbParties });

            foreach (var rangee in donnees.Select(d => d.Key))
            {
                dgPartiesParAnnee.Rows.Add(rangee.annee, rangee.terrain, rangee.nbParties);
            }

            int sousTotal = 0;
            int total = 0;
            int annee = -1;

            // Sous-totaux
            foreach (DataGridViewRow row in dgPartiesParAnnee.Rows)
            {

                if (annee != int.Parse(row.Cells[0].Value.ToString()) && annee != -1)
                {
                    dgPartiesParAnnee.Rows.Insert(row.Index, annee, "Sous-total", sousTotal);
                    sousTotal = 0;
                    dgPartiesParAnnee.Rows[row.Index - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    dgPartiesParAnnee.Rows[row.Index - 1].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                    annee = int.Parse(row.Cells[0].Value.ToString());
                }
                else
                {
                    annee = int.Parse(row.Cells[0].Value.ToString());

                    if (row.Cells[1].Value.ToString() != "Sous-total")
                    {
                        total += int.Parse(row.Cells[2].Value.ToString());
                        sousTotal += int.Parse(row.Cells[2].Value.ToString());
                    }
                }
            }

            // Dernier sous-total
            int index = dgPartiesParAnnee.Rows.Add(annee, "Sous-total", sousTotal);
            dgPartiesParAnnee.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
            dgPartiesParAnnee.Rows[index].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            // Total
            int indexTot = dgPartiesParAnnee.Rows.Add("", "TOTAL", total);
            dgPartiesParAnnee.Rows[indexTot].DefaultCellStyle.BackColor = Color.Black;
            dgPartiesParAnnee.Rows[indexTot].DefaultCellStyle.ForeColor = Color.White;
            dgPartiesParAnnee.Rows[indexTot].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            dgPartiesParAnnee.ClearSelection();
        }

        private void loadPartiesParMois()
        {
            // Charger parties par mois

            var donnees = (from unTerrain in dataContext.Terrains
                           join unePartie in dataContext.PartiesJouees
                           on unTerrain.No equals unePartie.NoTerrain
                           select new
                           {
                               terrain = unTerrain.Nom,
                               mois = unePartie.DatePartie.Month,
                               nbParties = unTerrain.PartiesJouees
                               .Where(a => a.DatePartie.Month == unePartie.DatePartie.Month).Count()
                           }).GroupBy(parties => new { parties.mois, parties.terrain, parties.nbParties });

            foreach (var rangee in donnees.Select(d => d.Key))
            {
                string moisEnTexte = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(rangee.mois).ToString().ToUpper();
                dgPartiesParMois.Rows.Add(moisEnTexte, rangee.terrain, rangee.nbParties);
            }

            int sousTotal = 0;
            int total = 0;
            string mois = "";

            // Sous-totaux
            foreach (DataGridViewRow row in dgPartiesParMois.Rows)
            {

                if (mois != row.Cells[0].Value.ToString() && mois != "")
                {
                    dgPartiesParMois.Rows.Insert(row.Index, mois, "Sous-total", sousTotal);
                    sousTotal = 0;
                    dgPartiesParMois.Rows[row.Index - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    dgPartiesParMois.Rows[row.Index - 1].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                    mois = row.Cells[0].Value.ToString();
                }
                else
                {
                    mois = row.Cells[0].Value.ToString();

                    if (row.Cells[1].Value.ToString() != "Sous-total")
                    {
                        total += int.Parse(row.Cells[2].Value.ToString());
                        sousTotal += int.Parse(row.Cells[2].Value.ToString());
                    }
                }
            }

            // Dernier sous-total
            int index = dgPartiesParMois.Rows.Add(mois, "Sous-total", sousTotal);
            dgPartiesParMois.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
            dgPartiesParMois.Rows[index].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            // Total
            int indexTot = dgPartiesParMois.Rows.Add("", "TOTAL", total);
            dgPartiesParMois.Rows[indexTot].DefaultCellStyle.BackColor = Color.Black;
            dgPartiesParMois.Rows[indexTot].DefaultCellStyle.ForeColor = Color.White;
            dgPartiesParMois.Rows[indexTot].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            dgPartiesParMois.ClearSelection();
        }
    }
}
