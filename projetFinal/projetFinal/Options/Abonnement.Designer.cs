namespace projetFinal.Options
{
    partial class Abonnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            this.tbCellulaire = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.dpNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTypesAbo = new System.Windows.Forms.ComboBox();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnVoirAbonnements = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.numNoCivique = new System.Windows.Forms.NumericUpDown();
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.tbCodePostal = new System.Windows.Forms.MaskedTextBox();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellulaireLabel.Location = new System.Drawing.Point(27, 315);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(66, 16);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // tbCellulaire
            // 
            this.tbCellulaire.Location = new System.Drawing.Point(247, 312);
            this.tbCellulaire.Name = "tbCellulaire";
            this.tbCellulaire.Size = new System.Drawing.Size(279, 22);
            this.tbCellulaire.TabIndex = 2;
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(27, 479);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(96, 16);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courrielLabel.Location = new System.Drawing.Point(27, 259);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(65, 16);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(247, 258);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(279, 22);
            this.tbCourriel.TabIndex = 6;
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateNaissanceLabel.Location = new System.Drawing.Point(27, 213);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(122, 16);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // dpNaissance
            // 
            this.dpNaissance.Location = new System.Drawing.Point(247, 208);
            this.dpNaissance.Name = "dpNaissance";
            this.dpNaissance.Size = new System.Drawing.Size(279, 22);
            this.dpNaissance.TabIndex = 10;
            this.dpNaissance.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProvinceLabel.Location = new System.Drawing.Point(27, 447);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(72, 16);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCiviqueLabel.Location = new System.Drawing.Point(27, 363);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(87, 16);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(27, 128);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(43, 16);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(247, 127);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(279, 22);
            this.tbNom.TabIndex = 18;
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeAbonnementLabel.Location = new System.Drawing.Point(27, 79);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(159, 18);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type d\'abonnement:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(27, 156);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(64, 16);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prenom:";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(247, 155);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(279, 22);
            this.tbPrenom.TabIndex = 22;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(27, 527);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(74, 16);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(247, 526);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(279, 22);
            this.tbRemarque.TabIndex = 24;
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.Location = new System.Drawing.Point(27, 391);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(39, 16);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(247, 390);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(279, 22);
            this.tbRue.TabIndex = 26;
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(27, 184);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(46, 16);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(27, 287);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(86, 16);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Telephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(27, 419);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(42, 16);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(247, 418);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(279, 22);
            this.tbVille.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nouvel abonnement";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projetFinal.TypesAbonnement);
            // 
            // cbTypesAbo
            // 
            this.cbTypesAbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.abonnementsBindingSource, "NoTypeAbonnement", true));
            this.cbTypesAbo.DataSource = this.typesAbonnementBindingSource;
            this.cbTypesAbo.DisplayMember = "Description";
            this.cbTypesAbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypesAbo.FormattingEnabled = true;
            this.cbTypesAbo.Location = new System.Drawing.Point(247, 78);
            this.cbTypesAbo.Name = "cbTypesAbo";
            this.cbTypesAbo.Size = new System.Drawing.Size(279, 24);
            this.cbTypesAbo.TabIndex = 46;
            this.cbTypesAbo.ValueMember = "No";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(projetFinal.Abonnements);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(projetFinal.Provinces);
            // 
            // cbProvince
            // 
            this.cbProvince.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.abonnementsBindingSource, "IdProvince", true));
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(247, 446);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(279, 24);
            this.cbProvince.TabIndex = 46;
            this.cbProvince.ValueMember = "Id";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(247, 182);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(74, 20);
            this.rbF.TabIndex = 48;
            this.rbF.TabStop = true;
            this.rbF.Text = "Femme";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(352, 182);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(76, 20);
            this.rbH.TabIndex = 49;
            this.rbH.TabStop = true;
            this.rbH.Text = "Homme";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(98, 576);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(330, 58);
            this.btnAjout.TabIndex = 50;
            this.btnAjout.Text = "Ajouter nouvel abonnement";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnVoirAbonnements
            // 
            this.btnVoirAbonnements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVoirAbonnements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirAbonnements.Location = new System.Drawing.Point(467, 576);
            this.btnVoirAbonnements.Name = "btnVoirAbonnements";
            this.btnVoirAbonnements.Size = new System.Drawing.Size(330, 58);
            this.btnVoirAbonnements.TabIndex = 51;
            this.btnVoirAbonnements.Text = "Voir la liste des abonnements";
            this.btnVoirAbonnements.UseVisualStyleBackColor = false;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(247, 361);
            this.numNoCivique.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(129, 22);
            this.numNoCivique.TabIndex = 52;
            this.numNoCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(247, 284);
            this.tbTelephone.Mask = "(000) 000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.PromptChar = '9';
            this.tbTelephone.Size = new System.Drawing.Size(279, 22);
            this.tbTelephone.TabIndex = 53;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(247, 476);
            this.tbCodePostal.Mask = "L0L 0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(279, 22);
            this.tbCodePostal.TabIndex = 54;
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 646);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.numNoCivique);
            this.Controls.Add(this.btnVoirAbonnements);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.rbH);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.cbTypesAbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.tbCellulaire);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dpNaissance);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVille);
            this.Name = "Abonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.Abonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCellulaire;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.DateTimePicker dpNaissance;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.ComboBox cbTypesAbo;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnVoirAbonnements;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.NumericUpDown numNoCivique;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.MaskedTextBox tbCodePostal;
    }
}