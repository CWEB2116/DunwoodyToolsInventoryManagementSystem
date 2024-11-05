namespace DunwoodyToolsInventoryManagementSystem
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.sidenavControl1 = new DunwoodyToolsInventoryManagementSystem.Controls.SidenavControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dCT_ToolsDataSet = new DunwoodyToolsInventoryManagementSystem.DCT_ToolsDataSet();
            this.statustblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_tblTableAdapter = new DunwoodyToolsInventoryManagementSystem.DCT_ToolsDataSetTableAdapters.status_tblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statustblBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.statusnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statustblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(180, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // dCT_ToolsDataSet
            // 
            this.dCT_ToolsDataSet.DataSetName = "DCT_ToolsDataSet";
            this.dCT_ToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statustblBindingSource
            // 
            this.statustblBindingSource.DataMember = "status_tbl";
            this.statustblBindingSource.DataSource = this.dCT_ToolsDataSet;
            // 
            // status_tblTableAdapter
            // 
            this.status_tblTableAdapter.ClearBeforeFill = true;
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
            // statusnameDataGridViewTextBoxColumn
            // 
            this.statusnameDataGridViewTextBoxColumn.DataPropertyName = "status_name";
            this.statusnameDataGridViewTextBoxColumn.HeaderText = "status_name";
            this.statusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusnameDataGridViewTextBoxColumn.Name = "statusnameDataGridViewTextBoxColumn";
            this.statusnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sidenavControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatusForm";
            this.Text = "Dunwoody Tools Inventory Management System";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCT_ToolsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statustblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SidenavControl sidenavControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DCT_ToolsDataSet dCT_ToolsDataSet;
        private System.Windows.Forms.BindingSource statustblBindingSource;
        private DCT_ToolsDataSetTableAdapters.status_tblTableAdapter status_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusnameDataGridViewTextBoxColumn;
    }
}