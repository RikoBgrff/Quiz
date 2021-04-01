using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Guna.UI2.WinForms;

namespace Quiz
{
    public partial class LoginUc : UserControl
    {
        public LoginUc()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            List<User> users = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader("users.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<List<User>>(jr);
                }
            }
            try
            {
                foreach (var item in users)
                {
                    if (UsernameTextBox.Text == item.Username)
                    {
                        if (PasswordTextBox.Text == item.Password)
                        {
                            Quiz1 form = new Quiz1();
                            form.ShowDialog();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowPasswordImageBtn_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            var showPassword = (Guna2ImageButton)sender;

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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
