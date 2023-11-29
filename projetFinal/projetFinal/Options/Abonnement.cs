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


            // Set up liste enfants

            listeEnfants.DisplayMember = "Prenom";
        }
        
        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool binValide = true;

            /* Vérification de l'abonné principal */
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
            decimal noCellulaire = 0;
            if (cellulaire.Length != 10 && cellulaire.Length != 0)
            {
                errMessage.SetError(tbCellulaire, "Veuillez remplir cette zone de texte correctement ou la vider");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbCellulaire, "");
                if (cellulaire != "")
                    noCellulaire = decimal.Parse(cellulaire);
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

            /* Vérifications du conjoint */
            char sexeConjoint = 'N';
            if (cbTypesAbo.SelectedIndex >= 2)
            {
                if (tbNomConjoint.Text.Trim() == "")
                {
                    errMessage.SetError(tbNomConjoint,"Tous les éléments en gras sont obligatoires");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(tbNomConjoint,"");
                }

                if (tbPrenomConjoint.Text.Trim() == "")
                {
                    errMessage.SetError(tbPrenomConjoint, "Tous les éléments en gras sont obligatoires");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(tbPrenomConjoint, "");
                }

                if (rbFConjoint.Checked == false && rbHConjoint.Checked == false)
                {
                    errMessage.SetError(rbHConjoint, "Veuillez sélectionner l'une des options");
                    errMessage.SetError(rbFConjoint, "Veuillez sélectionner l'une des options");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(rbHConjoint, "");
                    errMessage.SetError(rbFConjoint, "");
                    if (rbFConjoint.Checked)
                        sexeConjoint = 'F';
                    if (rbHConjoint.Checked)
                        sexeConjoint = 'H';
                }

                if (dpDateNaissanceConjoint.Value.Date.AddYears(18) > DateTime.Today)
                {
                    errMessage.SetError(dpDateNaissanceConjoint, "Le conjoint doit avoir au moins 18 ans");
                    binValide = false;
                }
                else
                {
                    errMessage.SetError(dpDateNaissanceConjoint, "");
                }
            }

            /* Vérifications des enfants */

            if (cbTypesAbo.SelectedIndex == 3 && listeEnfants.CheckedItems.Count != 1)
            {
                errMessage.SetError(listeEnfants, "Vous devez ajouter et cocher un seul enfant dans la liste");
                binValide = false;
            }
            else if (cbTypesAbo.SelectedIndex == 4 && listeEnfants.CheckedItems.Count != 2)
            {
                errMessage.SetError(listeEnfants, "Vous devez ajouter et cocher deux enfants dans la liste");
                binValide = false;
            }
            else if (cbTypesAbo.SelectedIndex == 5 && listeEnfants.CheckedItems.Count != numNbEnfants.Value)
            {
                errMessage.SetError(listeEnfants, "Vous devez ajouter et cocher le nombre d'enfants que vous avez indiqué plus haut");
                binValide = false;
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
                     DateNaissance = dpNaissance.Value.Date,
                     NoCivique = int.Parse(numNoCivique.Value.ToString()),
                     Rue = tbRue.Text,
                     Ville = tbVille.Text,
                     IdProvince = cbProvince.SelectedValue.ToString(),
                     CodePostal = codePostal,
                     Telephone = decimal.Parse(telephone),
                     Courriel = tbCourriel.Text,
                     NoTypeAbonnement = int.Parse(cbTypesAbo.SelectedValue.ToString()),
                     Remarque = tbRemarque.Text
                 };

                if (noCellulaire != 0)
                    abonnement.Cellulaire = decimal.Parse(cellulaire);

                dataContext.Abonnements.InsertOnSubmit(abonnement);

                // Créer le conjoint avec infos
                if (cbTypesAbo.SelectedIndex >= 2)
                {
                    string idConjoint = Regex.Replace(tbNom.Text.Trim(), @"\d", "") + numSequence + sexeConjoint + "0";

                    Dependants conjoint = new Dependants
                    {
                        Id = idConjoint,
                        Nom = tbNomConjoint.Text.Trim(),
                        Prenom = tbPrenomConjoint.Text.Trim(),
                        Sexe = sexeConjoint.ToString(),
                        DateNaissance = dpDateNaissanceConjoint.Value.Date,
                        IdAbonnement = idAbonnement,
                        Remarque = tbRemarqueConjoint.Text.Trim()
                    };
                    dataContext.Dependants.InsertOnSubmit(conjoint);
                }

                using (var porteeTransaction = new TransactionScope())
                {
                    // enregistre l'abonnement et les dépendants dans la base de données
                    try
                    {
                        // Ajouter les enfants
                        if (cbTypesAbo.SelectedIndex >= 3)
                        {
                            int noEnfant = 1;
                            foreach (Dependants enfant in listeEnfants.CheckedItems)
                            {
                                enfant.Id = Regex.Replace(tbNom.Text.Trim(), @"\d", "") + numSequence + "E" + noEnfant;
                                enfant.IdAbonnement = idAbonnement;

                                dataContext.Dependants.InsertOnSubmit(enfant);
                                
                                noEnfant++;
                            }
                        }
                            dataContext.SubmitChanges();
                            if (cbTypesAbo.SelectedIndex == 0 || cbTypesAbo.SelectedIndex == 1)
                                MessageBox.Show("L'abonnement " + idAbonnement + " et  a été enregistré.", "enregistrement de l'abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("L'abonnement " + idAbonnement + " et le(s) dépendant(s) ont été enregistrés.", "enregistrement de l'abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Controls.Clear();
                        InitializeComponent();
                        Abonnement_Load(null,null);

                        porteeTransaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbTypesAbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypesAbo.SelectedIndex == 0 || cbTypesAbo.SelectedIndex == 1)
            {
                lblNbEnfants.Visible = false;
                numNbEnfants.Visible = false;
                gbConjoint.Visible = false;
                gbEnfants.Visible = false;
            }

            else if (cbTypesAbo.SelectedIndex == 2)
            {
                lblNbEnfants.Visible = false;
                numNbEnfants.Visible = false;
                gbConjoint.Visible = true;
                gbEnfants.Visible = false;
            }

            else if (cbTypesAbo.SelectedIndex == 5)
            {
                lblNbEnfants.Visible = true;
                numNbEnfants.Visible = true;
                gbConjoint.Visible = true;
                gbEnfants.Visible = true;
            }

            else
            {
                lblNbEnfants.Visible = false;
                numNbEnfants.Visible = false;
                gbConjoint.Visible = true;
                gbEnfants.Visible = true;
            }
        }

        private void btnVoirAbonnements_Click(object sender, EventArgs e)
        {
            GestionAbonnements.frmListeAbonnements form = new GestionAbonnements.frmListeAbonnements();
            form.ShowDialog();
        }

        private void btnEnfant_Click(object sender, EventArgs e)
        {
            Dependants enfant = new Dependants();
            
            bool binValide = true;

            if (tbNomEnfant.Text.Trim() == "")
            {
                errMessage.SetError(tbNomEnfant, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                enfant.Nom = tbNomEnfant.Text.Trim();
                errMessage.SetError(tbNomEnfant, "");
            }

            if (tbPrenomEnfant.Text.Trim() == "")
            {
                errMessage.SetError(tbPrenomEnfant, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                enfant.Prenom = tbPrenomEnfant.Text.Trim();
                errMessage.SetError(tbPrenomEnfant, "");
            }

            if (rbFEnfant.Checked == false && rbHEnfant.Checked == false)
            {
                errMessage.SetError(rbHEnfant, "Veuillez sélectionner l'une des options");
                errMessage.SetError(rbFEnfant, "Veuillez sélectionner l'une des options");
                binValide = false;
            }
            else
            {
                errMessage.SetError(rbHEnfant, "");
                errMessage.SetError(rbFEnfant, "");
                if (rbFEnfant.Checked)
                    enfant.Sexe = "F";
                if (rbHEnfant.Checked)
                    enfant.Sexe = "H";
            }

            if (dpNaissanceEnfant.Value.Date.AddYears(18) <= DateTime.Today || dpNaissanceEnfant.Value.Date.AddYears(1) > DateTime.Today)
            {
                errMessage.SetError(dpNaissanceEnfant, "L'enfant doit avoir entre 1 et 17 ans");
                binValide = false;
            }
            else
            {
                enfant.DateNaissance = dpNaissanceEnfant.Value.Date;
                errMessage.SetError(dpNaissanceEnfant, "");
            }

            if (binValide == true)
            {
                enfant.Remarque = tbRemarqueEnfant.Text;
                listeEnfants.Items.Add (enfant,true);
            }
        }
    }
}
