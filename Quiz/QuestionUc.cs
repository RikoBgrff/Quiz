using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Quiz
{
    public partial class QuestionUc : UserControl
    {
        public List<QuestionBlock> questions = new List<QuestionBlock>();
        int ID = 0;
        public QuestionUc()
        {
            InitializeComponent();
        }
        public string CheckTrueAnswer(Guna2RadioButton rbtn)
        {
            if (rbtn.Checked)
            {
                return "Yes";
            }
            return "No";
        }
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        public void ClearAllFields()
        {
            vARbtn.Checked = false;
            vBRbtn.Checked = false;
            vCRbtn.Checked = false;
            vDRbtn.Checked = false;
            QuestionTxtBx.Text = String.Empty;
            vATxtBx.Text = String.Empty;
            vBTxtBx.Text = String.Empty;
            vCTxtBx.Text = String.Empty;
            vDTxtBx.Text = String.Empty;

        }
        public bool CheckFields()
        {
            if (String.IsNullOrEmpty(QuestionTxtBx.Text))
            {
                MessageBox.Show("Question is not filled");
                return false;
            }
            if (string.IsNullOrEmpty(vATxtBx.Text))
            {
                MessageBox.Show("Answer 1 is not filled");
                return false;

            }
            if (string.IsNullOrEmpty(vBTxtBx.Text))
            {
                MessageBox.Show("Answer 2 is not filled");
                return false;

            }
            if (string.IsNullOrEmpty(vCTxtBx.Text))
            {
                MessageBox.Show("Answer 3 is not filled");
                return false;

            }
            if (string.IsNullOrEmpty(vDTxtBx.Text))
            {
                MessageBox.Show("Answer 4 is not filled");
                return false;
            }
            if (vARbtn.Checked == false && vBRbtn.Checked == false && vCRbtn.Checked == false && vDRbtn.Checked == false)
            {
                MessageBox.Show("Correct Answer is not selected");
                return false;
            }
            return true;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                ID++;
                QuestionBlock question = new QuestionBlock
                {
                    Text = QuestionTxtBx.Text,
                    id = ID
                };
                Answer a = new Answer
                {
                    id = 0,
                    IsCorrect = CheckTrueAnswer(vARbtn),
                    Text = vATxtBx.Text
                };
                Answer b = new Answer
                {
                    id = 1,
                    IsCorrect = CheckTrueAnswer(vBRbtn),
                    Text = vBTxtBx.Text
                };
                Answer c = new Answer
                {
                    id = 2,
                    IsCorrect = CheckTrueAnswer(vCRbtn),
                    Text = vCTxtBx.Text
                };
                Answer d = new Answer
                {
                    id = 3,
                    IsCorrect = CheckTrueAnswer(vDRbtn),
                    Text = vDTxtBx.Text
                };
                question.Answers.Add(a);
                question.Answers.Add(b);
                question.Answers.Add(c);
                question.Answers.Add(d);
                questions.Add(question);
                MessageBox.Show("Question Sucsessfully added to list");
                ClearAllFields();
                SaveBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fill Fields");
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                XmlHelper helper = new XmlHelper();
                if (string.IsNullOrEmpty(form.FileNameTxtbx.Text))
                {
                    string file = DateTime.Now.ToLongDateString();
                    helper.Serialize(file, questions);
                }
                helper.Serialize(form.FileNameTxtbx.Text, questions);
                MessageBox.Show("Quiz Created Sucsessfully");
            }

        }

        private void QuestionUc_Load(object sender, EventArgs e)
        {
        }

        private void vDRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
