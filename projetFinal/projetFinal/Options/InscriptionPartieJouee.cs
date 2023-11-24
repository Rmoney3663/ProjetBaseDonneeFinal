using System;
using System.Activities.Expressions;
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
    public partial class InscriptionPartieJouee : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public InscriptionPartieJouee()
        {
            InitializeComponent();
        }

        private void InscriptionPartieJouee_Load(object sender, EventArgs e)
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


                var query2 = from terrains in dataContext.Terrains
                             select new
                                {
                                    Id = terrains.No,
                                    DisplayName = terrains.Nom
                             };

                nomComboBox.DataSource = query2.ToList();
                nomComboBox.DisplayMember = "DisplayName";
                nomComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            string id = (string)idComboBox.SelectedValue;
            int nomterrain = (int)nomComboBox.SelectedValue;
            try
            {
                var query = from abonnement in dataContext.Abonnements
                            where abonnement.DateAbonnement.Year == currentYear && abonnement.Id == id
                            select abonnement;

                var query2 = from reabonnement in dataContext.Reabonnements
                             where reabonnement.DateRenouvellement.Year == currentYear && reabonnement.IdAbonnement == id
                            select reabonnement;
                if (query.Any() || query2.Any())
                {
                    PartiesJouees newJeu = new PartiesJouees
                    {
                        IdAbonnement = id,
                        NoTerrain = nomterrain,
                        DatePartie = DateTime.Now,
                        Pointage = (int)numericUpDown1.Value,
                        Remarque = remarqueTextBox.Text
                    };
                    dataContext.PartiesJouees.InsertOnSubmit(newJeu);
                    dataContext.SubmitChanges();
                    MessageBox.Show("Partie jouée ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                }
                else
                {
                    MessageBox.Show("L'utilisateur n'est pas abonné cette année", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

 
    }
}
