using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterPanel(); // Center the panel when the form loads
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login button pressed");
        }
    }
}
