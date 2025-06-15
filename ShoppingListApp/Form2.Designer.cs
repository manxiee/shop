namespace ShoppingListApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtGroceryItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox listBoxGroceries;
        private System.Windows.Forms.Button btnSaveList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtGroceryItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.listBoxGroceries = new System.Windows.Forms.ListBox();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGroceryItem
            // 
            this.txtGroceryItem.Location = new System.Drawing.Point(12, 12);
            this.txtGroceryItem.Name = "txtGroceryItem";
            this.txtGroceryItem.Size = new System.Drawing.Size(200, 26);
            this.txtGroceryItem.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(220, 12);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 30);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // listBoxGroceries
            // 
            this.listBoxGroceries.FormattingEnabled = true;
            this.listBoxGroceries.ItemHeight = 20;
            this.listBoxGroceries.Location = new System.Drawing.Point(12, 50);
            this.listBoxGroceries.Name = "listBoxGroceries";
            this.listBoxGroceries.Size = new System.Drawing.Size(308, 144);
            this.listBoxGroceries.TabIndex = 2;
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(12, 210);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(100, 30);
            this.btnSaveList.TabIndex = 3;
            this.btnSaveList.Text = "Save List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.listBoxGroceries);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtGroceryItem);
            this.Name = "Form2";
            this.Text = "Add Grocery Items";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}