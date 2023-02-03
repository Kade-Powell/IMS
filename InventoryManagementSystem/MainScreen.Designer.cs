namespace InventoryManagementSystem
{
    partial class MainScreen
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
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.searchProductsText = new System.Windows.Forms.TextBox();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchProductsButton.Location = new System.Drawing.Point(393, 12);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(93, 36);
            this.searchProductsButton.TabIndex = 4;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = false;
            // 
            // searchProductsText
            // 
            this.searchProductsText.Location = new System.Drawing.Point(492, 17);
            this.searchProductsText.Name = "searchProductsText";
            this.searchProductsText.Size = new System.Drawing.Size(203, 27);
            this.searchProductsText.TabIndex = 6;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.productsGridView);
            this.productsGroupBox.Controls.Add(this.deleteProductButton);
            this.productsGroupBox.Controls.Add(this.modifyProductButton);
            this.productsGroupBox.Controls.Add(this.addProductButton);
            this.productsGroupBox.Controls.Add(this.searchProductsButton);
            this.productsGroupBox.Controls.Add(this.searchProductsText);
            this.productsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGroupBox.Location = new System.Drawing.Point(723, 85);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(701, 416);
            this.productsGroupBox.TabIndex = 8;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToOrderColumns = true;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.productsGridView.Location = new System.Drawing.Point(12, 93);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowHeadersWidth = 51;
            this.productsGridView.RowTemplate.Height = 24;
            this.productsGridView.Size = new System.Drawing.Size(683, 150);
            this.productsGridView.TabIndex = 13;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteProductButton.Location = new System.Drawing.Point(591, 360);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(93, 36);
            this.deleteProductButton.TabIndex = 12;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.modifyProductButton.Location = new System.Drawing.Point(492, 360);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(93, 36);
            this.modifyProductButton.TabIndex = 11;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = false;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addProductButton.Location = new System.Drawing.Point(393, 360);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(93, 36);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partsGridView);
            this.partsGroupBox.Controls.Add(this.deletePartButton);
            this.partsGroupBox.Controls.Add(this.modifyPartButton);
            this.partsGroupBox.Controls.Add(this.addPartButton);
            this.partsGroupBox.Controls.Add(this.searchPartsButton);
            this.partsGroupBox.Controls.Add(this.searchPartsText);
            this.partsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(12, 84);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(695, 416);
            this.partsGroupBox.TabIndex = 9;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.AllowUserToOrderColumns = true;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.PartMin,
            this.PartMax});
            this.partsGridView.Location = new System.Drawing.Point(6, 94);
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.RowHeadersWidth = 51;
            this.partsGridView.RowTemplate.Height = 24;
            this.partsGridView.Size = new System.Drawing.Size(683, 150);
            this.partsGridView.TabIndex = 10;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "Part ID";
            this.PartID.MinimumWidth = 4;
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Width = 106;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 110;
            // 
            // PartInventory
            // 
            this.PartInventory.HeaderText = "Inventory";
            this.PartInventory.MinimumWidth = 6;
            this.PartInventory.Name = "PartInventory";
            this.PartInventory.ReadOnly = true;
            this.PartInventory.Width = 105;
            // 
            // PartPrice
            // 
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.MinimumWidth = 6;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.ReadOnly = true;
            this.PartPrice.Width = 105;
            // 
            // PartMin
            // 
            this.PartMin.HeaderText = "Min";
            this.PartMin.MinimumWidth = 6;
            this.PartMin.Name = "PartMin";
            this.PartMin.ReadOnly = true;
            this.PartMin.Width = 102;
            // 
            // PartMax
            // 
            this.PartMax.HeaderText = "Max";
            this.PartMax.MinimumWidth = 6;
            this.PartMax.Name = "PartMax";
            this.PartMax.ReadOnly = true;
            this.PartMax.Width = 102;
            // 
            // deletePartButton
            // 
            this.deletePartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deletePartButton.Location = new System.Drawing.Point(585, 361);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(93, 36);
            this.deletePartButton.TabIndex = 9;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = false;
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.modifyPartButton.Location = new System.Drawing.Point(486, 361);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(93, 36);
            this.modifyPartButton.TabIndex = 8;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = false;
            // 
            // addPartButton
            // 
            this.addPartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addPartButton.Location = new System.Drawing.Point(387, 361);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(93, 36);
            this.addPartButton.TabIndex = 7;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = false;
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPartsButton.Location = new System.Drawing.Point(387, 9);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(93, 36);
            this.searchPartsButton.TabIndex = 4;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = false;
            // 
            // searchPartsText
            // 
            this.searchPartsText.Location = new System.Drawing.Point(486, 13);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(203, 27);
            this.searchPartsText.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Location = new System.Drawing.Point(1314, 571);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 36);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.MinimumWidth = 4;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.Width = 116;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.Width = 110;
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Inventory";
            this.ProductInventory.MinimumWidth = 6;
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.ReadOnly = true;
            this.ProductInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductInventory.Width = 102;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductPrice.Width = 102;
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.MinimumWidth = 6;
            this.ProductMin.Name = "ProductMin";
            this.ProductMin.ReadOnly = true;
            this.ProductMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.MinimumWidth = 6;
            this.ProductMax.Name = "ProductMax";
            this.ProductMax.ReadOnly = true;
            this.ProductMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1436, 619);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsGroupBox);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.TextBox searchProductsText;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.TextBox searchPartsText;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMax;
    }
}

