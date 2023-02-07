using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PartScreen : Form
    {
        public bool ModifyMode;
        private MainScreen MainScreen;

        public PartScreen(
            bool modifyMode,
            MainScreen mainScreen,

            int partId = 0,
            string name = "",
            decimal price = 0.00m,
            int inStock = 0,
            int min = 0,
            int max = 0,

            int machineId = 0,
            string companyName = null
            )
        {
            InitializeComponent();
            ModifyMode = modifyMode;
            MainScreen = mainScreen;

            this.partId.Text = partId.ToString();
            this.name.Text = name;
            this.price.Text = price.ToString();
            this.inStock.Text = inStock.ToString();
            this.min.Text = min.ToString();
            this.max.Text = max.ToString();

            //check if inhouse or outsourced on start. if none inhouse
            if (machineId != 0 && companyName != null)//both set this is an error 
            {
                throw new Exception("machine ID and company name set, only one or the other");
            }
            else if ( machineId != 0 )
            {
                this.machineId.Text = machineId.ToString();
                inhouseButton.Checked = true;
            }
            else if (companyName!= null ) 
            {
                this.companyName.Text = companyName.ToString();
                outsourcedButton.Checked = true;
            } else
            {
                // neither were set, default to inhouse product
                inhouseButton.Checked = true;
            }

            //set label
            if (modifyMode)
            {
                label1.Text = "Modify Part";
            }
            else
            {
                label1.Text = "Add Part";
            }
            
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            this.companyName.Visible = true;
            this.companyNameLabel.Visible= true;
            this.machineId.Visible = false;
            this.machineIdLabel.Visible= false;
        }

        private void inhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            this.companyName.Visible = false;
            this.companyNameLabel.Visible = false;
            this.machineId.Visible = true;
            this.machineIdLabel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private (bool, string) ValidateForm()
        {
            // part id validation
            if (!(Convert.ToInt32(this.partId.Text) >= 0)) { return (false, "part id must be greater than or equal to 0"); }
            if(!ModifyMode) 
            {
                if (MainScreen.MainInventory.LookupPart(Convert.ToInt32(this.partId.Text)) != null) { return (false, "Part ID already exist, choose a new id"); }
            }

            //name validation
            if (!(this.name.Text.Length > 0)) { return (false, "part name must be set"); }
           
            //price validation
            if (!(this.price.Text.Length > 0)) { return (false, "price must be specified"); }
            if (!(Convert.ToDecimal(this.price.Text) > 0)) { return (false, "price must be a decimal number greater than 0.00"); }
            //max validation
            if (!(this.max.Text.Length > 0)) { return (false, "Max must be set"); }
            if (!(Convert.ToInt32(this.max.Text) > 0))  { return (false, "max must be greater than 0"); }
            //min validation
            if (!(this.min.Text.Length > 0)) { return (false, "Min must be set"); }
            if (!(Convert.ToInt32(this.min.Text) >= 0)) { return (false, "min must be greater than or equal to 0"); }
            if (!(Convert.ToInt32(this.max.Text) > Convert.ToInt32(this.min.Text))) { return (false, "max must be greater than min"); }
            //in stock validation
            if (!(this.inStock.Text.Length > 0)) { return (false, "Inventory must be set"); }
            if (!
                    (
                        Convert.ToInt32(this.inStock.Text) > Convert.ToInt32(this.min.Text)
                    ) 
                    && 
                    (
                        Convert.ToInt32(this.inStock.Text) < Convert.ToInt32(this.max.Text)
                    ) 
                ) { return (false, "Inventory must be greater than Min and less than Max"); }
            
            if (outsourcedButton.Checked)
            {
                //company name validation
                if (!(this.companyName.Text.Length > 0)) { return (false, "Company Name must be set"); }
            }else if (inhouseButton.Checked)
            {
                //machine id validation
                if (!(this.machineId.Text.Length > 0)) { return (false, "Machine ID must be set"); }
                if (!(Convert.ToInt32(this.machineId.Text) >= 0)) { return (false, "Machine ID must be a positive whole number"); }
            }

            //all is good
            return (true, "");
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            var (formValid, message) = ValidateForm();
            if (!formValid) { MessageBox.Show(message); return; }

            Part part = null;
            if(outsourcedButton.Checked)//outsourced part
            {
               part = new Outsourced
                {
                    CompanyName = this.companyName.Text,
                    PartId = Convert.ToInt32(this.partId.Text),
                    Name = this.name.Text,
                    Price = Convert.ToDecimal(this.price.Text),
                    InStock = Convert.ToInt32(this.inStock.Text),
                    Max = Convert.ToInt32(this.max.Text),
                    Min = Convert.ToInt32(this.min.Text)
                };
            }else if(inhouseButton.Checked)// in house
            {
               part = new Inhouse
                {
                    MachineId = Convert.ToInt32(this.machineId.Text),
                   PartId = Convert.ToInt32(this.partId.Text),
                   Name = this.name.Text,
                   Price = Convert.ToDecimal(this.price.Text),
                   InStock = Convert.ToInt32(this.inStock.Text),
                   Max = Convert.ToInt32(this.max.Text),
                   Min = Convert.ToInt32(this.min.Text)
               };
            }
            else
            {
                //no category raise exception
                throw new Exception("unable to determine if part is inhouse or outsourced");
            }

            if (ModifyMode)
            {
                MainScreen.MainInventory.UpdatePart(part.PartId ,part);
            }
            else
            {
                MainScreen.MainInventory.AddPart(part);
            }

            //close form after adding or updating
            this.Close();
            
        }
    }
}
