namespace Quiz
{
    partial class Form4
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
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FileNameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderColor = System.Drawing.Color.White;
            this.CancelBtn.BorderRadius = 14;
            this.CancelBtn.BorderThickness = 1;
            this.CancelBtn.CheckedState.Parent = this.CancelBtn;
            this.CancelBtn.CustomImages.Parent = this.CancelBtn;
            this.CancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Font = new System.Drawing.Font("Raleway", 11F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.HoverState.Parent = this.CancelBtn;
            this.CancelBtn.Location = new System.Drawing.Point(122, 105);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.ShadowDecoration.Parent = this.CancelBtn;
            this.CancelBtn.Size = new System.Drawing.Size(81, 30);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Animated = true;
            this.OkBtn.AutoRoundedCorners = true;
            this.OkBtn.BackColor = System.Drawing.Color.Transparent;
            this.OkBtn.BorderColor = System.Drawing.Color.White;
            this.OkBtn.BorderRadius = 14;
            this.OkBtn.BorderThickness = 1;
            this.OkBtn.CheckedState.Parent = this.OkBtn;
            this.OkBtn.CustomImages.Parent = this.OkBtn;
            this.OkBtn.FillColor = System.Drawing.Color.Transparent;
            this.OkBtn.Font = new System.Drawing.Font("Raleway", 11F);
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.HoverState.Parent = this.OkBtn;
            this.OkBtn.Location = new System.Drawing.Point(3, 105);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.ShadowDecoration.Parent = this.OkBtn;
            this.OkBtn.Size = new System.Drawing.Size(81, 30);
            this.OkBtn.TabIndex = 29;
            this.OkBtn.Text = "OK";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click_1);
            // 
            // FileNameTxtbx
            // 
            this.FileNameTxtbx.Animated = true;
            this.FileNameTxtbx.AutoRoundedCorners = true;
            this.FileNameTxtbx.BorderRadius = 17;
            this.FileNameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileNameTxtbx.DefaultText = "";
            this.FileNameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileNameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileNameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameTxtbx.DisabledState.Parent = this.FileNameTxtbx;
            this.FileNameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameTxtbx.FocusedState.Parent = this.FileNameTxtbx;
            this.FileNameTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileNameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameTxtbx.HoverState.Parent = this.FileNameTxtbx;
            this.FileNameTxtbx.Location = new System.Drawing.Point(3, 52);
            this.FileNameTxtbx.Name = "FileNameTxtbx";
            this.FileNameTxtbx.PasswordChar = '\0';
            this.FileNameTxtbx.PlaceholderText = "";
            this.FileNameTxtbx.SelectedText = "";
            this.FileNameTxtbx.ShadowDecoration.Parent = this.FileNameTxtbx;
            this.FileNameTxtbx.Size = new System.Drawing.Size(200, 36);
            this.FileNameTxtbx.TabIndex = 28;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Font = new System.Drawing.Font("Nova Classic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLbl.ForeColor = System.Drawing.Color.White;
            this.SubjectLbl.Location = new System.Drawing.Point(45, 12);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(120, 30);
            this.SubjectLbl.TabIndex = 31;
            this.SubjectLbl.Text = "File Name:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(212, 150);
            this.Controls.Add(this.SubjectLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.FileNameTxtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Guna.UI2.WinForms.Guna2Button CancelBtn;
        protected internal Guna.UI2.WinForms.Guna2Button OkBtn;
        protected internal Guna.UI2.WinForms.Guna2TextBox FileNameTxtbx;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label SubjectLbl;
    }
}