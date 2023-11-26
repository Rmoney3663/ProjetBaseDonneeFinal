namespace projetFinal.Options
{
    partial class InscriptionDepense
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
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceComboBox = new System.Windows.Forms.ComboBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "L’inscription d’une dépense";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(14, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(106, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Nom de l\'abonné:";
            // 
            // idComboBox
            // 
            this.idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(126, 73);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(240, 21);
            this.idComboBox.TabIndex = 7;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.BackColor = System.Drawing.Color.Transparent;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(14, 197);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(68, 13);
            remarqueLabel.TabIndex = 11;
            remarqueLabel.Text = "Remarque:";
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.Location = new System.Drawing.Point(126, 194);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(240, 20);
            this.remarqueTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dépense:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(126, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(projetFinal.Services);
            // 
            // typeServiceComboBox
            // 
            this.typeServiceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "TypeService", true));
            this.typeServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeServiceComboBox.FormattingEnabled = true;
            this.typeServiceComboBox.Location = new System.Drawing.Point(126, 152);
            this.typeServiceComboBox.Name = "typeServiceComboBox";
            this.typeServiceComboBox.Size = new System.Drawing.Size(240, 21);
            this.typeServiceComboBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(14, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 13);
            label3.TabIndex = 16;
            label3.Text = "Type Service:";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(17, 247);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(151, 51);
            this.btnConfirmer.TabIndex = 17;
            this.btnConfirmer.Text = "Confirmer Ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // InscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 522);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(label3);
            this.Controls.Add(this.typeServiceComboBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label1);
            this.Name = "InscriptionDepense";
            this.Text = "InscriptionDepense";
            this.Load += new System.EventHandler(this.InscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.ComboBox typeServiceComboBox;
        private System.Windows.Forms.Button btnConfirmer;
    }
}