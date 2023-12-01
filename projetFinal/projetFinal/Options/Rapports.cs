using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.Options
{
    public partial class Rapports : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public Rapports()
        {
            InitializeComponent();
        }

        private void Rapports_Load(object sender, EventArgs e)
        {

        }
    }
}
