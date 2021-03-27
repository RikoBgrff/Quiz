using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Question : UserControl
    {
        bool checked1 = false;
        public Question()
        {
            InitializeComponent();
        }
        private void variantARadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            checked1 = true;
        }

        private void variantBRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            checked1 = true;

        }

        private void variantCRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            checked1 = true;

        }

        private void variantDRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            checked1 = true;

        }
        public void CheckCredentials()
        {
            if (String.IsNullOrEmpty(SubjectTexbox.Text))
            {
                MessageBox.Show("Subject not filled");
            }
            if (String.IsNullOrEmpty(QuestionTextBox.Text))
            {
                MessageBox.Show("Subject not filled");
            }
            //||checked1 == false )
            //{
            //    || String.IsNullOrEmpty(QuestionTextBox.Text) || String.IsNullOrEmpty(variantATextBox.Text) || String.IsNullOrEmpty(variantBTextBox.Text) || String.IsNullOrEmpty(variantCTextBox.Text) || String.IsNullOrEmpty(variantDTextBox.Text)
            //    MessageBox.Show("Test");
            //}
        }
    }
}
