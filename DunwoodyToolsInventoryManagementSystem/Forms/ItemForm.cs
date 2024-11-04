using DunwoodyToolsInventoryManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem.Forms
{
    public partial class ItemForm : Form
    {
        public string ItemName { get; set; }
        public string Status { get; set; }
        public List<string> SelectedCategories { get; set; } = new List<string>();
        public string Description { get; set; }
        public byte[] ImageData { get; set; }

        public ItemForm(string itemName = "", string status = "", List<string> selectedCategories = null, string description = "", byte[] imageData = null)
        {
            InitializeComponent();

            // Set initial values for editing or default for adding
            ItemName = itemName;
            Status = status;
            SelectedCategories = selectedCategories ?? new List<string>();
            Description = description;
            ImageData = imageData;

            // Populate form fields with initial values
            inputItemName.Text = ItemName;
            inputItemDescription.Text = Description;

            // Load statuses and categories into ComboBox and CheckedListBox
            LoadStatuses();
            LoadCategories();

            // Set the initial image if provided
            if (ImageData != null)
            {
                using (var ms = new MemoryStream(ImageData))
                {
                    itemPictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void LoadStatuses()
        {
            var statuses = DatabaseHelper.GetStatuses(); // Method to fetch statuses from the database
            inputItemStatus.Items.Clear();
            foreach (var status in statuses)
            {
                inputItemStatus.Items.Add(status);
            }

            // Set the initial status selection if editing
            if (!string.IsNullOrEmpty(Status))
            {
                inputItemStatus.SelectedItem = Status;
            }
        }

        private void LoadCategories()
        {
            var allCategories = FilterHelper.GetUniqueCategories(); // Method to fetch categories from the database
            foreach (var category in allCategories)
            {
                int index = inputItemCategory.Items.Add(category);
                if (SelectedCategories.Contains(category))
                {
                    inputItemCategory.SetItemChecked(index, true); // Check item if it is in SelectedCategories
                }
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            // Update properties with the new values
            ItemName = inputItemName.Text;
            Status = inputItemStatus.SelectedItem?.ToString();
            Description = inputItemDescription.Text;

            // Collect selected categories
            SelectedCategories = inputItemCategory.CheckedItems.Cast<string>().ToList();

            // Convert image to byte array
            if (itemPictureBox.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    itemPictureBox.Image.Save(ms, itemPictureBox.Image.RawFormat);
                    ImageData = ms.ToArray();
                }
            }

            // Set dialog result to OK to indicate a successful operation
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            // Set dialog result to Cancel if the user cancels
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectImage_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    itemPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void Item_Load(object sender, EventArgs e)
        {
            // Additional initialization, if needed
        }
    }
}
