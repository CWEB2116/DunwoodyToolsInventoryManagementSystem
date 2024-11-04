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
        }



        public void LoadInventoryDataDrid() {
            Console.WriteLine("LoadInventoryDataGrid();");
            
            // Clear any already loaded columns
            inventoryGridView.Columns.Clear();

            DataTable iventoryDatatable = DatabaseHelper.GetItems();
            inventoryGridView.DataSource = iventoryDatatable;

            inventoryGridView.Columns["id"].HeaderText = "Item ID";
            inventoryGridView.Columns["ItemName"].HeaderText = "Name";
            inventoryGridView.Columns["status_name"].HeaderText = "Status";

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

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

    }
}
