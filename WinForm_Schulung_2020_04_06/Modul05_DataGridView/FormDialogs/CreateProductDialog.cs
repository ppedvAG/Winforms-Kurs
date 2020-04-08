using Modul05_DataGridView.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul05_DataGridView.FormDialogs
{
    public partial class CreateProductDialog : Form
    {
        public CreateProductDialog()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (AdventureWorks2017DbContext context = new AdventureWorks2017DbContext())
            {
                try
                {
                    Product product = new Product();
                    product.Name = "Shampoo";
                    product.ProductNumber = "abcdefg";
                    product.MakeFlag = true;
                    product.FinishedGoodsFlag = false;
                    product.Color = "Orange";
                    product.SafetyStockLevel = 7;
                    product.ReorderPoint = 5;
                    product.StandardCost = 2m;
                    product.ListPrice = 5.99m;
                    product.Size = "XXL";
                    //FK -> von MeasureCode
                    product.SizeUnitMeasureCode = "BOX";
                    //FK
                    product.WeightUnitMeasureCode = "BOX";
                    product.Weight = 200m;
                    product.DaysToManufacture = 2;
                    product.ProductLine = "S";
                    product.Class = "H";
                    product.Style = "M";
                    //FK
                    product.ProductModelID = 1;
                    product.ProductSubcategoryID = 1;
                    product.SellEndDate = DateTime.Now;
                    product.SellStartDate = DateTime.Now;
                    product.DiscontinuedDate = DateTime.Now;
                    product.rowguid = Guid.NewGuid();
                    product.ModifiedDate = DateTime.Now;
                    
                    
                    
                    

                    

                    
                    
                    
                    
                   
                    



                    context.Product.Add(product);

                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    List<string> errorMessages = new List<string>();
                    foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                    {
                        string entityName = validationResult.Entry.Entity.GetType().Name;
                        foreach (DbValidationError error in validationResult.ValidationErrors)
                        {
                            errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                        }
                    }
                }
                


                this.Close();
                //System.Data.Entity.Validation.DbEntityValidationException
            }
        }
    }
}
