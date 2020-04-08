using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modul05_DataGridView.UserControls
{
    public partial class SimpleDataGridView : UserControl
    {
        public SimpleDataGridView()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            string connectionString = "Data Source=SURFACE-KW4;Initial Catalog=AdventureWorks2017;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SQL + DataGridView wird zusammen gebaut

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable resultTable = new DataTable();
                    connection.Open();
                    string sqlStatement = "SELECT TOP 100 * FROM Production.Product";

                    // bessere alternative zu direkten string-statemen SqlCommandBuilder sqlCommand = new SqlCommandBuilder();
                    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(resultTable);
                    // Variante 1
                    
                    dataGridView1.DataSource = resultTable;


                    //Colums einfärben
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

                    AdjustColumnOrder();
                    CreateUnboundButtonColumn();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void AdjustColumnOrder()
        {



            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["ListPrice"].DisplayIndex = 0;

            // An dieser Stelle funktioniert die AutoSize Eigenschaft immer noch :-) 
            dataGridView1.Columns["ListPrice"].HeaderText = "Preis in Liste";

            //dataGridView1.Columns["ListPrice"].ReadOnly = true;

           


            dataGridView1.Columns["ListPrice"].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns["ListPrice"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void CreateUnboundButtonColumn()
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Create Reports";
            buttonColumn.Text = "Create Reports";
            buttonColumn.Name = "CreateReport";
            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }



        // https://docs.microsoft.com/de-de/dotnet/api/system.windows.forms.datagridviewbuttoncolumn?view=netframework-4.8
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1.Columns["CreateReport"].Index) return;
            
            // Retrieve the task ID.
            int Id = (Int32)dataGridView1["ProductID", e.RowIndex].Value;
        }
    }
}
