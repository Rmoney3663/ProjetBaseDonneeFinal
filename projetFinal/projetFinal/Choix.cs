using projetFinal.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal
{
    public partial class Choix : Form
    {
        public int LoginUser { get; set; }
        public Choix()
        {
            InitializeComponent();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form topLevelForm = (Form)this.FindForm().Parent.Parent.Parent;

            topLevelForm.Dispose();
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnGestionEmp_Click(object sender, EventArgs e)
        {
            GestionEmployes formulaire = new GestionEmployes();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Gestion des employés";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            formulaire.LoginUser = LoginUser;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            Abonnement formulaire = new Abonnement();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Abonnement";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            Reabonnement formulaire = new Reabonnement();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Réabonnement";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnMiseAJourAbo_Click(object sender, EventArgs e)
        {
            MiseAJourAbos formulaire = new MiseAJourAbos();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Mise à jour des abonnés (abonné principal et dépendants)";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnModifPrixEtDepenses_Click(object sender, EventArgs e)
        {
            ModifPrixDepenses formulaire = new ModifPrixDepenses();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Modification des prix et des dépenses d'abonnement";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnInscriptionPartie_Click(object sender, EventArgs e)
        {
            InscriptionPartieJouee formulaire = new InscriptionPartieJouee();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Inscription d'une partie de golf jouée";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            InscriptionDepense formulaire = new InscriptionDepense();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Inscription d'une dépense";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnVisualisationRapports_Click(object sender, EventArgs e)
        {
            Rapports formulaire = new Rapports();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Visualisation des rapports";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }

        private void btnVisualisationStats_Click(object sender, EventArgs e)
        {
            Statistiques formulaire = new Statistiques();

            SplitContainer splitContainer = (SplitContainer)this.FindForm().Parent.Parent;

            splitContainer.Parent.Text = "Visualisation des statistiques";

            formulaire.TopLevel = false;
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(formulaire);

            formulaire.Show();
        }
    }
}
