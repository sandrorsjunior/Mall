using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mall.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mall.Controls
{
    public partial class UCProductManeger : UserControl
    {
        List<ListViewItem> newProducts = new List<ListViewItem>();
        public UCProductManeger()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProductModel product = this.factoryProductModel();
            ListViewItem newItem = new ListViewItem(product.getAllAttrLikeStringArry());
            newProducts.Add(newItem);
            this.insertItemsInListView();
            this.clearFields();
        }

        private void clearFields()
        {
            InputProduct.Clear();
            InputValue.Clear();
            InputDescription.Clear();
            InputQuantite.Value = 0;
        }

        private void insertItemsInListView()
        {
            listView.Items.Clear();
            long index_id = 0;
            foreach (var item in newProducts)
            {

                item.SubItems[0].Text = index_id.ToString();
                listView.Items.Add(item);
                index_id++;
            }

        }

        private ProductModel factoryProductModel()
        {
            ProductModel productModel = new ProductModel();
            productModel.name = InputProduct.Text;
            productModel.value = float.Parse(InputValue.Text);
            productModel.description = InputDescription.Text;
            productModel.quantite = (int)InputQuantite.Value;
            productModel.id = -1;
            return productModel;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int inindexRemove = InputRemove.Text == "" ? newProducts.Count()-1 : int.Parse(InputRemove.Text);
            newProducts.Remove(newProducts[inindexRemove]);
            this.insertItemsInListView();
            InputRemove.Clear();
        }
    }
}
