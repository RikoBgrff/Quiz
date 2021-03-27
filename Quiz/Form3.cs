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
    public partial class Form3 : Form
    {
        bool clicked = false;
        public Form3()
        {
            InitializeComponent();
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditByDraggingBtn_Click(object sender, EventArgs e)
        {
            NewExamPanel.Visible = false;
            EditingRichTxtbx.Location = new Point(26, 126);
            EditingRichTxtbx.Size = new Size(750, 239);
            EditingRichTxtbx.Visible = true;
        }

        private void CreateNewExamBtn_Click(object sender, EventArgs e)
        {
            EditingRichTxtbx.Visible = false;
            NewExamPanel.Visible = true;
            Question question1 = new Question();
            question1.Anchor = System.Windows.Forms.AnchorStyles.None;
            question1.BackColor = System.Drawing.Color.MediumSlateBlue;
            question1.Location = new System.Drawing.Point(3, 19);
            question1.Name = "question1";
            question1.Size = new System.Drawing.Size(393, 420);
            question1.TabIndex = 6;
            this.NewExamPanel.Controls.Add(question1);
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
