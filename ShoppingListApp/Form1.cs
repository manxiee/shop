using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // method to read data from a json file
        private List<string> ReadJsonFromFile(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(jsonContent);
        }

        // button to load the shopping list from a json file
        private void btnLoadShoppingList_Click(object sender, EventArgs e)
        {
            try
            {
                // open a file dialog to select the json file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON files (*.json)|*.json",
                    Title = "Open Shopping List JSON"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Read the shopping list from the json file
                    var shoppingList = ReadJsonFromFile(filePath);

                    // the shopping list in the ListBox
                    listBoxShoppingList.Items.Clear();
                    foreach (var item in shoppingList)
                    {
                        listBoxShoppingList.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shopping list:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button to open Form2 for adding grocery
        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}