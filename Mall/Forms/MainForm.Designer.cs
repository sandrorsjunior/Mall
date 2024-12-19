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
            SuspendLayout();
            // 
            // TopMenuPanel
            // 
            TopMenuPanel.BorderStyle = BorderStyle.FixedSingle;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(MainPanel);
            Controls.Add(TopMenuPanel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel TopMenuPanel;
        private Panel MainPanel;
    }
}