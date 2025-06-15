using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // method to save the grocery list 
        private void SaveGroceryListToJson(string filePath, List<string> groceryList)
        {
            string jsonContent = JsonSerializer.Serialize(groceryList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonContent);
        }

        // nutton to add an item 
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // validate input
            string item = txtGroceryItem.Text.Trim();
            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Please enter a valid grocery item.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check if the list already contains 5 items
            if (listBoxGroceries.Items.Count >= 5)
            {
                MessageBox.Show("You can only add a maximum of 5 items to the grocery list.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // add the item to the ListBox
            listBoxGroceries.Items.Add(item);

            // clear the TextBox for the next input
            txtGroceryItem.Clear();
            txtGroceryItem.Focus();
        }

        // button to save the grocery list to a JSON file
        private void btnSaveList_Click(object sender, EventArgs e)
        {
            try
            {
                // collect items from the ListBox
                var groceryList = new List<string>();
                foreach (var item in listBoxGroceries.Items)
                {
                    groceryList.Add(item.ToString());
                }

                // open a Save file dialog to choose the file path
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json",
                    Title = "Save Grocery List as JSON"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // save the grocery list to the selected file
                    string filePath = saveFileDialog.FileName;
                    SaveGroceryListToJson(filePath, groceryList);

                    MessageBox.Show("Grocery list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving grocery list:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}