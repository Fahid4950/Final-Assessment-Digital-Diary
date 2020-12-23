using Final_Assessment_Digital_Diary.Business_Logic_Leyar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assessment_Digital_Diary.Presentation_Leyar
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void LoginUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(usernameTextBox.Text, PasswordText.Text);
                if (result)
                {

                    Form1 form1 = new Form1();

                    form1.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
