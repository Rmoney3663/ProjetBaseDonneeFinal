namespace projetFinal.GestionEmploye
{
    partial class AjouterEmploye
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
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label noTypeEmployeLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.motDePasseTextBox = new System.Windows.Forms.TextBox();
            this.sexeComboBox = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.idProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.noTypeEmployeComboBox = new System.Windows.Forms.ComboBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            noTypeEmployeLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un employé";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(12, 343);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(221, 43);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(242, 343);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(198, 43);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler/Retourner";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(12, 63);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 4;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(112, 60);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTextBox.TabIndex = 5;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataSource = typeof(projetFinal.Employes);
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(239, 63);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(319, 60);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 6;
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(12, 96);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(77, 13);
            motDePasseLabel.TabIndex = 7;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Location = new System.Drawing.Point(112, 93);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(121, 20);
            this.motDePasseTextBox.TabIndex = 8;
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(239, 96);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 9;
            sexeLabel.Text = "Sexe:";
            // 
            // sexeComboBox
            // 
            this.sexeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Sexe", true));
            this.sexeComboBox.FormattingEnabled = true;
            this.sexeComboBox.Location = new System.Drawing.Point(319, 93);
            this.sexeComboBox.Name = "sexeComboBox";
            this.sexeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexeComboBox.TabIndex = 10;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(112, 126);
            this.numAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(121, 20);
            this.numAge.TabIndex = 11;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Age:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(239, 128);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 13;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(319, 125);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(121, 20);
            this.noCiviqueTextBox.TabIndex = 14;
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(12, 162);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 15;
            rueLabel.Text = "Rue:";
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(112, 159);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(121, 20);
            this.rueTextBox.TabIndex = 16;
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(239, 162);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(319, 159);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(121, 20);
            this.villeTextBox.TabIndex = 18;
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(12, 196);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 19;
            idProvinceLabel.Text = "Province:";
            // 
            // idProvinceComboBox
            // 
            this.idProvinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "IdProvince", true));
            this.idProvinceComboBox.FormattingEnabled = true;
            this.idProvinceComboBox.Location = new System.Drawing.Point(112, 193);
            this.idProvinceComboBox.Name = "idProvinceComboBox";
            this.idProvinceComboBox.Size = new System.Drawing.Size(121, 21);
            this.idProvinceComboBox.TabIndex = 20;
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(239, 196);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 21;
            codePostalLabel.Text = "Code Postal:";
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(319, 193);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(121, 20);
            this.codePostalTextBox.TabIndex = 22;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(12, 232);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 23;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(112, 229);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.telephoneTextBox.TabIndex = 24;
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(239, 232);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(52, 13);
            cellulaireLabel.TabIndex = 25;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Cellulaire", true));
            this.cellulaireTextBox.Location = new System.Drawing.Point(319, 229);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(121, 20);
            this.cellulaireTextBox.TabIndex = 26;
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(12, 267);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 27;
            courrielLabel.Text = "Courriel:";
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(112, 264);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(121, 20);
            this.courrielTextBox.TabIndex = 28;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(319, 264);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            131072});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Salaire Horaire:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Location = new System.Drawing.Point(12, 301);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(94, 13);
            noTypeEmployeLabel.TabIndex = 31;
            noTypeEmployeLabel.Text = "No Type Employe:";
            // 
            // noTypeEmployeComboBox
            // 
            this.noTypeEmployeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoTypeEmploye", true));
            this.noTypeEmployeComboBox.FormattingEnabled = true;
            this.noTypeEmployeComboBox.Location = new System.Drawing.Point(112, 298);
            this.noTypeEmployeComboBox.Name = "noTypeEmployeComboBox";
            this.noTypeEmployeComboBox.Size = new System.Drawing.Size(121, 21);
            this.noTypeEmployeComboBox.TabIndex = 32;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(239, 301);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 33;
            remarqueLabel.Text = "Remarque:";
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(319, 298);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(121, 20);
            this.remarqueTextBox.TabIndex = 34;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // AjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 522);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(this.noTypeEmployeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(this.idProvinceComboBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAge);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.sexeComboBox);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.motDePasseTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Name = "AjouterEmploye";
            this.Text = "AjouterEmploye";
            this.Load += new System.EventHandler(this.AjouterEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox motDePasseTextBox;
        private System.Windows.Forms.ComboBox sexeComboBox;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.ComboBox idProvinceComboBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox cellulaireTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox noTypeEmployeComboBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}