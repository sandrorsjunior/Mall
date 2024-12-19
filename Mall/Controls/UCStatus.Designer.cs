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
            listView1 = new ListView();
            GPFilters = new GroupBox();
            InputTextFilter = new TextBox();
            RdStok = new RadioButton();
            BtnSearch = new Button();
            Id = new ColumnHeader();
            ProductName = new ColumnHeader();
            Decription = new ColumnHeader();
            Quantite = new ColumnHeader();
            ProductValue = new ColumnHeader();
            DateCreated = new ColumnHeader();
            ByUser = new ColumnHeader();
            GPFilters.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, ProductName, Decription, ProductValue, Quantite, DateCreated, ByUser });
            listView1.GridLines = true;
            listView1.Location = new Point(36, 88);
            listView1.Name = "listView1";
            listView1.Size = new Size(708, 289);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // GPFilters
            // 
            GPFilters.Controls.Add(BtnSearch);
            GPFilters.Controls.Add(RdStok);
            GPFilters.Controls.Add(InputTextFilter);
            GPFilters.Location = new Point(36, 3);
            GPFilters.Name = "GPFilters";
            GPFilters.Size = new Size(411, 79);
            GPFilters.TabIndex = 1;
            GPFilters.TabStop = false;
            GPFilters.Text = "Filters";
            // 
            // InputTextFilter
            // 
            InputTextFilter.Location = new Point(6, 33);
            InputTextFilter.Name = "InputTextFilter";
            InputTextFilter.Size = new Size(219, 23);
            InputTextFilter.TabIndex = 0;
            // 
            // RdStok
            // 
            RdStok.AutoSize = true;
            RdStok.Location = new Point(242, 34);
            RdStok.Name = "RdStok";
            RdStok.Size = new Size(61, 19);
            RdStok.TabIndex = 1;
            RdStok.TabStop = true;
            RdStok.Text = "In Stok";
            RdStok.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(330, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 59);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
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
            // Quantite
            // 
            Quantite.DisplayIndex = 3;
            Quantite.Text = "QTD";
            // 
            // ProductValue
            // 
            ProductValue.DisplayIndex = 4;
            ProductValue.Text = "Value";
            ProductValue.Width = 80;
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
            Controls.Add(GPFilters);
            Controls.Add(listView1);
            Name = "UCStatus";
            Size = new Size(778, 393);
            GPFilters.ResumeLayout(false);
            GPFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox GPFilters;
        private RadioButton RdStok;
        private TextBox InputTextFilter;
        private Button BtnSearch;
        private ColumnHeader Id;
        private ColumnHeader ProductName;
        private ColumnHeader Decription;
        private ColumnHeader ProductValue;
        private ColumnHeader Quantite;
        private ColumnHeader DateCreated;
        private ColumnHeader ByUser;
    }
}
