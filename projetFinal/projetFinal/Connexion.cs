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

namespace projetFinal
{
    public partial class Connexion : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var employes = from emp in dataContext.Employes
                               select emp;

                bool booEmpExiste = false;

                foreach (var emp in employes)
                {
                    if (emp.No.ToString() == tbNoEmploye.Text
                        && emp.MotDePasse == tbPassword.Text)
                    {
                        booEmpExiste = true;
                        Menu menu = new Menu();
                        this.Hide();
                        menu.LoginUser = int.Parse(tbNoEmploye.Text);
                        menu.ShowDialog();
                        this.Show();
                    }
                }

                if (booEmpExiste == false)
                {
                    resultat.Text = "Numéro d'employé ou mot de passe incorrect";
                }

                else
                {
                    resultat.Text = "";
                }
            }
        }

        private void tbNoEmploye_Validating(object sender, CancelEventArgs e)
        {
            if (tbNoEmploye.Text.Trim() == "")
            {
                errMessage.SetError(tbNoEmploye,"Le numéro d'employé ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbNoEmploye,"");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text.Trim() == "")
            {
                errMessage.SetError(tbPassword, "Le mot de passe ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                if (tbPassword.Text.Trim().Length < 8)
                {
                    errMessage.SetError(tbPassword, "La longeur du mot de passe doit être de minimum 8");
                    e.Cancel = true;
                }
                else
                {
                    string verifLettre = @"[A-Za-z]";
                    if (Regex.IsMatch(tbPassword.Text.Trim(), verifLettre))
                    {
                        string verifChiffre = @"\d";
                        if (Regex.IsMatch(tbPassword.Text.Trim(), verifChiffre))
                        {
                            string verifCaractere = @"[^A-Za-z0-9]";
                            if (Regex.IsMatch(tbPassword.Text.Trim(), verifCaractere))
                            {
                                errMessage.SetError(tbPassword, "");
                            }
                            else
                            {
                                errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins un caractère spécial");
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins un chiffre");
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        errMessage.SetError(tbPassword, "Le mot de passe doit contenir au moins une lettre");
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
