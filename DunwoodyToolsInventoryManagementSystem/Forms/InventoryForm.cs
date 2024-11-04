using DunwoodyToolsInventoryManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            LoadInventoryDataDrid();

            comboBoxCategory.Items.Add("All");
            foreach (var category in FilterHelper.GetUniqueCategories()) { 
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



        public void LoadInventoryDataDrid() {
            Console.WriteLine("LoadInventoryDataGrid();");
            
            // Clear any already loaded columns
            inventoryGridView.Columns.Clear();

            DataTable iventoryDatatable = DatabaseHelper.GetItems();
            inventoryGridView.DataSource = iventoryDatatable;

            inventoryGridView.Columns["id"].HeaderText = "Item ID";
            inventoryGridView.Columns["id"].Visible = false;
            inventoryGridView.Columns["ItemName"].HeaderText = "Name";
            inventoryGridView.Columns["status_name"].HeaderText = "Status";

            inventoryGridView.ClearSelection();

            comboBoxCategory.SelectedIndexChanged += (s, e) => ApplyFilter();
            comboBoxStatus.SelectedIndexChanged += (s, e) => ApplyFilter();
            textBoxSearch.TextChanged += (s, e) => ApplyFilter();

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            inventoryGridView.ClearSelection();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid to avoid header clicks
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Console.WriteLine("click()");
            }
        }
        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            click(sender, e); // Handles cell content clicks
        }

        private void inventoryGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Manually create a DataGridViewCellEventArgs to pass to click
            var cellEventArgs = new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex);
            click(sender, cellEventArgs); // Handles mouse clicks
        }

        private void toolStripUnselectButton_Click_1(object sender, EventArgs e)
        {
            inventoryGridView.ClearSelection();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private string BuildFilterExpression()
        {
            var filterBuilder = new StringBuilder();

            // Check if SelectedItem is not null for Status ComboBox
            if (comboBoxStatus.SelectedItem != null)
            {
                string selectedStatus = comboBoxStatus.SelectedItem.ToString();
                if (selectedStatus != "All")
                {
                    filterBuilder.Append($"[status_name] = '{selectedStatus}'");
                }
            }

            // Check if SelectedItem is not null for Category ComboBox
            if (comboBoxCategory.SelectedItem != null)
            {
                string selectedCategory = comboBoxCategory.SelectedItem.ToString();
                if (selectedCategory != "All")
                {
                    if (filterBuilder.Length > 0) filterBuilder.Append(" AND ");
                    filterBuilder.Append($"[categories] LIKE '%{selectedCategory}%'");
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                string searchText = textBoxSearch.Text.Replace("'", "''"); // Escape single quotes in search text
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
            // Get the count of selected rows
            int selectedRowCount = inventoryGridView.SelectedRows.Count;

            // Update the label to show the selected row count
            counter.Text = $"{selectedRowCount}";
        }
    }
}
