using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainScreen : Form
    {
        public Inventory MainInventory { get; set; }
        public MainScreen()
        {
            InitializeComponent();
        
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            MainInventory = new Inventory();
            Inhouse ihPart = new Inhouse
            {
                MachineId = 100,
                PartId = 1,
                Name = "steering column",
                Price= 5.99m,
                InStock= 2,
                Max = 20,
                Min = 10
            };

            Outsourced osPart = new Outsourced
            {
                CompanyName = "Some other company Name",
                PartId = 2,
                Name = "brake lines",
                Price = 5.99m,
                InStock = 2,
                Max = 20,
                Min = 10
            };


            MainInventory.AddPart(ihPart);
            MainInventory.AddPart(osPart);
            MainInventory.AddProduct(new Product
            {
                AssociatedParts = { osPart, ihPart },
                Name = "Red Bike",
                ProductId = 1,
                InStock = 2,
                Price = 149.99m,
                Max = 20,
                Min = 10
            });
            MainInventory.AddProduct(new Product
            {
                AssociatedParts = { osPart, ihPart },
                Name = "Blue Bike",
                ProductId = 2,
                InStock = 4,
                Price = 159.99m,
                Max = 20,
                Min = 10
            });

            partsGridView.DataSource = MainInventory.AllParts;
            productsGridView.DataSource = MainInventory.Products;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            PartScreen partScreen = new PartScreen(modifyMode: false, mainScreen: this );
            partScreen.ShowDialog();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.ShowDialog();
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
           string searchText = searchPartsText.Text;

            foreach(DataGridViewRow row in partsGridView.Rows)
            {
                if (row.Cells["name"].Value.ToString().Contains(searchText))
                {
                    //select row found
                    partsGridView.CurrentCell = partsGridView[0, row.Index];
                    return;
                }
               
            }
            //no match
            MessageBox.Show("No Part Name Includes: " + searchText);
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            string searchText = searchProductsText.Text;

            foreach (DataGridViewRow row in productsGridView.Rows)
            {
                if (row.Cells["name"].Value.ToString().Contains(searchText))
                {
                    //select row found
                    productsGridView.CurrentCell = productsGridView[0, row.Index];
                    return;
                }

            }
            //no match
            MessageBox.Show("No Product Name Includes: " + searchText);
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(partsGridView.CurrentRow.Cells["PartId"].Value.ToString(), out int partId))
            {
                MainInventory.DeletePart(partId);
                if (partsGridView.CurrentRow != null)
                {
                    partsGridView.CurrentRow.Selected = true;
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(productsGridView.CurrentRow.Cells["ProductId"].Value.ToString(), out int productId))
            {
                MainInventory.RemoveProduct(productId);
                if(productsGridView.CurrentRow != null)
                {
                    productsGridView.CurrentRow.Selected = true;
                }
                
            }
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            dynamic currentPart = MainInventory.LookupPart(Convert.ToInt32(partsGridView.CurrentRow.Cells["PartId"].Value));
            PartScreen partScreen;
 
           if (currentPart.GetType().ToString() == "InventoryManagementSystem.Model.Inhouse")
            {
                partScreen = new PartScreen(
                    modifyMode: true,
                    mainScreen: this,

                    partId: currentPart.PartId,
                    name: currentPart.Name,
                    price: currentPart.Price,
                    inStock: currentPart.InStock,
                    min: currentPart.Min,
                    max: currentPart.Max,
                    machineId: currentPart.MachineId
                    );
            }else if (currentPart.GetType().ToString() == "InventoryManagementSystem.Model.Outsourced")
            {
               partScreen = new PartScreen(
                   modifyMode: true,
                   mainScreen: this,

                   partId: currentPart.PartId,
                   name: currentPart.Name,
                   price: currentPart.Price,
                   inStock: currentPart.InStock,
                   min: currentPart.Min,
                   max: currentPart.Max,
                   companyName: currentPart.CompanyName
                   );
            }
            else
            {
                MessageBox.Show("unable to determine part type");
                throw new Exception("unable to determine part type");
            }

            
            partScreen.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.ShowDialog();
        }
    }
}
