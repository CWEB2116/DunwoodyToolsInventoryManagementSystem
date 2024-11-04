using System.Drawing;

namespace DunwoodyToolsInventoryManagementSystem.Controls
{
    partial class SidenavControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidenavItemsButton = new System.Windows.Forms.Button();
            this.sidenavCategoriesButton = new System.Windows.Forms.Button();
            this.sidenavStatusesButton = new System.Windows.Forms.Button();
            this.sidenavLogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DunwoodyToolsInventoryManagementSystem.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sidenavItemsButton
            // 
            this.sidenavItemsButton.FlatAppearance.BorderSize = 0;
            this.sidenavItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidenavItemsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidenavItemsButton.ForeColor = System.Drawing.Color.Snow;
            this.sidenavItemsButton.Location = new System.Drawing.Point(3, 119);
            this.sidenavItemsButton.Name = "sidenavItemsButton";
            this.sidenavItemsButton.Size = new System.Drawing.Size(174, 38);
            this.sidenavItemsButton.TabIndex = 1;
            this.sidenavItemsButton.Text = "ITEMS";
            this.sidenavItemsButton.UseVisualStyleBackColor = true;
            this.sidenavItemsButton.Click += new System.EventHandler(this.sidenavItemsButton_Click);
            // 
            // sidenavCategoriesButton
            // 
            this.sidenavCategoriesButton.FlatAppearance.BorderSize = 0;
            this.sidenavCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidenavCategoriesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidenavCategoriesButton.ForeColor = System.Drawing.Color.Snow;
            this.sidenavCategoriesButton.Location = new System.Drawing.Point(3, 163);
            this.sidenavCategoriesButton.Name = "sidenavCategoriesButton";
            this.sidenavCategoriesButton.Size = new System.Drawing.Size(174, 38);
            this.sidenavCategoriesButton.TabIndex = 2;
            this.sidenavCategoriesButton.Text = "CATEGORIES";
            this.sidenavCategoriesButton.UseVisualStyleBackColor = true;
            this.sidenavCategoriesButton.Click += new System.EventHandler(this.sidenavCategoriesButton_Click);
            // 
            // sidenavStatusesButton
            // 
            this.sidenavStatusesButton.FlatAppearance.BorderSize = 0;
            this.sidenavStatusesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidenavStatusesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidenavStatusesButton.ForeColor = System.Drawing.Color.Snow;
            this.sidenavStatusesButton.Location = new System.Drawing.Point(3, 207);
            this.sidenavStatusesButton.Name = "sidenavStatusesButton";
            this.sidenavStatusesButton.Size = new System.Drawing.Size(174, 38);
            this.sidenavStatusesButton.TabIndex = 3;
            this.sidenavStatusesButton.Text = "STATUSES";
            this.sidenavStatusesButton.UseVisualStyleBackColor = true;
            this.sidenavStatusesButton.Click += new System.EventHandler(this.sidenavStatusesButton_Click);
            // 
            // sidenavLogoutButton
            // 
            this.sidenavLogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidenavLogoutButton.FlatAppearance.BorderSize = 0;
            this.sidenavLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidenavLogoutButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidenavLogoutButton.ForeColor = System.Drawing.Color.Snow;
            this.sidenavLogoutButton.Location = new System.Drawing.Point(0, 545);
            this.sidenavLogoutButton.Name = "sidenavLogoutButton";
            this.sidenavLogoutButton.Size = new System.Drawing.Size(180, 38);
            this.sidenavLogoutButton.TabIndex = 4;
            this.sidenavLogoutButton.Text = "LOGOUT";
            this.sidenavLogoutButton.UseVisualStyleBackColor = true;
            this.sidenavLogoutButton.Click += new System.EventHandler(this.sidenavLogoutButton_Click);
            // 
            // SidenavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.sidenavLogoutButton);
            this.Controls.Add(this.sidenavStatusesButton);
            this.Controls.Add(this.sidenavCategoriesButton);
            this.Controls.Add(this.sidenavItemsButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SidenavControl";
            this.Size = new System.Drawing.Size(180, 583);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sidenavItemsButton;
        private System.Windows.Forms.Button sidenavCategoriesButton;
        private System.Windows.Forms.Button sidenavStatusesButton;
        private System.Windows.Forms.Button sidenavLogoutButton;
    }
}
