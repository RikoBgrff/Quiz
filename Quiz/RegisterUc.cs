using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Quiz
{
    public partial class RegisterUc : UserControl
    {
        public RegisterUc()
        {
            InitializeComponent();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameTxtBx.Text))
            {
                if (Helper.IsValid(EmailTxtBx.Text))
                {
                    if (!string.IsNullOrEmpty(PasswordTextBox.Text))
                    {
                        if (PasswordTextBox.Text == VerifyPasswordTxtBx.Text)
                        {
                            User user = new User
                            {
                                Email = EmailTxtBx.Text,
                                Username = UsernameTxtBx.Text,
                                Password = PasswordTextBox.Text
                            };
                            List<User> users = new List<User>();
                            users.Add(user);
                            JsonHelper.JsonSerialize(users);
                            MessageBox.Show("Registered Sucsessfully");
                           
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields");

                }
            }
        }
        public DialogResult ReturnOK()
        {
            return DialogResult.OK;
        }

        private void hidePasswordCb_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePasswordCb.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePasswordCb.Checked)
            {
                VerifyPasswordTxtBx.UseSystemPasswordChar = true;
            }
            else
            {
                VerifyPasswordTxtBx.UseSystemPasswordChar = false;
            }

        }
    }
}
