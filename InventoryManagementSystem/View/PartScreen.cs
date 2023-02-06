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
        public PartScreen()
        {
            InitializeComponent();
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

    }
}
