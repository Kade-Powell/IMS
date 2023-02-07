using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Model
{
    public class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public  BindingList<Part> AllParts = new BindingList<Part>();

        public void AddProduct(Product product) {
            Products.Add(product);
        }
        public bool RemoveProduct(int id) {
            try
            {
               Products.Remove(LookupProduct(id));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public Product LookupProduct(int id) {
            return Products.SingleOrDefault(p => p.ProductId == id);
        }
        public void AddPart(Part part) {
            AllParts.Add(part);
        }
        public bool DeletePart(int id) {
            try {
                AllParts.Remove(LookupPart(id)); 
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            
        }
        public Part LookupPart(int id) { 
            return AllParts.SingleOrDefault(p => p.PartId== id);
        }
        public void UpdatePart(int id, Part part) {
            Part oldPart = LookupPart(id);
            AllParts[AllParts.IndexOf(oldPart)] = part;
        }

    }
}
