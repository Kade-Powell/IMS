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
                PartId = 1,
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
            PartScreen partScreen = new PartScreen();
            partScreen.ShowDialog();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.ShowDialog();
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            this.searchPartsText.Text = "event fired";
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            this.searchProductsText.Text = "event fired";
        }

       
    }
}
