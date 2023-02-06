using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public  BindingList<Part> AllParts = new BindingList<Part>();

        public void AddProduct(Product product) {
            Products.Add(product);
        }
        public bool RemoveProduct(int id) { return false; }
        public Product LookupProduct(int id) { return null; }
        public void AddPart(Part part) {
            AllParts.Add(part);
        }
        public bool DeletePart(int id) { return false; }
        public Part LookupPart(int id) { return null; }
        public void UpdatePart(int id, Part part) { }

    }
}
