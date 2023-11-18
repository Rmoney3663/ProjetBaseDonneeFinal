using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class ModifPrixDepenses : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public ModifPrixDepenses()
        {
            InitializeComponent();
        }

        private void ModifPrixDepenses_Load(object sender, EventArgs e)
        {   
            var query = from ta in dataContext.TypesAbonnement
                        join pd in dataContext.PrixDepensesAbonnements on ta.No equals pd.NoTypeAbonnement
                        group new 
                        {
                            ta.No,
                            ta.Description,
                            Annee = pd.Annee,
                            Prix = pd.Prix,
                            DepensesObligatoires = pd.DepensesObligatoires
                        } by pd.NoTypeAbonnement into Type
                        let maxAnnee = Type.Max(t => t.Annee)
                        select Type.First(t => t.Annee == maxAnnee);

            var dataList = query.Select(t => new AbonnementData
            {
                No = t.No,
                Description = t.Description,
                Annee = t.Annee,
                Prix = t.Prix,
                DepensesObligatoires = t.DepensesObligatoires
            }).ToList();

            var bindingList = new BindingList<AbonnementData>(dataList);
            typesAbonnementBindingSource.DataSource = bindingList;
            typesAbonnementDataGridView.DataSource = typesAbonnementBindingSource;

            typesAbonnementDataGridView.CellFormatting += typesAbonnementDataGridView_CellFormatting;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez annuler la modification", "Annuler Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var query = from ta in dataContext.TypesAbonnement
                        join pd in dataContext.PrixDepensesAbonnements on ta.No equals pd.NoTypeAbonnement
                        group new
                        {
                            ta.No,
                            ta.Description,
                            Annee = pd.Annee,
                            Prix = pd.Prix,
                            DepensesObligatoires = pd.DepensesObligatoires
                        } by pd.NoTypeAbonnement into Type
                        let maxAnnee = Type.Max(t => t.Annee)
                        select Type.First(t => t.Annee == maxAnnee);

            var dataList = query.Select(t => new AbonnementData
            {
                No = t.No,
                Description = t.Description,
                Annee = t.Annee,
                Prix = t.Prix,
                DepensesObligatoires = t.DepensesObligatoires
            }).ToList();

            var bindingList = new BindingList<AbonnementData>(dataList);
            typesAbonnementBindingSource.DataSource = bindingList;
            typesAbonnementDataGridView.DataSource = typesAbonnementBindingSource;

            typesAbonnementDataGridView.CellFormatting += typesAbonnementDataGridView_CellFormatting;
        }

        private void typesAbonnementDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var check = 0;
            if (typesAbonnementDataGridView.Columns[e.ColumnIndex].Name == "Annee")
            {
                if (Convert.ToInt32(e.Value) == DateTime.Now.Year)
                {
                    typesAbonnementDataGridView.Rows[e.RowIndex].Cells["Prix"].ReadOnly = true;
                    typesAbonnementDataGridView.Rows[e.RowIndex].Cells["DepensesObligatoires"].ReadOnly = true;
                }
                else
                {
                    check = 1;
                    typesAbonnementDataGridView.Rows[e.RowIndex].Cells["Prix"].ReadOnly = false;
                    typesAbonnementDataGridView.Rows[e.RowIndex].Cells["DepensesObligatoires"].ReadOnly = false;
                }
            }
            if (check == 1)
            {
                warn.Text = "";
            }
            else
            {
                warn.Text = "Vous ne pouvez rien modifier, vous devez attendre l'année prochaine.";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    foreach (DataGridViewRow row in typesAbonnementDataGridView.Rows)
                    {
                        var no = row.Cells["No"].Value;
                        var prix = row.Cells["Prix"].Value;
                        var depense = row.Cells["DepensesObligatoires"].Value;
                        PrixDepensesAbonnements unPrixDepensesAbonnements = new PrixDepensesAbonnements
                        {
                            NoTypeAbonnement = (int)no,
                            Annee = DateTime.Now.Year ,
                            Prix = (decimal)prix,
                            DepensesObligatoires = (decimal)depense,
                            Remarque = null
                        };
                        dataContext.PrixDepensesAbonnements.InsertOnSubmit(unPrixDepensesAbonnements);
                    }

                    dataContext.SubmitChanges();                   

                    var query = from ta in dataContext.TypesAbonnement
                                join pd in dataContext.PrixDepensesAbonnements on ta.No equals pd.NoTypeAbonnement
                                group new
                                {
                                    ta.No,
                                    ta.Description,
                                    Annee = pd.Annee,
                                    Prix = pd.Prix,
                                    DepensesObligatoires = pd.DepensesObligatoires
                                } by pd.NoTypeAbonnement into Type
                                let maxAnnee = Type.Max(t => t.Annee)
                                select Type.First(t => t.Annee == maxAnnee);

                    var dataList = query.Select(t => new AbonnementData
                    {
                        No = t.No,
                        Description = t.Description,
                        Annee = t.Annee,
                        Prix = t.Prix,
                        DepensesObligatoires = t.DepensesObligatoires
                    }).ToList();

                    var bindingList = new BindingList<AbonnementData>(dataList);
                    typesAbonnementBindingSource.DataSource = bindingList;
                    typesAbonnementDataGridView.DataSource = typesAbonnementBindingSource;

                    typesAbonnementDataGridView.CellFormatting += typesAbonnementDataGridView_CellFormatting;
                    MessageBox.Show("Vous avez modifier les prix et dépense obligatoire.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }

        private void typesAbonnementDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //MessageBox.Show(e.Exception.Message);
            MessageBox.Show("Valuer ne peut pas être nulls ou ne peut pas contenir des lettres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class AbonnementData
    {
        public int No { get; set; }
        public string Description { get; set; }
        public decimal Annee { get; set; }
        public decimal Prix { get; set; }
        public decimal DepensesObligatoires { get; set; }
    }
}
