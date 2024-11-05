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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dCT_ToolsDataSet1.category_tbl' table. You can move, or remove it, as needed.
            this.category_tblTableAdapter.Fill(this.dCT_ToolsDataSet1.category_tbl);

        }
    }
}
