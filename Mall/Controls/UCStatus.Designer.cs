namespace Mall.Controls
{
    partial class UCStatus
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
            listViewStatus = new ListView();
            Id = new ColumnHeader();
            ProductName = new ColumnHeader();
            Decription = new ColumnHeader();
            ProductValue = new ColumnHeader();
            Quantite = new ColumnHeader();
            DateCreated = new ColumnHeader();
            ByUser = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewStatus
            // 
            listViewStatus.Columns.AddRange(new ColumnHeader[] { Id, ProductName, Decription, ProductValue, Quantite, DateCreated, ByUser });
            listViewStatus.GridLines = true;
            listViewStatus.Location = new Point(36, 20);
            listViewStatus.Name = "listViewStatus";
            listViewStatus.Size = new Size(708, 357);
            listViewStatus.TabIndex = 0;
            listViewStatus.UseCompatibleStateImageBehavior = false;
            listViewStatus.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            // 
            // ProductName
            // 
            ProductName.Text = "PRODUCT";
            ProductName.Width = 120;
            // 
            // Decription
            // 
            Decription.Text = "DESCRIPTION";
            Decription.Width = 200;
            // 
            // ProductValue
            // 
            ProductValue.Text = "Value";
            ProductValue.Width = 80;
            // 
            // Quantite
            // 
            Quantite.Text = "QTD";
            // 
            // DateCreated
            // 
            DateCreated.Text = "Created";
            DateCreated.Width = 120;
            // 
            // ByUser
            // 
            ByUser.Text = "BY";
            ByUser.Width = 120;
            // 
            // UCStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewStatus);
            Name = "UCStatus";
            Size = new Size(778, 393);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewStatus;
        private ColumnHeader Id;
        private ColumnHeader ProductName;
        private ColumnHeader Decription;
        private ColumnHeader ProductValue;
        private ColumnHeader Quantite;
        private ColumnHeader DateCreated;
        private ColumnHeader ByUser;
    }
}
