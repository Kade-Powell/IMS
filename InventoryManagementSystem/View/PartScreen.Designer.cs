namespace InventoryManagementSystem
{
    partial class PartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inhouseButton = new System.Windows.Forms.RadioButton();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.partId = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inStock = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.machineId = new System.Windows.Forms.TextBox();
            this.machineIdLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inhouseButton
            // 
            this.inhouseButton.AutoSize = true;
            this.inhouseButton.Location = new System.Drawing.Point(195, 12);
            this.inhouseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inhouseButton.Name = "inhouseButton";
            this.inhouseButton.Size = new System.Drawing.Size(82, 20);
            this.inhouseButton.TabIndex = 1;
            this.inhouseButton.TabStop = true;
            this.inhouseButton.Text = "In-House";
            this.inhouseButton.UseVisualStyleBackColor = true;
            this.inhouseButton.CheckedChanged += new System.EventHandler(this.inhouseButton_CheckedChanged);
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Location = new System.Drawing.Point(339, 12);
            this.outsourcedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(97, 20);
            this.outsourcedButton.TabIndex = 2;
            this.outsourcedButton.TabStop = true;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            this.outsourcedButton.CheckedChanged += new System.EventHandler(this.outsourcedButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // partId
            // 
            this.partId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partId.Location = new System.Drawing.Point(195, 95);
            this.partId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partId.Name = "partId";
            this.partId.Size = new System.Drawing.Size(241, 24);
            this.partId.TabIndex = 4;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(195, 135);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(241, 24);
            this.name.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(109, 138);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 18);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // inStock
            // 
            this.inStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStock.Location = new System.Drawing.Point(195, 176);
            this.inStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inStock.Name = "inStock";
            this.inStock.Size = new System.Drawing.Size(241, 24);
            this.inStock.TabIndex = 8;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(91, 178);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "Inventory";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(195, 217);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(241, 24);
            this.price.TabIndex = 10;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(71, 219);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(86, 18);
            this.costLabel.TabIndex = 9;
            this.costLabel.Text = "Price / Cost";
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(195, 261);
            this.max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(87, 24);
            this.max.TabIndex = 12;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(121, 263);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(36, 18);
            this.maxLabel.TabIndex = 11;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(299, 263);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(32, 18);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(348, 261);
            this.min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(87, 24);
            this.min.TabIndex = 14;
            // 
            // machineId
            // 
            this.machineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineId.Location = new System.Drawing.Point(195, 308);
            this.machineId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.machineId.Name = "machineId";
            this.machineId.Size = new System.Drawing.Size(241, 24);
            this.machineId.TabIndex = 16;
            // 
            // machineIdLabel
            // 
            this.machineIdLabel.AutoSize = true;
            this.machineIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIdLabel.Location = new System.Drawing.Point(75, 311);
            this.machineIdLabel.Name = "machineIdLabel";
            this.machineIdLabel.Size = new System.Drawing.Size(82, 18);
            this.machineIdLabel.TabIndex = 15;
            this.machineIdLabel.Text = "Machine ID";
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(195, 308);
            this.companyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(241, 24);
            this.companyName.TabIndex = 18;
            this.companyName.Visible = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(41, 310);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(116, 18);
            this.companyNameLabel.TabIndex = 17;
            this.companyNameLabel.Text = "Company Name";
            this.companyNameLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(339, 391);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(73, 34);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(452, 391);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 34);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.machineId);
            this.Controls.Add(this.machineIdLabel);
            this.Controls.Add(this.min);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.inStock);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.partId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outsourcedButton);
            this.Controls.Add(this.inhouseButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PartScreen";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inhouseButton;
        private System.Windows.Forms.RadioButton outsourcedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partId;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inStock;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox machineId;
        private System.Windows.Forms.Label machineIdLabel;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}