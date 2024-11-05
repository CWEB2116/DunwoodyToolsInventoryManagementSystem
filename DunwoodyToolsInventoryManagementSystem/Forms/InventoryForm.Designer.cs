namespace DunwoodyToolsInventoryManagementSystem
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.dataSet1 = new System.Data.DataSet();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUnselectButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.counter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidenavControl1 = new DunwoodyToolsInventoryManagementSystem.Controls.SidenavControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.AllowUserToDeleteRows = false;
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryGridView.Location = new System.Drawing.Point(180, 89);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.ReadOnly = true;
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryGridView.Size = new System.Drawing.Size(620, 361);
            this.inventoryGridView.TabIndex = 1;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            this.inventoryGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inventoryGridView_CellMouseClick);
            this.inventoryGridView.SelectionChanged += new System.EventHandler(this.inventoryGridView_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddButton,
            this.toolStripEditButton,
            this.toolStripDeleteButton,
            this.toolStripViewButton,
            this.toolStripSeparator1,
            this.toolStripUnselectButton});
            this.toolStrip1.Location = new System.Drawing.Point(180, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddButton
            // 
            this.toolStripAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddButton.Image = global::DunwoodyToolsInventoryManagementSystem.Properties.Resources.add;
            this.toolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddButton.Name = "toolStripAddButton";
            this.toolStripAddButton.Size = new System.Drawing.Size(29, 24);
            this.toolStripAddButton.Text = "Add";
            this.toolStripAddButton.Click += new System.EventHandler(this.toolStripAddButton_Click);
            // 
            // toolStripEditButton
            // 
            this.toolStripEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditButton.Image = global::DunwoodyToolsInventoryManagementSystem.Properties.Resources.edit;
            this.toolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditButton.Name = "toolStripEditButton";
            this.toolStripEditButton.Size = new System.Drawing.Size(29, 24);
            this.toolStripEditButton.Text = "Edit";
            this.toolStripEditButton.Click += new System.EventHandler(this.toolStripEditButton_Click);
            // 
            // toolStripDeleteButton
            // 
            this.toolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteButton.Image = global::DunwoodyToolsInventoryManagementSystem.Properties.Resources.bin;
            this.toolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteButton.Name = "toolStripDeleteButton";
            this.toolStripDeleteButton.Size = new System.Drawing.Size(29, 24);
            this.toolStripDeleteButton.Text = "Delete";
            this.toolStripDeleteButton.Click += new System.EventHandler(this.toolStripDeleteButton_Click);
            // 
            // toolStripViewButton
            // 
            this.toolStripViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripViewButton.Image = global::DunwoodyToolsInventoryManagementSystem.Properties.Resources.info;
            this.toolStripViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripViewButton.Name = "toolStripViewButton";
            this.toolStripViewButton.Size = new System.Drawing.Size(29, 24);
            this.toolStripViewButton.Text = "View";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripUnselectButton
            // 
            this.toolStripUnselectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripUnselectButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnselectButton.Image")));
            this.toolStripUnselectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnselectButton.Name = "toolStripUnselectButton";
            this.toolStripUnselectButton.Size = new System.Drawing.Size(91, 24);
            this.toolStripUnselectButton.Text = "Unselect All";
            this.toolStripUnselectButton.Click += new System.EventHandler(this.toolStripUnselectButton_Click_1);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 32);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.counter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(180, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(533, 38);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(44, 16);
            this.counter.TabIndex = 11;
            this.counter.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selected Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(284, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(180, 22);
            this.textBoxSearch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(133, 32);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
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
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sidenavControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.Text = "Dunwoody Tools Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SidenavControl sidenavControl1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddButton;
        private System.Windows.Forms.ToolStripButton toolStripEditButton;
        private System.Windows.Forms.ToolStripButton toolStripDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripUnselectButton;
        private System.Windows.Forms.ToolStripButton toolStripViewButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label counter;
    }
}

