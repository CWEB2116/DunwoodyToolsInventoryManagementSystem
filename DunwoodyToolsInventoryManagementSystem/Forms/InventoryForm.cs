using DunwoodyToolsInventoryManagementSystem.Forms;
using DunwoodyToolsInventoryManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem
{
    public partial class InventoryForm : Form
    {
        private PictureBox hoverPictureBox;
        private int defaultRowHeight = 60;
        private int expandedRowHeight = 200;

        public InventoryForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            LoadInventoryDataGrid();

            hoverPictureBox = new PictureBox
            {
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.Zoom,
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(hoverPictureBox);

            inventoryGridView.MouseMove += inventoryGridView_MouseMove;
            inventoryGridView.MouseLeave += inventoryGridView_MouseLeave;
            inventoryGridView.CellClick += inventoryGridView_CellClick;

            comboBoxCategory.Items.Add("All");
            foreach (var category in FilterHelper.GetUniqueCategories())
            {
                comboBoxCategory.Items.Add($"{category}");
            }

            comboBoxStatus.Items.Add("All");
            foreach (var status in FilterHelper.GetUniqueStatuses())
            {
                comboBoxStatus.Items.Add($"{status}");
            }

            comboBoxCategory.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
        }

        // Empty event handler for CellContentClick
        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add any code here if needed in the future
        }

        // Empty event handler for CellMouseClick
        private void inventoryGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Add any code here if needed in the future
        }


        private void inventoryGridView_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestInfo = inventoryGridView.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
            {
                var row = inventoryGridView.Rows[hitTestInfo.RowIndex];
                if (inventoryGridView.Columns.Contains("item_image"))
                {
                    var imageCell = row.Cells["item_image"];
                    if (imageCell.Value is byte[] imageData && imageData.Length > 0)
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                            hoverPictureBox.Image = Image.FromStream(ms);
                        }
                        hoverPictureBox.Location = new Point(e.X + 10, e.Y + 10);
                        hoverPictureBox.Visible = true;
                    }
                    else
                    {
                        hoverPictureBox.Visible = false;
                    }
                }
                else
                {
                    hoverPictureBox.Visible = false;
                }
            }
            else
            {
                hoverPictureBox.Visible = false;
            }
        }

        private void inventoryGridView_MouseLeave(object sender, EventArgs e)
        {
            hoverPictureBox.Visible = false;
        }

        public void LoadInventoryDataGrid()
        {
            Console.WriteLine("LoadInventoryDataGrid();");

            // Clear any existing columns to avoid duplicates
            inventoryGridView.Columns.Clear();

            // Load data from the database
            DataTable inventoryDataTable = DatabaseHelper.GetItems();
            inventoryGridView.DataSource = inventoryDataTable;

            // Set header texts and other properties
            inventoryGridView.Columns["id"].HeaderText = "Item ID";
            inventoryGridView.Columns["id"].Visible = false;
            inventoryGridView.Columns["ItemName"].HeaderText = "Name";
            inventoryGridView.Columns["status_name"].HeaderText = "Status";
            inventoryGridView.Columns["item_description"].HeaderText = "Description";

            // Configure image column if it's already in the data source
            if (inventoryGridView.Columns.Contains("item_image"))
            {
                var imageColumn = (DataGridViewImageColumn)inventoryGridView.Columns["item_image"];
                imageColumn.HeaderText = "Image";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            // Set default row height
            inventoryGridView.RowTemplate.Height = defaultRowHeight;

            // Clear selection
            inventoryGridView.ClearSelection();

            // Set up filter events
            comboBoxCategory.SelectedIndexChanged += (s, e) => ApplyFilter();
            comboBoxStatus.SelectedIndexChanged += (s, e) => ApplyFilter();
            textBoxSearch.TextChanged += (s, e) => ApplyFilter();
        }

        private void inventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure we're not clicking on the header row or outside a valid cell
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Get the row and toggle its height
            DataGridViewRow row = inventoryGridView.Rows[e.RowIndex];

            if (row.Height == defaultRowHeight)
            {
                // Expand the row
                row.Height = expandedRowHeight;

                // Check if there’s image data available in the DataTable (the underlying data source)
                if (row.Cells["item_image"].Value is byte[] imageData && imageData.Length > 0)
                {
                    using (var ms = new MemoryStream(imageData))
                    {
                        row.Cells["item_image"].Value = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                // Collapse the row back to its original height
                row.Height = defaultRowHeight;

                // Reset the cell to avoid broken images or red "X"
                //row.Cells["item_image"].Value = null;
            }
        }


        private void InventoryForm_Load(object sender, EventArgs e)
        {
            inventoryGridView.ClearSelection();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Console.WriteLine("click()");
            }
        }

        private void toolStripUnselectButton_Click_1(object sender, EventArgs e)
        {
            inventoryGridView.ClearSelection();
        }

        private string BuildFilterExpression()
        {
            var filterBuilder = new StringBuilder();
            if (comboBoxStatus.SelectedItem != null && comboBoxStatus.SelectedItem.ToString() != "All")
            {
                filterBuilder.Append($"[status_name] = '{comboBoxStatus.SelectedItem}'");
            }
            if (comboBoxCategory.SelectedItem != null && comboBoxCategory.SelectedItem.ToString() != "All")
            {
                if (filterBuilder.Length > 0) filterBuilder.Append(" AND ");
                filterBuilder.Append($"[categories] LIKE '%{comboBoxCategory.SelectedItem}%'");
            }
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                string searchText = textBoxSearch.Text.Replace("'", "''");
                if (filterBuilder.Length > 0) filterBuilder.Append(" AND ");
                filterBuilder.Append($"[ItemName] LIKE '%{searchText}%'");
            }
            return filterBuilder.ToString();
        }

        private void ApplyFilter()
        {
            var dataTable = (DataTable)inventoryGridView.DataSource;
            if (dataTable != null)
            {
                var dataView = dataTable.DefaultView;
                dataView.RowFilter = BuildFilterExpression();
            }
        }

        private void inventoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            counter.Text = $"{inventoryGridView.SelectedRows.Count}";
        }

        private void AddItem()
        {
            ItemForm itemForm = new ItemForm();
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                DatabaseHelper.AddItem(itemForm.ItemName, itemForm.Status, itemForm.Description, itemForm.ImageData, itemForm.SelectedCategories);
                LoadInventoryDataGrid();
            }
        }

        private void EditItem()
        {
            if (inventoryGridView.SelectedRows.Count > 0)
            {
                var row = inventoryGridView.SelectedRows[0];
                int itemId = (int)row.Cells["id"].Value;
                var itemForm = new ItemForm(
                    row.Cells["ItemName"].Value.ToString(),
                    row.Cells["status_name"].Value.ToString(),
                    DatabaseHelper.GetCategoriesForItem(itemId),
                    row.Cells["item_description"].Value.ToString(),
                    row.Cells["item_image"].Value as byte[]
                );

                if (itemForm.ShowDialog() == DialogResult.OK)
                {
                    DatabaseHelper.UpdateItem(itemId, itemForm.ItemName, itemForm.Status, itemForm.Description, itemForm.ImageData, itemForm.SelectedCategories);
                    LoadInventoryDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void DeleteItem()
        {
            if (inventoryGridView.SelectedRows.Count > 0)
            {
                int itemId = (int)inventoryGridView.SelectedRows[0].Cells["id"].Value;
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteItem(itemId);
                    LoadInventoryDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void toolStripAddButton_Click(object sender, EventArgs e) => AddItem();
        private void toolStripEditButton_Click(object sender, EventArgs e) => EditItem();
        private void toolStripDeleteButton_Click(object sender, EventArgs e) => DeleteItem();
    }
}
