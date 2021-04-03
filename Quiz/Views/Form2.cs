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
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
                  
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterBtn.Visible = false;
            Loginbtn.Visible = true;
            registerUc1.Visible = true;
            loginUc1.Visible = false;
        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            registerUc1.Visible = false;
            RegisterBtn.Visible = true;
            loginUc1.Visible = true;
            Loginbtn.Visible = false;
        }
    }
}