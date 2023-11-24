namespace projetFinal.Options
{
    partial class InscriptionPartieJouee
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscriptionPartieJouee));
            this.label1 = new System.Windows.Forms.Label();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.terrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(14, 75);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(106, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Nom de l\'abonné:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.BackColor = System.Drawing.Color.Transparent;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(14, 111);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(98, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom du Terrain:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.BackColor = System.Drawing.Color.Transparent;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(341, 75);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(68, 13);
            remarqueLabel.TabIndex = 8;
            remarqueLabel.Text = "Remarque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "L’inscription d’une partie de golf jouée";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(projetFinal.Abonnements);
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Id", true));
            this.idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(126, 72);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(209, 21);
            this.idComboBox.TabIndex = 5;
            // 
            // terrainsBindingSource
            // 
            this.terrainsBindingSource.DataSource = typeof(projetFinal.Terrains);
            // 
            // nomComboBox
            // 
            this.nomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrainsBindingSource, "Nom", true));
            this.nomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomComboBox.FormattingEnabled = true;
            this.nomComboBox.Location = new System.Drawing.Point(126, 108);
            this.nomComboBox.Name = "nomComboBox";
            this.nomComboBox.Size = new System.Drawing.Size(209, 21);
            this.nomComboBox.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(415, 109);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pointage:";
            // 
            // partiesJoueesBindingSource
            // 
            this.partiesJoueesBindingSource.DataSource = typeof(projetFinal.PartiesJouees);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(415, 72);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(179, 20);
            this.remarqueTextBox.TabIndex = 9;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(237, 219);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(151, 51);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer Ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InscriptionPartieJouee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 650);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nomComboBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label1);
            this.Name = "InscriptionPartieJouee";
            this.Text = "InscriptionPartieJouee";
            this.Load += new System.EventHandler(this.InscriptionPartieJouee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource terrainsBindingSource;
        private System.Windows.Forms.ComboBox nomComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource partiesJoueesBindingSource;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ImageList imageList1;
    }
}