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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();

            Choix options = new Choix();

            // Set the size and location of the content form
            options.TopLevel = false;
            options.FormBorderStyle = FormBorderStyle.None;
            options.Dock = DockStyle.Fill;

            // Add the content form to the right panel
            splitContainer1.Panel1.Controls.Add(options);

            // Show the content form
            options.Show();
        }
    }
}
