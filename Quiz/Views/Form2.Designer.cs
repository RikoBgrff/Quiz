namespace Quiz
{
    partial class LoginForm
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.RegisterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginUc1 = new Quiz.LoginUc();
            this.registerUc1 = new Quiz.RegisterUc();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitBtn.Animated = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderThickness = 1;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(263, 7);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterBtn.Animated = true;
            this.RegisterBtn.AutoRoundedCorners = true;
            this.RegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.BorderRadius = 13;
            this.RegisterBtn.CheckedState.Parent = this.RegisterBtn;
            this.RegisterBtn.CustomImages.Parent = this.RegisterBtn;
            this.RegisterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.HoverState.Parent = this.RegisterBtn;
            this.RegisterBtn.Location = new System.Drawing.Point(61, 413);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.ShadowDecoration.Parent = this.RegisterBtn;
            this.RegisterBtn.Size = new System.Drawing.Size(168, 28);
            this.RegisterBtn.TabIndex = 23;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loginbtn.Animated = true;
            this.Loginbtn.AutoRoundedCorners = true;
            this.Loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Loginbtn.BorderRadius = 13;
            this.Loginbtn.CheckedState.Parent = this.Loginbtn;
            this.Loginbtn.CustomImages.Parent = this.Loginbtn;
            this.Loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.HoverState.Parent = this.Loginbtn;
            this.Loginbtn.Location = new System.Drawing.Point(61, 413);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.ShadowDecoration.Parent = this.Loginbtn;
            this.Loginbtn.Size = new System.Drawing.Size(168, 28);
            this.Loginbtn.TabIndex = 25;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.Visible = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click_1);
            // 
            // loginUc1
            // 
            this.loginUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.loginUc1.Location = new System.Drawing.Point(-5, -2);
            this.loginUc1.Name = "loginUc1";
            this.loginUc1.Size = new System.Drawing.Size(308, 502);
            this.loginUc1.TabIndex = 10;
            // 
            // registerUc1
            // 
            this.registerUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.registerUc1.Location = new System.Drawing.Point(-5, -2);
            this.registerUc1.Name = "registerUc1";
            this.registerUc1.Size = new System.Drawing.Size(308, 502);
            this.registerUc1.TabIndex = 24;
            this.registerUc1.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(301, 500);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.loginUc1);
            this.Controls.Add(this.registerUc1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private LoginUc loginUc1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private Guna.UI2.WinForms.Guna2Button RegisterBtn;
        private RegisterUc registerUc1;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
    }
}