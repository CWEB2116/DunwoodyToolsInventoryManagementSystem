namespace DunwoodyToolsInventoryManagementSystem.Forms
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inputItemName = new System.Windows.Forms.TextBox();
            this.inputItemDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputItemStatus = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputItemCategory = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // inputItemName
            // 
            this.inputItemName.Location = new System.Drawing.Point(172, 197);
            this.inputItemName.Name = "inputItemName";
            this.inputItemName.Size = new System.Drawing.Size(169, 22);
            this.inputItemName.TabIndex = 1;
            // 
            // inputItemDescription
            // 
            this.inputItemDescription.Location = new System.Drawing.Point(172, 250);
            this.inputItemDescription.Name = "inputItemDescription";
            this.inputItemDescription.Size = new System.Drawing.Size(169, 22);
            this.inputItemDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(143, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESCRIPTION";
            // 
            // inputItemStatus
            // 
            this.inputItemStatus.FormattingEnabled = true;
            this.inputItemStatus.ItemHeight = 16;
            this.inputItemStatus.Location = new System.Drawing.Point(172, 300);
            this.inputItemStatus.Name = "inputItemStatus";
            this.inputItemStatus.Size = new System.Drawing.Size(169, 20);
            this.inputItemStatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(143, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "STATUS";
            // 
            // inputItemCategory
            // 
            this.inputItemCategory.AllowDrop = true;
            this.inputItemCategory.FormattingEnabled = true;
            this.inputItemCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputItemCategory.Location = new System.Drawing.Point(363, 197);
            this.inputItemCategory.Name = "inputItemCategory";
            this.inputItemCategory.Size = new System.Drawing.Size(194, 123);
            this.inputItemCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(347, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "CATEGORY";
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(565, 439);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 42);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "SUBMIT";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(565, 487);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 42);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(256, 338);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(202, 23);
            this.btnSelectImage.TabIndex = 10;
            this.btnSelectImage.Text = "Add Picture";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click_1);
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(396, 60);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(100, 50);
            this.itemPictureBox.TabIndex = 11;
            this.itemPictureBox.TabStop = false;
            this.itemPictureBox.Visible = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(698, 541);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputItemCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputItemStatus);
            this.Controls.Add(this.inputItemDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputItemName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputItemName;
        private System.Windows.Forms.TextBox inputItemDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox inputItemStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox inputItemCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox itemPictureBox;
    }
}