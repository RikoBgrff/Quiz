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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowPasswordImageBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.OR = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RegisterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Quiz.Properties.Resources.whiteTransparentDiamond;
            this.pictureBox1.Location = new System.Drawing.Point(108, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Animated = true;
            this.UsernameTextBox.AutoRoundedCorners = true;
            this.UsernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.BorderRadius = 17;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.DisabledState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.UsernameTextBox.FocusedState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.HoverState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.Location = new System.Drawing.Point(21, 128);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameTextBox.PlaceholderText = "Username or email";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.UsernameTextBox.ShadowDecoration.Parent = this.UsernameTextBox;
            this.UsernameTextBox.Size = new System.Drawing.Size(246, 36);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Animated = true;
            this.PasswordTextBox.AutoRoundedCorners = true;
            this.PasswordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.BorderRadius = 17;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.PasswordTextBox.FocusedState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.HoverState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Location = new System.Drawing.Point(21, 175);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 36);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // ShowPasswordImageBtn
            // 
            this.ShowPasswordImageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordImageBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ShowPasswordImageBtn.CheckedState.Parent = this.ShowPasswordImageBtn;
            this.ShowPasswordImageBtn.HoverState.Image = global::Quiz.Properties.Resources.whiteTransparentDiamond;
            this.ShowPasswordImageBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.ShowPasswordImageBtn.HoverState.Parent = this.ShowPasswordImageBtn;
            this.ShowPasswordImageBtn.Image = global::Quiz.Properties.Resources.whiteTransparentDiamond;
            this.ShowPasswordImageBtn.ImageRotate = 0F;
            this.ShowPasswordImageBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ShowPasswordImageBtn.Location = new System.Drawing.Point(211, 166);
            this.ShowPasswordImageBtn.Name = "ShowPasswordImageBtn";
            this.ShowPasswordImageBtn.PressedState.Image = global::Quiz.Properties.Resources.whiteTransparentDiamond;
            this.ShowPasswordImageBtn.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ShowPasswordImageBtn.PressedState.Parent = this.ShowPasswordImageBtn;
            this.ShowPasswordImageBtn.Size = new System.Drawing.Size(64, 54);
            this.ShowPasswordImageBtn.TabIndex = 3;
            this.ShowPasswordImageBtn.UseTransparentBackground = true;
            this.ShowPasswordImageBtn.Click += new System.EventHandler(this.ShowPasswordImageBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.Animated = true;
            this.LoginBtn.AutoRoundedCorners = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 13;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(58, 237);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(168, 28);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.Location = new System.Drawing.Point(160, 327);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(105, 1);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel2.Location = new System.Drawing.Point(24, 327);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(105, 1);
            this.guna2Panel2.TabIndex = 6;
            // 
            // OR
            // 
            this.OR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OR.BackColor = System.Drawing.Color.Transparent;
            this.OR.ForeColor = System.Drawing.Color.White;
            this.OR.Location = new System.Drawing.Point(135, 319);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(19, 15);
            this.OR.TabIndex = 7;
            this.OR.Text = "OR";
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
            this.RegisterBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.HoverState.Parent = this.RegisterBtn;
            this.RegisterBtn.Location = new System.Drawing.Point(58, 406);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.ShadowDecoration.Parent = this.RegisterBtn;
            this.RegisterBtn.Size = new System.Drawing.Size(168, 28);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitBtn.Animated = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderThickness = 1;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.DarkCyan;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(301, 500);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.OR);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ShowPasswordImageBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton ShowPasswordImageBtn;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button RegisterBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel OR;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
    }
}