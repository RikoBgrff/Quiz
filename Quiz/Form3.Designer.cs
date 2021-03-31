namespace Quiz
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ReturnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.questionUc1 = new Quiz.QuestionUc();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimationInterval = 0;
            this.BorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm.ContainerControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(468, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(38, 31);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "X";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Animated = true;
            this.ReturnBtn.AutoRoundedCorners = true;
            this.ReturnBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.ReturnBtn.BorderRadius = 14;
            this.ReturnBtn.BorderThickness = 1;
            this.ReturnBtn.CheckedState.Parent = this.ReturnBtn;
            this.ReturnBtn.CustomImages.Parent = this.ReturnBtn;
            this.ReturnBtn.FillColor = System.Drawing.Color.Transparent;
            this.ReturnBtn.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBtn.HoverState.Parent = this.ReturnBtn;
            this.ReturnBtn.Location = new System.Drawing.Point(417, 201);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.ShadowDecoration.Parent = this.ReturnBtn;
            this.ReturnBtn.Size = new System.Drawing.Size(79, 30);
            this.ReturnBtn.TabIndex = 19;
            this.ReturnBtn.Text = "Return";
            this.toolTip1.SetToolTip(this.ReturnBtn, "Returns previous menu");
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // questionUc1
            // 
            this.questionUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.questionUc1.Location = new System.Drawing.Point(1, 1);
            this.questionUc1.Name = "questionUc1";
            this.questionUc1.Size = new System.Drawing.Size(516, 255);
            this.questionUc1.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(518, 254);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.questionUc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
       //private QuestionUc questionUc1;
        private Guna.UI2.WinForms.Guna2Button ReturnBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private QuestionUc questionUc1;
    }
}