namespace Quiz
{
    partial class DragDropUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deserializeableUc1 = new Quiz.DeserializeableUc();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // deserializeableUc1
            // 
            this.deserializeableUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.deserializeableUc1.Location = new System.Drawing.Point(3, 0);
            this.deserializeableUc1.Name = "deserializeableUc1";
            this.deserializeableUc1.Size = new System.Drawing.Size(576, 345);
            this.deserializeableUc1.TabIndex = 0;
            this.deserializeableUc1.Visible = false;
            // 
            // NextBtn
            // 
            this.NextBtn.Animated = true;
            this.NextBtn.AutoRoundedCorners = true;
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.NextBtn.BorderRadius = 14;
            this.NextBtn.BorderThickness = 1;
            this.NextBtn.CheckedState.Parent = this.NextBtn;
            this.NextBtn.CustomImages.Parent = this.NextBtn;
            this.NextBtn.FillColor = System.Drawing.Color.Transparent;
            this.NextBtn.Font = new System.Drawing.Font("Raleway", 11F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.HoverState.Parent = this.NextBtn;
            this.NextBtn.Location = new System.Drawing.Point(473, 222);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.ShadowDecoration.Parent = this.NextBtn;
            this.NextBtn.Size = new System.Drawing.Size(75, 30);
            this.NextBtn.TabIndex = 29;
            this.NextBtn.Text = "Next";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // DragDropUc
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.BackgroundImage = global::Quiz.Properties.Resources.xml1000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.deserializeableUc1);
            this.DoubleBuffered = true;
            this.Name = "DragDropUc";
            this.Size = new System.Drawing.Size(579, 345);
            this.Load += new System.EventHandler(this.DragDropUc_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropUc_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropUc_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private DeserializeableUc deserializeableUc1;
        protected internal Guna.UI2.WinForms.Guna2Button NextBtn;
    }
}
