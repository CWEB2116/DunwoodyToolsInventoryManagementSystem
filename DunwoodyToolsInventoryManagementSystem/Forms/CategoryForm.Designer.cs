namespace DunwoodyToolsInventoryManagementSystem
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.sidenavControl1 = new DunwoodyToolsInventoryManagementSystem.Controls.SidenavControl();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.dCT_ToolsDataSet = new DunwoodyToolsInventoryManagementSystem.DCT_ToolsDataSet();
            this.dCT_ToolsDataSet1 = new DunwoodyToolsInventoryManagementSystem.DCT_ToolsDataSet1();
            this.categorytblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_tblTableAdapter = new DunwoodyToolsInventoryManagementSystem.DCT_ToolsDataSet1TableAdapters.category_tblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorytblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidenavControl1
            // 
            this.sidenavControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.sidenavControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidenavControl1.Location = new System.Drawing.Point(0, 0);
            this.sidenavControl1.Name = "sidenavControl1";
            this.sidenavControl1.Size = new System.Drawing.Size(180, 450);
            this.sidenavControl1.TabIndex = 0;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AutoGenerateColumns = false;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn});
            this.dataGridViewCategory.DataSource = this.categorytblBindingSource;
            this.dataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategory.Location = new System.Drawing.Point(180, 0);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(620, 450);
            this.dataGridViewCategory.TabIndex = 1;
            // 
            // dCT_ToolsDataSet
            // 
            this.dCT_ToolsDataSet.DataSetName = "DCT_ToolsDataSet";
            this.dCT_ToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dCT_ToolsDataSet1
            // 
            this.dCT_ToolsDataSet1.DataSetName = "DCT_ToolsDataSet1";
            this.dCT_ToolsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorytblBindingSource
            // 
            this.categorytblBindingSource.DataMember = "category_tbl";
            this.categorytblBindingSource.DataSource = this.dCT_ToolsDataSet1;
            // 
            // category_tblTableAdapter
            // 
            this.category_tblTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "category_name";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.Width = 125;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.sidenavControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoryForm";
            this.Text = "Dunwoody Tools Inventory Management System";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorytblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SidenavControl sidenavControl1;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private DCT_ToolsDataSet dCT_ToolsDataSet;
        private DCT_ToolsDataSet1 dCT_ToolsDataSet1;
        private System.Windows.Forms.BindingSource categorytblBindingSource;
        private DCT_ToolsDataSet1TableAdapters.category_tblTableAdapter category_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
    }
}