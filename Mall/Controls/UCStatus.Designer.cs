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
            Decription = new ColumnHeader();
            ProductName = new ColumnHeader();
            ProductValue = new ColumnHeader();
            Quantite = new ColumnHeader();
            DateCreated = new ColumnHeader();
            ByUser = new ColumnHeader();
            GPFilters = new GroupBox();
            BtnSearch = new Button();
            RdStok = new RadioButton();
            InputTextFilter = new TextBox();
            GPFilters.SuspendLayout();
            SuspendLayout();
            // 
            // listViewStatus
            // 
            listViewStatus.Columns.AddRange(new ColumnHeader[] { Id, ProductName, Decription, ProductValue, Quantite, DateCreated, ByUser });
            listViewStatus.GridLines = true;
            listViewStatus.Location = new Point(36, 88);
            listViewStatus.Name = "listViewStatus";
            listViewStatus.Size = new Size(708, 289);
            listViewStatus.TabIndex = 0;
            listViewStatus.UseCompatibleStateImageBehavior = false;
            listViewStatus.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            // 
            // Decription
            // 
            Decription.Text = "DESCRIPTION";
            Decription.Width = 200;
            // 
            // ProductName
            // 
            ProductName.Text = "PRODUCT";
            ProductName.Width = 120;
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
            // BtnSearch
            // 
            BtnSearch.Location = new Point(330, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 59);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
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
            // InputTextFilter
            // 
            InputTextFilter.Location = new Point(6, 33);
            InputTextFilter.Name = "InputTextFilter";
            InputTextFilter.Size = new Size(219, 23);
            InputTextFilter.TabIndex = 0;
            // 
            // UCStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GPFilters);
            Controls.Add(listViewStatus);
            Name = "UCStatus";
            Size = new Size(778, 393);
            GPFilters.ResumeLayout(false);
            GPFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewStatus;
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
