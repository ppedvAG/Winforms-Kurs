using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul05_DataGridView.UserControls
{
    public partial class BindingDataGrid : UserControl
    {
        public BindingDataGrid()
        {
            InitializeComponent();
        }

        private void BindingDataGrid_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.adventureWorks2017DataSet.Product);
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Möchtest du speichern?", "Nachricht", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.productTableAdapter.Update(adventureWorks2017DataSet.Product);
                dataGridView1.Refresh();
                MessageBox.Show("Datensatz gespeichert");
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            //if (headerText == "Name")
            //{
            //    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            //    {
            //        dataGridView1.Rows[e.RowIndex].ErrorText = "Product Name not be empty";
            //        e.Cancel = true;
            //    }
            //}
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void productBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void bindingNavigator1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {

        }
    }
}
