using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem.Controls
{
    public partial class SidenavControl : UserControl
    {
        public SidenavControl()
        {
            InitializeComponent();
        }

        private void sidenavItemsButton_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            Point point = parentForm.Location;
            Console.WriteLine("Items Button pressed in "+parentForm.Name);
            parentForm.Hide();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.StartPosition = FormStartPosition.Manual;
            inventoryForm.Location = point;
            inventoryForm.Show();
        }

        private void sidenavCategoriesButton_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            Point point = parentForm.Location;
            Console.WriteLine("Categories Button pressed in "+parentForm.Name);
            parentForm.Hide();
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.StartPosition = FormStartPosition.Manual;
            categoryForm.Location = point;
            categoryForm.Show();
        }

        private void sidenavStatusesButton_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            Point point = parentForm.Location;
            Console.WriteLine("Statuses Button pressed in " + parentForm.Name);
            parentForm.Hide();
            StatusForm statusForm = new StatusForm();
            statusForm.StartPosition = FormStartPosition.Manual;
            statusForm.Location = point;
            statusForm.Show();
        }

        private void sidenavLogoutButton_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            Console.WriteLine("Logout Button pressed in " + parentForm.Name);
            parentForm.Hide();
        }
    }
}
