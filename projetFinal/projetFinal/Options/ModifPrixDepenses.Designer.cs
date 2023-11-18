namespace projetFinal.Options
{
    partial class ModifPrixDepenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.typesAbonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepensesObligatoires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modification d\'un prix et des dépenses obligatoires";
            // 
            // typesAbonnementDataGridView
            // 
            this.typesAbonnementDataGridView.AllowUserToAddRows = false;
            this.typesAbonnementDataGridView.AllowUserToDeleteRows = false;
            this.typesAbonnementDataGridView.AllowUserToResizeColumns = false;
            this.typesAbonnementDataGridView.AllowUserToResizeRows = false;
            this.typesAbonnementDataGridView.AutoGenerateColumns = false;
            this.typesAbonnementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.typesAbonnementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesAbonnementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.dataGridViewTextBoxColumn2,
            this.Prix,
            this.DepensesObligatoires,
            this.Annee,
            this.dataGridViewTextBoxColumn3});
            this.typesAbonnementDataGridView.DataSource = this.typesAbonnementBindingSource;
            this.typesAbonnementDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.typesAbonnementDataGridView.Location = new System.Drawing.Point(17, 60);
            this.typesAbonnementDataGridView.MultiSelect = false;
            this.typesAbonnementDataGridView.Name = "typesAbonnementDataGridView";
            this.typesAbonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesAbonnementDataGridView.Size = new System.Drawing.Size(536, 155);
            this.typesAbonnementDataGridView.TabIndex = 3;
            this.typesAbonnementDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.typesAbonnementDataGridView_CellFormatting);
            this.typesAbonnementDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.typesAbonnementDataGridView_DataError);
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 10;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.Width = 49;
            // 
            // DepensesObligatoires
            // 
            this.DepensesObligatoires.DataPropertyName = "DepensesObligatoires";
            this.DepensesObligatoires.HeaderText = "DepensesObligatoires";
            this.DepensesObligatoires.Name = "DepensesObligatoires";
            this.DepensesObligatoires.Width = 135;
            // 
            // Annee
            // 
            this.Annee.DataPropertyName = "Annee";
            this.Annee.HeaderText = "Année";
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            this.Annee.Width = 63;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projetFinal.TypesAbonnement);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(86, 230);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(189, 51);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer Modification";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(281, 230);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(189, 51);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler Modification";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Location = new System.Drawing.Point(14, 44);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(336, 13);
            this.warn.TabIndex = 6;
            this.warn.Text = "Vous ne pouvez rien modifier, vous devez attendre l\'année prochaine.";
            this.warn.Visible = false;
            // 
            // ModifPrixDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 650);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.typesAbonnementDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ModifPrixDepenses";
            this.Text = "modifPrixDepenses";
            this.Load += new System.EventHandler(this.ModifPrixDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.DataGridView typesAbonnementDataGridView;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepensesObligatoires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}