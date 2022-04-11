using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TradeNowLibrary;

namespace TradeNow
{
    public partial class LoginForm : MaterialForm
    {
        int count = 0;
        public IOrderWriterService orderWriterService;

        public LoginForm()
        {
        }
        public LoginForm(IOrderWriterService orderWriterService)
        {
            this.orderWriterService = orderWriterService;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '\u25CF';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user, password;
            user = "Admin";
            password = "admin";

            if (usernameTextbox.Text == user && passwordTextbox.Text == password)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                TradeOrder main = new TradeOrder(orderWriterService);
                main.Show();
            }
            else
            {
                count++;
                int maxcount = 3;
                int remain;    
                remain = maxcount - count;
                MessageBox.Show("Invalid Username or Password!" + "Attempts remaining: " + remain);
                usernameTextbox.Clear();
                passwordTextbox.Clear();    
                usernameTextbox.Focus();
                if(remain == 0)
                {
                    MessageBox.Show("Too many attempts!");
                    Application.Exit();
                }
            }
        }

    }
}
