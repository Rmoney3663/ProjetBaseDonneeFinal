using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
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

            if (tbTelephone.Text == "")
            {
                errMessage.SetError(tbTelephone, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbTelephone, "");
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

            if (tbCodePostal.Text == "")
            {
                errMessage.SetError(tbCodePostal, "Tous les éléments en gras sont obligatoires");
                binValide = false;
            }
            else
            {
                errMessage.SetError(tbCodePostal, "");
            }

            // Si toutes les valeurs sont acceptées
            if (binValide == true)
            {

            }
        }
    }
}
