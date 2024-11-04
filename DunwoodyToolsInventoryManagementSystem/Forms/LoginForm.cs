using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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
        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
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
            }
            else {
                username = inputUsername.Text;
                Console.WriteLine(username);

                if (inputPassword.Text == "")
                {
                    Console.WriteLine("Password empty!");
                }
                else { 
                    password = EncodePasswordToBase64(password);
                    Console.WriteLine(password);
                }
            }
        }
    }
}
