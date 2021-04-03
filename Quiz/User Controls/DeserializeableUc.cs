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
    public partial class DeserializeableUc : UserControl
    {
        public int id = 0;
        public DeserializeableUc()
        {
            InitializeComponent();
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {

        }
        public void ClearAll()
        {
            QuestionTxtBx.Text = string.Empty;
            vATxtBx.Text = string.Empty;
            vBTxtBx.Text = string.Empty;
            vCTxtBx.Text = string.Empty;
            vDTxtBx.Text = string.Empty;
            vARbtn.Checked = false;
            vBRbtn.Checked = false;
            vCRbtn.Checked = false;
            vDRbtn.Checked = false;
        }
        public void NextBtn_Click(object sender, EventArgs e)
        {

            Quiz1.Instance.Counter++;
            Quiz1.Instance.question1 = Quiz1.Instance.Questions[Quiz1.Instance.Counter];
            //ClearAll();
            
           
        }
        public DeserializeableUc CreateNewUc()
        {
            var userControl = new DeserializeableUc() { Dock = DockStyle.Top };
            return userControl;
        }
        public void LoadQuestion()
        {

        }

        private void DeserializeableUc_Load(object sender, EventArgs e)
        {

        }
    }
}
