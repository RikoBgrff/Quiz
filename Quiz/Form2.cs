using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void ShowPasswordImageBtn_Click(object sender, EventArgs e)
        {
            //evde internetden bax duzelt
            PasswordTextBox.Text = PasswordTextBox.Text;
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Quiz1 form = new Quiz1();
            form.Dispose();
        }
    }
}
