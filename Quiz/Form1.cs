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
    public partial class Quiz1 : Form
    {
        public Quiz1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginForm form = new LoginForm();
            //Hide();
            //form.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {

            Hide();
            Form3 form = new Form3();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }
            if (form.ShowDialog() != DialogResult.Cancel)
            {
                form.ShowDialog();
            }
            }
            catch (Exception)
            {

            
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
