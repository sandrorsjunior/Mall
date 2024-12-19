namespace Mall.Controls
{
    partial class UCUserManager
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
            LWUser = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            Birthday = new ColumnHeader();
            Role = new ColumnHeader();
            InputName = new TextBox();
            InputEmail = new TextBox();
            InputBirthday = new TextBox();
            InputRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAdd = new Button();
            BtnRemove = new Button();
            label5 = new Label();
            InputIdRemove = new TextBox();
            BtnClear = new Button();
            BtnSend = new Button();
            SuspendLayout();
            // 
            // LWUser
            // 
            LWUser.Columns.AddRange(new ColumnHeader[] { Id, Name, Email, Birthday, Role });
            LWUser.GridLines = true;
            LWUser.Location = new Point(18, 13);
            LWUser.Name = "LWUser";
            LWUser.Size = new Size(732, 187);
            LWUser.TabIndex = 0;
            LWUser.UseCompatibleStateImageBehavior = false;
            LWUser.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            // 
            // Name
            // 
            Name.Text = "NAME";
            Name.Width = 200;
            // 
            // Email
            // 
            Email.Text = "EMAIL";
            Email.Width = 200;
            // 
            // Birthday
            // 
            Birthday.Text = "BIRTHDAY";
            Birthday.Width = 180;
            // 
            // Role
            // 
            Role.Text = "ROLE";
            // 
            // InputName
            // 
            InputName.ImeMode = ImeMode.Disable;
            InputName.Location = new Point(159, 206);
            InputName.Name = "InputName";
            InputName.Size = new Size(188, 23);
            InputName.TabIndex = 1;
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(159, 244);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(188, 23);
            InputEmail.TabIndex = 2;
            // 
            // InputBirthday
            // 
            InputBirthday.Location = new Point(159, 283);
            InputBirthday.Name = "InputBirthday";
            InputBirthday.Size = new Size(188, 23);
            InputBirthday.TabIndex = 3;
            // 
            // InputRole
            // 
            InputRole.Location = new Point(159, 321);
            InputRole.Name = "InputRole";
            InputRole.Size = new Size(188, 23);
            InputRole.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 209);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 247);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 286);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 324);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(159, 358);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(584, 206);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(59, 23);
            BtnRemove.TabIndex = 10;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 209);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 11;
            label5.Text = "ID";
            label5.Click += label5_Click;
            // 
            // InputIdRemove
            // 
            InputIdRemove.Location = new Point(478, 206);
            InputIdRemove.Name = "InputIdRemove";
            InputIdRemove.Size = new Size(100, 23);
            InputIdRemove.TabIndex = 12;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(434, 264);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(209, 23);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnSend
            // 
            BtnSend.Location = new Point(434, 306);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(209, 23);
            BtnSend.TabIndex = 14;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            // 
            // UCUserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnSend);
            Controls.Add(BtnClear);
            Controls.Add(InputIdRemove);
            Controls.Add(label5);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputRole);
            Controls.Add(InputBirthday);
            Controls.Add(InputEmail);
            Controls.Add(InputName);
            Controls.Add(LWUser);
            Name = "UCUserManager";
            Size = new Size(778, 393);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LWUser;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader Email;
        private ColumnHeader Birthday;
        private ColumnHeader Role;
        private TextBox InputName;
        private TextBox InputEmail;
        private TextBox InputBirthday;
        private TextBox InputRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAdd;
        private Button BtnRemove;
        private Label label5;
        private TextBox InputIdRemove;
        private Button BtnClear;
        private Button BtnSend;
    }
}
