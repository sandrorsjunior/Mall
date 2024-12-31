namespace Mall.Controls
{
    partial class UCLogin
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
            InputPassWord = new TextBox();
            InputUser = new TextBox();
            BtnEnter = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InputPassWord
            // 
            InputPassWord.Location = new Point(211, 220);
            InputPassWord.Name = "InputPassWord";
            InputPassWord.PlaceholderText = "Insert The Pass Word";
            InputPassWord.Size = new Size(330, 23);
            InputPassWord.TabIndex = 0;
            InputPassWord.UseSystemPasswordChar = true;
            // 
            // InputUser
            // 
            InputUser.Location = new Point(211, 172);
            InputUser.Name = "InputUser";
            InputUser.PlaceholderText = "Insert The User Name";
            InputUser.Size = new Size(330, 23);
            InputUser.TabIndex = 1;
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new Point(300, 292);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(147, 33);
            BtnEnter.TabIndex = 2;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(331, 262);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.brand;
            pictureBox1.Location = new Point(318, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(BtnEnter);
            Controls.Add(InputUser);
            Controls.Add(InputPassWord);
            Name = "UCLogin";
            Size = new Size(778, 393);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputPassWord;
        private TextBox InputUser;
        private Button BtnEnter;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
