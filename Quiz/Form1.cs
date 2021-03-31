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
        Timer timer = new Timer();
        public Quiz1()
        {
            LoginForm form = new LoginForm();
            Hide();
            form.ShowDialog();
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                }
                InitializeComponent();
                timer.Tick += Timer_Tick;
                timer.Interval = 500;
                timer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongDateString();
            TimeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DateLbl.Visible = false;
            TimeLbl.Visible = false;
            CreatePanel.Visible = true;
            EditPanel.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
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

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {

                Hide();
                Form5 form2 = new Form5();
                if (form2.ShowDialog() == DialogResult.Cancel)
                {
                    Show();
                }
                if (form2.ShowDialog() != DialogResult.Cancel)
                {
                    form2.ShowDialog();
                }
            }
            catch (Exception)
            {


            }


        }
    }
}
