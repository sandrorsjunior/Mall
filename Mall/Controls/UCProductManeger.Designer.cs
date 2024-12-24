namespace Mall.Controls
{
    partial class UCProductManeger
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
            listView = new ListView();
            Id = new ColumnHeader();
            ProductName = new ColumnHeader();
            Description = new ColumnHeader();
            ProductValue = new ColumnHeader();
            Quantite = new ColumnHeader();
            InputProduct = new TextBox();
            InputDescription = new TextBox();
            InputValue = new TextBox();
            labeProduct = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAdd = new Button();
            label5 = new Label();
            InputRemove = new TextBox();
            BtnRemove = new Button();
            BtnClear = new Button();
            BtnSend = new Button();
            InputQuantite = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)InputQuantite).BeginInit();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { Id, ProductName, Description, ProductValue, Quantite });
            listView.GridLines = true;
            listView.Location = new Point(27, 14);
            listView.Name = "listView";
            listView.Size = new Size(732, 187);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            // 
            // ProductName
            // 
            ProductName.DisplayIndex = 2;
            ProductName.Text = "PRODUCT";
            ProductName.Width = 180;
            // 
            // Description
            // 
            Description.DisplayIndex = 1;
            Description.Text = "DESCRIPTION";
            Description.Width = 250;
            // 
            // ProductValue
            // 
            ProductValue.Text = "VALUE";
            ProductValue.Width = 120;
            // 
            // Quantite
            // 
            Quantite.Text = "QUANTITE";
            Quantite.Width = 100;
            // 
            // InputProduct
            // 
            InputProduct.Location = new Point(159, 206);
            InputProduct.Name = "InputProduct";
            InputProduct.Size = new Size(211, 23);
            InputProduct.TabIndex = 1;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(159, 235);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.Size = new Size(211, 71);
            InputDescription.TabIndex = 2;
            // 
            // InputValue
            // 
            InputValue.Location = new Point(159, 312);
            InputValue.Name = "InputValue";
            InputValue.Size = new Size(211, 23);
            InputValue.TabIndex = 3;
            // 
            // labeProduct
            // 
            labeProduct.AutoSize = true;
            labeProduct.Location = new Point(104, 209);
            labeProduct.Name = "labeProduct";
            labeProduct.Size = new Size(49, 15);
            labeProduct.TabIndex = 5;
            labeProduct.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 247);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Decription";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 315);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 348);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantite";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(471, 247);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(204, 23);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 209);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // InputRemove
            // 
            InputRemove.Location = new Point(510, 206);
            InputRemove.Name = "InputRemove";
            InputRemove.Size = new Size(100, 23);
            InputRemove.TabIndex = 11;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(616, 205);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(59, 23);
            BtnRemove.TabIndex = 12;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(471, 307);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(209, 23);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnSend
            // 
            BtnSend.Location = new Point(471, 344);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(209, 23);
            BtnSend.TabIndex = 14;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // InputQuantite
            // 
            InputQuantite.Location = new Point(159, 346);
            InputQuantite.Name = "InputQuantite";
            InputQuantite.Size = new Size(211, 23);
            InputQuantite.TabIndex = 15;
            // 
            // UCProductManeger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputQuantite);
            Controls.Add(BtnSend);
            Controls.Add(BtnClear);
            Controls.Add(BtnRemove);
            Controls.Add(InputRemove);
            Controls.Add(label5);
            Controls.Add(BtnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labeProduct);
            Controls.Add(InputValue);
            Controls.Add(InputDescription);
            Controls.Add(InputProduct);
            Controls.Add(listView);
            Name = "UCProductManeger";
            Size = new Size(778, 393);
            ((System.ComponentModel.ISupportInitialize)InputQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private TextBox InputProduct;
        private TextBox InputDescription;
        private TextBox InputValue;
        private Label labeProduct;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAdd;
        private Label label5;
        private TextBox InputRemove;
        private Button BtnRemove;
        private Button BtnClear;
        private Button BtnSend;
        private NumericUpDown InputQuantite;
        private ColumnHeader Id;
        private ColumnHeader Description;
        private ColumnHeader ProductName;
        private ColumnHeader ProductValue;
        private ColumnHeader Quantite;
    }
}
