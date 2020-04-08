using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modul05_DataGridView.DataLayer;
using Modul05_DataGridView.FormDialogs;

namespace Modul05_DataGridView.UserControls
{
    public partial class DataGridViewWithEF : UserControl
    {
        public DataGridViewWithEF()
        {
            InitializeComponent();
        }

        private void DataGridViewWithEF_Load(object sender, EventArgs e)
        {
            using (AdventureWorks2017DbContext context = new AdventureWorks2017DbContext())
            {

                bindingSource1.DataSource = context.Product.ToList();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = bindingSource1;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Product selektiertesProdukt = (Product)bindingSource1.Current;
        }

        private void bindingSource1_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProductDialog dialog = new CreateProductDialog();
            dialog.ShowDialog();
        }

        private void lambdaSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AdventureWorks2017DbContext context = new AdventureWorks2017DbContext())
            {
                List<Product> resultListe = context.Product.Where(n => n.Class == "H").ToList();

                bindingSource1.DataSource = resultListe;
                dataGridView1.Refresh();
             }
        }
    }
}
