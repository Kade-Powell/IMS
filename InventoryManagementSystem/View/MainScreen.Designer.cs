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
            this.components = new System.ComponentModel.Container();
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
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
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
            this.searchProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(93, 36);
            this.searchProductsButton.TabIndex = 9;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = false;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // searchProductsText
            // 
            this.searchProductsText.Location = new System.Drawing.Point(492, 17);
            this.searchProductsText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchProductsText.Name = "searchProductsText";
            this.searchProductsText.Size = new System.Drawing.Size(203, 27);
            this.searchProductsText.TabIndex = 8;
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
            this.productsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBox.Size = new System.Drawing.Size(701, 416);
            this.productsGroupBox.TabIndex = 7;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToOrderColumns = true;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(12, 94);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.productsGridView.RowTemplate.Height = 24;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(683, 150);
            this.productsGridView.TabIndex = 10;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteProductButton.Location = new System.Drawing.Point(591, 359);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(93, 36);
            this.deleteProductButton.TabIndex = 13;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.modifyProductButton.Location = new System.Drawing.Point(492, 359);
            this.modifyProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(93, 36);
            this.modifyProductButton.TabIndex = 12;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = false;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addProductButton.Location = new System.Drawing.Point(393, 359);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(93, 36);
            this.addProductButton.TabIndex = 11;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
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
            this.partsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsGroupBox.Size = new System.Drawing.Size(695, 416);
            this.partsGroupBox.TabIndex = 0;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.AllowUserToOrderColumns = true;
            this.partsGridView.AllowUserToResizeColumns = false;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(5, 94);
            this.partsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.partsGridView.RowTemplate.Height = 24;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(683, 150);
            this.partsGridView.TabIndex = 3;
            // 
            // deletePartButton
            // 
            this.deletePartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deletePartButton.Location = new System.Drawing.Point(585, 361);
            this.deletePartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(93, 36);
            this.deletePartButton.TabIndex = 6;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = false;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.modifyPartButton.Location = new System.Drawing.Point(485, 361);
            this.modifyPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(93, 36);
            this.modifyPartButton.TabIndex = 5;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = false;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addPartButton.Location = new System.Drawing.Point(387, 361);
            this.addPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(93, 36);
            this.addPartButton.TabIndex = 4;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = false;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPartsButton.Location = new System.Drawing.Point(387, 9);
            this.searchPartsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(93, 36);
            this.searchPartsButton.TabIndex = 2;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = false;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // searchPartsText
            // 
            this.searchPartsText.Location = new System.Drawing.Point(485, 14);
            this.searchPartsText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(203, 27);
            this.searchPartsText.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Location = new System.Drawing.Point(1315, 571);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 36);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(InventoryManagementSystem.Model.Inventory);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1435, 633);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource inventoryBindingSource;
    }
}

