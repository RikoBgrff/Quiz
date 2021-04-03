using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using Quiz.Properties;

namespace Quiz
{
    public partial class DragDropUc : UserControl
    {
        public int id = 0;
        public DragDropUc()
        {
            InitializeComponent();
        }

    List<QuestionBlock> questions = new List<QuestionBlock>();
    private void DragDropUc_DragDrop(object sender, DragEventArgs e)
        {

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
            this.BackgroundImage = null;
            deserializeableUc1.Visible = true;
            foreach (var item in XmlHelper.Deserialize(filePath, questions))
            {
                deserializeableUc1.QuestionTxtBx.Text = item.Text;
                foreach (var item2 in item.Answers)
                {
                    if (item2.id == 0)
                    {
                        deserializeableUc1.vATxtBx.Text = item2.Text;
                        if (item2.IsCorrect == "Yes")
                        {
                            deserializeableUc1.vARbtn.Checked = true;
                        }
                    }
                    if (item2.id == 1)
                    {
                        deserializeableUc1.vBTxtBx.Text = item2.Text;
                        if (item2.IsCorrect == "Yes")
                        {
                            deserializeableUc1.vBRbtn.Checked = true;
                        }
                    }
                    if (item2.id == 2)
                    {
                        deserializeableUc1.vCTxtBx.Text = item2.Text;
                        if (item2.IsCorrect == "Yes")
                        {
                            deserializeableUc1.vCRbtn.Checked = true;
                        }
                    }
                    if (item2.id == 3)
                    {
                        deserializeableUc1.vDTxtBx.Text = item2.Text;
                        if (item2.IsCorrect == "Yes")
                        {
                            deserializeableUc1.vDRbtn.Checked = true;
                        }
                    }
                }
            }
        }
    private void DragDropUc_Load(object sender, EventArgs e)
    {
        this.AllowDrop = true;
    }
    private void DragDropUc_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.All;

    }
    private void NextBtn_Click(object sender, EventArgs e)
    {
        id++;
    }
}
}
