﻿using System;
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
    public partial class ModifierEmploye : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public int ID { get; set; }
        public ModifierEmploye()
        {
            InitializeComponent();
        }

        private void ModifierEmploye_Load(object sender, EventArgs e)
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

            var employeeToEdit = dataContext.Employes.SingleOrDefault(employ => employ.No == ID);

            if (employeeToEdit != null)
            {
                tbPassword.Text = employeeToEdit.MotDePasse;
                nomTextBox.Text = employeeToEdit.Nom;
                prenomTextBox.Text = employeeToEdit.Prenom;
                sexeComboBox.SelectedItem = employeeToEdit.Sexe;
                numAge.Value = employeeToEdit.Age;
                noCiviqueTextBox.Text = employeeToEdit.NoCivique.ToString();
                rueTextBox.Text = employeeToEdit.Rue;
                villeTextBox.Text = employeeToEdit.Ville;
                idProvinceComboBox.SelectedValue = employeeToEdit.IdProvince;
                codePostalTextBox.Text = employeeToEdit.CodePostal;
                telephoneTextBox.Text = employeeToEdit.Telephone.ToString();
                cellulaireTextBox.Text = employeeToEdit.Cellulaire.ToString();
                courrielTextBox.Text = employeeToEdit.Courriel;
                numSalaire.Value = employeeToEdit.SalaireHoraire;
                remarqueTextBox.Text = employeeToEdit.Remarque;

            };
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

        private bool CheckCodePostal(string CodePostal)
        {
            if (CodePostal.Trim() == "")
            {
                errMessage.SetError(codePostalTextBox, "Le code postal de l'employé ne peut pas être vide");
                return true;
            }
            else
            {
                if (CodePostal.Trim().Length == 6)
                {
                    Regex canadianPostalCodeRegex = new Regex("^[A-Za-z]\\d[A-Za-z]\\d[A-Za-z]\\d$");

                    if (canadianPostalCodeRegex.IsMatch(CodePostal.Trim()))
                    {
                        return false;
                    }
                    else
                    {
                        errMessage.SetError(codePostalTextBox, "Le code postal n'est pas au format A#A#A#.");
                        return true;
                    }
                }
                else
                {
                    errMessage.SetError(codePostalTextBox, "La longueur du code postal doit être de 6 caractères.");
                    return true;
                }

            }
        }

        private bool CheckPhone(string NumberPhone)
        {
            if (NumberPhone.Trim() == "")
            {
                errMessage.SetError(telephoneTextBox, "Le numero de telephone de l'employé ne peut pas être vide");
                return true;
            }
            else
            {
                if (NumberPhone.Trim().Length == 10)
                {
                    Regex phonenumber = new Regex("^\\d{10}$");

                    if (phonenumber.IsMatch(NumberPhone.Trim()))
                    {
                        return false;
                    }
                    else
                    {
                        errMessage.SetError(telephoneTextBox, "Le numero de telephone doit contenir seulement des numéros.");
                        return true;
                    }
                }
                else
                {
                    errMessage.SetError(telephoneTextBox, "La longueur du numero de telephone doit être de 10 caractères.");
                    return true;
                }
            }
        }

        private bool CheckCell(string NumberPhone)
        {
            if (NumberPhone.Trim() == "")
            {
                errMessage.SetError(cellulaireTextBox, "Le numero de cellulaire de l'employé ne peut pas être vide");
                return true;
            }
            else
            {
                if (NumberPhone.Trim().Length == 10)
                {
                    Regex phonenumber = new Regex("^\\d{10}$");

                    if (phonenumber.IsMatch(NumberPhone.Trim()))
                    {
                        return false;
                    }
                    else
                    {
                        errMessage.SetError(cellulaireTextBox, "Le numero de cellulaire doit contenir seulement des numéros.");
                        return true;
                    }
                }
                else
                {
                    errMessage.SetError(cellulaireTextBox, "La longueur du numero de cellulaire doit être de 10 caractères.");
                    return true;
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bool error = false;
            errMessage.Clear();
            if (CheckPassword(tbPassword.Text))
            {
                error = true;
            }

            if (prenomTextBox.Text.Trim() == "")
            {
                errMessage.SetError(prenomTextBox, "Le prenom de l'employé ne peut pas être vide");
                error = true;
            }

            if (nomTextBox.Text.Trim() == "")
            {
                errMessage.SetError(nomTextBox, "Le nom de l'employé ne peut pas être vide");
                error = true;
            }

            if (sexeComboBox.SelectedItem == null)
            {
                errMessage.SetError(sexeComboBox, "Le sexe de l'employé ne peut pas être vide");
                error = true;
            }

            if (noCiviqueTextBox.Text.Trim() == "")
            {
                errMessage.SetError(noCiviqueTextBox, "Le numero civique de l'employé ne peut pas être vide");
                error = true;
            }
            if (!int.TryParse(noCiviqueTextBox.Text, out _))
            {
                errMessage.SetError(noCiviqueTextBox, "Le numéro civique doit être un nombre entier.");
                error = true;
            }

            if (rueTextBox.Text.Trim() == "")
            {
                errMessage.SetError(rueTextBox, "Le rue de l'employé ne peut pas être vide");
                error = true;
            }

            if (villeTextBox.Text.Trim() == "")
            {
                errMessage.SetError(villeTextBox, "La ville de l'employé ne peut pas être vide");
                error = true;
            }

            if (idProvinceComboBox.SelectedItem == null)
            {
                errMessage.SetError(idProvinceComboBox, "Le province de l'employé ne peut pas être vide");
                error = true;
            }

            if (CheckCodePostal(codePostalTextBox.Text))
            {
                error = true;
            }

            if (CheckPhone(telephoneTextBox.Text))
            {
                error = true;
            }

            if (CheckCell(cellulaireTextBox.Text))
            {
                error = true;
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
                    var employeeToModify = dataContext.Employes.SingleOrDefault(employ => employ.No == ID);

                    if (employeeToModify != null)
                    {
                        employeeToModify.MotDePasse = tbPassword.Text;
                        employeeToModify.Nom = nomTextBox.Text;
                        employeeToModify.Prenom = prenomTextBox.Text;
                        employeeToModify.Sexe = (string)sexeComboBox.SelectedItem;
                        employeeToModify.Age = (int)numAge.Value;
                        employeeToModify.NoCivique = int.Parse(noCiviqueTextBox.Text);
                        employeeToModify.Rue = rueTextBox.Text;
                        employeeToModify.Ville = villeTextBox.Text;
                        employeeToModify.IdProvince = (string)idProvinceComboBox.SelectedValue;
                        employeeToModify.CodePostal = codePostalTextBox.Text;
                        employeeToModify.Telephone = decimal.Parse(telephoneTextBox.Text);
                        employeeToModify.Cellulaire = decimal.Parse(cellulaireTextBox.Text);
                        employeeToModify.Courriel = courrielTextBox.Text;
                        employeeToModify.SalaireHoraire = numSalaire.Value;
                        employeeToModify.Remarque = remarqueTextBox.Text;

                    };

                    dataContext.SubmitChanges();
                    MessageBox.Show("Employee modifier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error pour modifier employé: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

    }
}
