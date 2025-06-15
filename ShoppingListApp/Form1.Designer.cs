namespace ShoppingListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadShoppingList;
        private System.Windows.Forms.ListBox listBoxShoppingList;
        private System.Windows.Forms.Button btnOpenForm2;

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
            this.btnLoadShoppingList = new System.Windows.Forms.Button();
            this.listBoxShoppingList = new System.Windows.Forms.ListBox();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadShoppingList
            // 
            this.btnLoadShoppingList.Location = new System.Drawing.Point(12, 12);
            this.btnLoadShoppingList.Name = "btnLoadShoppingList";
            this.btnLoadShoppingList.Size = new System.Drawing.Size(150, 40);
            this.btnLoadShoppingList.TabIndex = 0;
            this.btnLoadShoppingList.Text = "Load Shopping List";
            this.btnLoadShoppingList.UseVisualStyleBackColor = true;
            this.btnLoadShoppingList.Click += new System.EventHandler(this.btnLoadShoppingList_Click);
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.ItemHeight = 20;
            this.listBoxShoppingList.Location = new System.Drawing.Point(12, 58);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(350, 200);
            this.listBoxShoppingList.TabIndex = 1;
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(180, 12);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(150, 40);
            this.btnOpenForm2.TabIndex = 2;
            this.btnOpenForm2.Text = "Add Groceries";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.listBoxShoppingList);
            this.Controls.Add(this.btnLoadShoppingList);
            this.Name = "Form1";
            this.Text = "Shopping List Viewer";
            this.ResumeLayout(false);
        }
    }
}