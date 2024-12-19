namespace Mall.Forms
{
    partial class MainForm
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
            TopMenuPanel = new Panel();
            MainPanel = new Panel();
            BtnLogin = new Button();
            BtnUserManeger = new Button();
            BtnProduct = new Button();
            button4 = new Button();
            TopMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenuPanel
            // 
            TopMenuPanel.BorderStyle = BorderStyle.FixedSingle;
            TopMenuPanel.Controls.Add(button4);
            TopMenuPanel.Controls.Add(BtnProduct);
            TopMenuPanel.Controls.Add(BtnUserManeger);
            TopMenuPanel.Controls.Add(BtnLogin);
            TopMenuPanel.Location = new Point(3, 0);
            TopMenuPanel.Name = "TopMenuPanel";
            TopMenuPanel.Size = new Size(778, 58);
            TopMenuPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(3, 64);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(778, 393);
            MainPanel.TabIndex = 1;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(8, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(90, 50);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnUserManeger
            // 
            BtnUserManeger.Location = new Point(104, 3);
            BtnUserManeger.Name = "BtnUserManeger";
            BtnUserManeger.Size = new Size(90, 50);
            BtnUserManeger.TabIndex = 1;
            BtnUserManeger.Text = "USER";
            BtnUserManeger.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.Location = new Point(200, 3);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(90, 50);
            BtnProduct.TabIndex = 2;
            BtnProduct.Text = "PRODUCT";
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(296, 3);
            button4.Name = "button4";
            button4.Size = new Size(90, 50);
            button4.TabIndex = 3;
            button4.Text = "STATUS";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(MainPanel);
            Controls.Add(TopMenuPanel);
            Name = "MainForm";
            Text = "MainForm";
            TopMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopMenuPanel;
        private Panel MainPanel;
        private Button button4;
        private Button BtnProduct;
        private Button BtnUserManeger;
        private Button BtnLogin;
    }
}