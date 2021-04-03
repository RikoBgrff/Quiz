using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Quiz.Properties;
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
        public DeserializeableUc question1 = new DeserializeableUc();
        // int trick = 0;
        Timer timer = new Timer();
        Guna2PictureBox pictureBox = new Guna2PictureBox();
        public List<DeserializeableUc> Questions = new List<DeserializeableUc>();
        public int Counter = 0;
        private static Quiz1 obj;
        public static Quiz1 Instance = obj ?? (obj = new Quiz1());
        public Quiz1()
        {

            try
            {
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
            //trick = 1;
            //if (trick <= 1)
            //{
            //    LoginForm form = new LoginForm();
            //    Hide();
            //    form.ShowDialog();
            //}
            //if (trick > 1)
            //{

            //}
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

        List<QuestionBlock> questions = new List<QuestionBlock>();
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            CreatePanel.Visible = false;
            pictureBox.Location = new Point(198, 129);
            pictureBox.Visible = true;
            pictureBox.Image = Resources.xml1000;
            editPanel2.Controls.Add(pictureBox);
            editPanel2.AllowDrop = true;

            //try
            //{

            //    //Hide();
            //    //Form5 form2 = new Form5();
            //    //if (form2.ShowDialog() == DialogResult.Cancel)
            //    //{
            //    //    Show();
            //    //}
            //    //if (form2.ShowDialog() != DialogResult.Cancel)
            //    //{
            //    //    form2.ShowDialog();
            //    //}
            //}
            //catch (Exception)
            //{


            //}


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreatePanel.Visible = false;
            EditPanel.Visible = false;
            DateLbl.Visible = true;
            TimeLbl.Visible = true;
        }
        private void editPanel2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox.Visible = false;
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileNames.Length != 1)
            {
                MessageBox.Show("Drag only files", "Drag and drop", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var filePath = fileNames[0];
            if (!filePath.EndsWith(".xml"))

            {
                MessageBox.Show("XML files are supported only", "Drag and drop", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }
            //editPanel2.Controls.Add(question1);
            this.BackgroundImage = null;
            question1.Visible = true;
            EditPanel.Visible = false;
            CreatePanel.Visible = false;
            var list = XmlHelper.Deserialize(filePath, questions);
            //var array = list.ToArray();
            //foreach (var item in array)
            //{
            //    if(item.id == question1.id)
            //    {
            //        ShowData(item.id, array);
            //    }

            //}

            foreach (var item in list)
            {
                DeserializeableUc deserializeableUc = new DeserializeableUc();
                deserializeableUc.QuestionTxtBx.Text = item.Text;
                editPanel2.Controls.Add(deserializeableUc);

                foreach (var answer in item.Answers)
                {
                    switch (answer.id)
                    {
                        case 0:
                            {
                                deserializeableUc.vATxtBx.Text = answer.Text;
                                break;
                            }
                        case 1:
                            {
                                deserializeableUc.vBTxtBx.Text = answer.Text;
                                break;

                            }
                        case 2:
                            {

                                deserializeableUc.vCTxtBx.Text = answer.Text;
                                break;
                            }
                        case 3:
                            {
                                deserializeableUc.vDTxtBx.Text = answer.Text;
                                break;
                            }
                    }
                    Questions.Add(deserializeableUc);

                }
            }

        }


        //public void ShowData(int id, QuestionBlock[] array)
        //{
        //    var answerArray = array[id].Answers.ToArray();
        //    question1.QuestionTxtBx.Text = array[id].Text;
        //    question1.vATxtBx.Text = answerArray[0].Text;
        //    question1.vBTxtBx.Text = answerArray[1].Text;
        //    question1.vCTxtBx.Text = answerArray[2].Text;
        //    question1.vDTxtBx.Text = answerArray[3].Text;
        //}

        private void editPanel2_DragEnter(object sender, DragEventArgs e)
        {
            pictureBox.Visible = false;
            e.Effect = DragDropEffects.All;
        }
    }
}
