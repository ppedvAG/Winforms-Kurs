using Modul05_DataGridView.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul05_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void einfachesGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear wird aufgerufen, weil eventuell ein anderes Control gerade angezeigt wird
            this.mainContent.Controls.Clear();

            SimpleDataGridView simpleDataGridView = new SimpleDataGridView();
            simpleDataGridView.Dock = DockStyle.Fill;


            this.mainContent.Controls.Add(simpleDataGridView);
        }
    }
}
