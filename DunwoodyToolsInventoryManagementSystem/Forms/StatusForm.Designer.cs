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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.sidenavControl1 = new DunwoodyToolsInventoryManagementSystem.Controls.SidenavControl();
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
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidenavControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatusForm";
            this.Text = "Dunwoody Tools Inventory Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SidenavControl sidenavControl1;
    }
}