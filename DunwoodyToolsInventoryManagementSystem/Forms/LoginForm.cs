﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using DunwoodyToolsInventoryManagementSystem.Helpers;

namespace DunwoodyToolsInventoryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        String username;
        String password;
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - loginPanel.Width) / 2;
            int y = (this.ClientSize.Height - loginPanel.Height) / 2;
            loginPanel.Location = new Point(x, y);
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA512.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterPanel(); // Center the panel when the form loads
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterPanel(); // Center the panel on resize event
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login button pressed");

            if (inputUsername.Text == "")
            {
                Console.WriteLine("Username empty!");
                MessageBox.Show("Please enter a username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                username = inputUsername.Text;
                Console.WriteLine(username);

                if (inputPassword.Text == "")
                {
                    Console.WriteLine("Password empty!");
                    MessageBox.Show("Please enter a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    password = inputPassword.Text;
                    Console.WriteLine(password);
                    Console.WriteLine(GetHashString(password));

                    if (!DatabaseHelper.CheckLoginCredentials(username, GetHashString(password)))
                    {
                        MessageBox.Show("Either this account doesn't exist, or the provided credentials are incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else { 
                        this.Hide();
                        InventoryForm inventoryForm = new InventoryForm();
                        inventoryForm.Show();
                    }

                    
                }
            }
        }
    }
}
