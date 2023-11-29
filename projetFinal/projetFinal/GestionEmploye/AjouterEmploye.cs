using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.GestionEmploye
{
    public partial class AjouterEmploye : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public AjouterEmploye()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Options.GestionEmployes formulaire = new Options.GestionEmployes();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Gestion des employés";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool error = false;
            errMessage.Clear();
            if (CheckPassword(tbPassword.Text))
            {
                error = true;
            }

            if (prenomTextBox.Text.Trim() == "" || prenomTextBox.Text.Trim() == null)
            {
                errMessage.SetError(prenomTextBox, "Le prenom de l'employé ne peut pas être vide");
                error = true;
            }

            if (nomTextBox.Text.Trim() == "" || nomTextBox.Text.Trim() == null)
            {
                errMessage.SetError(nomTextBox, "Le nom de l'employé ne peut pas être vide");
                error = true;
            }

            if (sexeComboBox.SelectedItem == null)
            {
                errMessage.SetError(sexeComboBox, "Le sexe de l'employé ne peut pas être vide");
                error = true;           
            } 

            if (noCiviqueTextBox.Text.Trim() == "" || noCiviqueTextBox.Text.Trim() == null)
            {
                errMessage.SetError(noCiviqueTextBox, "Le numero civique de l'employé ne peut pas être vide");
                error = true;
            }
            if (!int.TryParse(noCiviqueTextBox.Text, out _))
            {
                errMessage.SetError(noCiviqueTextBox, "Le numéro civique doit être un nombre entier.");
                error = true;
            }

            if (rueTextBox.Text.Trim() == "" || rueTextBox.Text.Trim() == null)
            {
                errMessage.SetError(rueTextBox, "Le rue de l'employé ne peut pas être vide");
                error = true;
            }

            if (villeTextBox.Text.Trim() == "" || villeTextBox.Text.Trim() == null)
            {
                errMessage.SetError(villeTextBox, "La ville de l'employé ne peut pas être vide");
                error = true;
            }

            if (idProvinceComboBox.SelectedItem == null)
            {
                errMessage.SetError(idProvinceComboBox, "Le province de l'employé ne peut pas être vide");
                error = true;
            }

            string codePostal = "";
            if (tbCodePostal.Text.Trim().Length != 7)
            {
                errMessage.SetError(tbCodePostal, "Veuillez remplir cette zone de texte correctement");
                error = true;
            }
            else
            {                
                errMessage.SetError(tbCodePostal, "");
                codePostal = tbCodePostal.Text.Remove(3, 1);              

            }

            string telephone = new string(tbTelephone.Text.Where(char.IsDigit).ToArray());
            if (telephone.Length != 10)
            {
                errMessage.SetError(tbTelephone, "Veuillez remplir cette zone de texte correctement");
                error = true;
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
                error = true;
            }
            else
            {
                errMessage.SetError(tbCellulaire, "");
                if (cellulaire != "")
                    noCellulaire = decimal.Parse(cellulaire);
            }

            if (CheckEmail(courrielTextBox.Text))
            {
                error = true;
            }

            if (noTypeEmployeComboBox.SelectedItem == null)
            {
                errMessage.SetError(noTypeEmployeComboBox, "Le type d'employé ne peut pas être vide");
                error = true;
            }

            if (error == false)
            {
                try
                {
                    int largestNumber = dataContext.Employes.Max(employe => employe.No) + 1;

                    Employes newEmploye = new Employes
                    {
                        No = largestNumber,
                        MotDePasse = tbPassword.Text,
                        Nom = nomTextBox.Text,
                        Prenom = prenomTextBox.Text,
                        Sexe = (string)sexeComboBox.SelectedItem,
                        Age = (int)numAge.Value,
                        NoCivique = int.Parse(noCiviqueTextBox.Text),
                        Rue = rueTextBox.Text,
                        Ville = villeTextBox.Text,
                        IdProvince = (string)idProvinceComboBox.SelectedValue,
                        CodePostal = codePostal,
                        Telephone = decimal.Parse(telephone),
                        Courriel = courrielTextBox.Text,
                        SalaireHoraire = numSalaire.Value,
                        NoTypeEmploye = (int)noTypeEmployeComboBox.SelectedValue,
                        Remarque = remarqueTextBox.Text
                    };

                    if (noCellulaire != 0)
                        newEmploye.Cellulaire = decimal.Parse(cellulaire);

                    dataContext.Employes.InsertOnSubmit(newEmploye);
                    dataContext.SubmitChanges();
                   
                    MessageBox.Show("Employee ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show("Error pour ajouter employé: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AjouterEmploye_Load(object sender, EventArgs e)
        {
            List<string> sexOptions = new List<string> { "H", "F" };
            sexeComboBox.DataSource = sexOptions;
            sexeComboBox.SelectedIndex = -1;

            var provinces = from p in dataContext.Provinces
                            select p;
            idProvinceComboBox.DisplayMember = "Nom"; 
            idProvinceComboBox.ValueMember = "Id";   
            idProvinceComboBox.DataSource = provinces.ToList();

            var typesEmploye = from t in dataContext.TypesEmploye
                               where t.No != 1
                               select t;
            noTypeEmployeComboBox.DisplayMember = "Description"; 
            noTypeEmployeComboBox.ValueMember = "No";          
            noTypeEmployeComboBox.DataSource = typesEmploye.ToList();
        }

        private bool CheckPassword(string Password)
        {
            if (Password.Trim() == "")
            {
                errMessage.SetError(tbPassword, "Le mot de passe ne peut pas être vide");
                return true;
            }
            else
            {
                if (Password.Trim().Length < 8)
                {
                    errMessage.SetError(tbPassword, "La longeur du mot de passe doit être de minimum 8");
                    return true;
                }
                else
                {
                    string verifLettre = @"[A-Za-z]";
                    if (Regex.IsMatch(Password.Trim(), verifLettre))
                    {
                        string verifChiffre = @"\d";
                        if (Regex.IsMatch(Password.Trim(), verifChiffre))
                        {
                            string verifCaractere = @"[^A-Za-z0-9]";
                            if (Regex.IsMatch(Password.Trim(), verifCaractere))
                            {
                                errMessage.SetError(tbPassword, "");
                                return false;
                            }
                            else
                            {
                                errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins un caractère spécial");
                                return true;
                            }
                        }
                        else
                        {
                            errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins un chiffre");
                            return true;
                        }
                    }
                    else
                    {
                        errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins une lettre");
                        return true;
                    }
                }
            }            
        }
               
        private bool CheckEmail(string Email)
        {
            if (Email.Trim() == "")
            {
                errMessage.SetError(courrielTextBox, "Le courriel de l'employé ne peut pas être vide");
                return true;
            }
            else
            {               
                Regex courriel = new Regex("^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$");

                if (courriel.IsMatch(Email.Trim()))
                {
                    return false;
                }
                else
                {
                    errMessage.SetError(courrielTextBox, "Le courriel doit être dans le format d'un courriel valide.");
                    return true;
                }
            }
        }

    }
}
