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
    public partial class Abonnement : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public Abonnement()
        {
            InitializeComponent();
        }

        private void Abonnement_Load(object sender, EventArgs e)
        {
            // Remplir le cb des types d'abonnements

            var typesAbonnement = from unType in dataContext.TypesAbonnement
                                  select unType;

            typesAbonnementBindingSource.DataSource = typesAbonnement;

            // Remplir le cb des provinces

            var provinces = from uneProvince in dataContext.Provinces
                            select uneProvince;

            provincesBindingSource.DataSource = provinces;
        }
        
        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool binValide = true;

            if (tbNom.Text == "")
            {
                errMessage.SetError(tbNom,"Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbNom,"");
            }

            if (tbPrenom.Text == "")
            {
                errMessage.SetError(tbPrenom, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbPrenom, "");
            }

            char sexe = 'N';
            if (rbF.Checked == false && rbH.Checked == false)
            {
                errMessage.SetError(rbH, "Veuillez sélectionner l'une des options");
                errMessage.SetError(rbF, "Veuillez sélectionner l'une des options");
                binValide = false;
            }
            else
            {
                errMessage.SetError(rbH, "");
                errMessage.SetError(rbF, "");
                if (rbF.Checked)
                    sexe = 'F';
                if (rbH.Checked)
                    sexe = 'H';
            }

            // Vérifier si l'âge minimum est atteint
            if (cbTypesAbo.SelectedValue.ToString() == "2")
            {
                if (dpNaissance.Value.Date.AddYears(60) > DateTime.Today)
                {
                    errMessage.SetError(dpNaissance, "L'abonné (âge d'or) doit avoir au moins 60 ans");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(dpNaissance,"");
                }
            }
            else
            {
                if (dpNaissance.Value.Date.AddYears(18) > DateTime.Today)
                {
                    errMessage.SetError(dpNaissance,"L'abonné doit avoir au moins 18 ans");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(dpNaissance, "");
                }
            }

            if (tbCourriel.Text == "")
            {
                errMessage.SetError(tbCourriel, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbCourriel, "");
            }

            string telephone = new string(tbTelephone.Text.Where(char.IsDigit).ToArray());
            if (telephone.Length != 10)
            {
                errMessage.SetError(tbTelephone, "Veuillez remplir cette zone de texte correctement");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbTelephone, "");
            }

            string cellulaire = new string(tbCellulaire.Text.Where(char.IsDigit).ToArray());
            if (cellulaire.Length != 10 && cellulaire.Length != 0)
            {
                errMessage.SetError(tbCellulaire, "Veuillez remplir cette zone de texte correctement ou la vider");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbCellulaire, "");
            }

            if (tbRue.Text == "")
            {
                errMessage.SetError(tbRue, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbRue, "");
            }

            if (tbVille.Text == "")
            {
                errMessage.SetError(tbVille, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbVille, "");
            }

            string codePostal = "";
            if (tbCodePostal.Text.Trim().Length != 7)
            {
                errMessage.SetError(tbCodePostal, "Veuillez remplir cette zone de texte correctement");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbCodePostal, "");
                codePostal = tbCodePostal.Text.Remove(3,1);
            }

            // Si toutes les valeurs sont acceptées
            if (binValide == true)
            {
                // Créer l'identifiant
                var tousLesIDs = from unAbonnement in dataContext.Abonnements
                                 select unAbonnement.Id;

                var plusGrandNo = 0;

                foreach (var id in tousLesIDs)
                {
                    string justeNumeros = new string(id.Where(char.IsDigit).ToArray());
                    int nombre = int.Parse(justeNumeros);
                    if (nombre > plusGrandNo)
                        plusGrandNo = nombre;
                }

                int numSequence = plusGrandNo + 1;

                string idAbonnement = Regex.Replace(tbNom.Text.Trim(), @"\d", "") + numSequence + "P";

                // Créer un abonnement avec infos
                Abonnements abonnement = new Abonnements
                {
                    Id = idAbonnement,
                    DateAbonnement = DateTime.Today,
                    Nom = tbNom.Text,
                    Prenom = tbPrenom.Text,
                    Sexe = sexe.ToString(),
                    DateNaissance = dpNaissance.Value,
                    NoCivique = int.Parse(numNoCivique.Value.ToString()),
                    Rue = tbRue.Text,
                    Ville = tbVille.Text,
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = codePostal,
                    Telephone = decimal.Parse(telephone),
                    Cellulaire = decimal.Parse(cellulaire),
                    Courriel = tbCourriel.Text,
                    NoTypeAbonnement = int.Parse((string)cbTypesAbo.SelectedValue),
                    Remarque = tbRemarque.Text
                };

                dataContext.Abonnements.InsertOnSubmit(abonnement);
                dataContext.SubmitChanges();
                MessageBox.Show("Nouvel abonnement ajouté", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
