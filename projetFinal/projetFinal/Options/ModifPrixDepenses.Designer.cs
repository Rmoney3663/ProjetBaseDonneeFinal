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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.typesAbonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepensesObligatoires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 29);
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
            this.typesAbonnementDataGridView.Location = new System.Drawing.Point(23, 74);
            this.typesAbonnementDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typesAbonnementDataGridView.MultiSelect = false;
            this.typesAbonnementDataGridView.Name = "typesAbonnementDataGridView";
            this.typesAbonnementDataGridView.RowHeadersWidth = 51;
            this.typesAbonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesAbonnementDataGridView.Size = new System.Drawing.Size(715, 191);
            this.typesAbonnementDataGridView.TabIndex = 3;
            this.typesAbonnementDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.typesAbonnementDataGridView_CellFormatting);
            this.typesAbonnementDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.typesAbonnementDataGridView_DataError);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projetFinal.TypesAbonnement);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(115, 283);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(252, 63);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer Modification";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(375, 283);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(252, 63);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler Modification";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Location = new System.Drawing.Point(19, 54);
            this.warn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(419, 16);
            this.warn.TabIndex = 6;
            this.warn.Text = "Vous ne pouvez rien modifier, vous devez attendre l\'année prochaine.";
            this.warn.Visible = false;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 10;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 54;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Prix.DefaultCellStyle = dataGridViewCellStyle1;
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Width = 58;
            // 
            // DepensesObligatoires
            // 
            this.DepensesObligatoires.DataPropertyName = "DepensesObligatoires";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.DepensesObligatoires.DefaultCellStyle = dataGridViewCellStyle2;
            this.DepensesObligatoires.HeaderText = "DepensesObligatoires";
            this.DepensesObligatoires.MinimumWidth = 6;
            this.DepensesObligatoires.Name = "DepensesObligatoires";
            this.DepensesObligatoires.Width = 172;
            // 
            // Annee
            // 
            this.Annee.DataPropertyName = "Annee";
            this.Annee.HeaderText = "Année";
            this.Annee.MinimumWidth = 6;
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            this.Annee.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // ModifPrixDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 642);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.typesAbonnementDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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