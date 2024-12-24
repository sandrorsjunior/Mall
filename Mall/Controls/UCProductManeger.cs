using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mall.ApiConnection;
using Mall.ApiConnection.DTO;
using Mall.Models;

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
            int inindexRemove = InputRemove.Text == "" ? newProducts.Count() - 1 : int.Parse(InputRemove.Text);
            newProducts.Remove(newProducts[inindexRemove]);
            this.insertItemsInListView();
            InputRemove.Clear();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            List<ProductDTO> content = new List<ProductDTO>();

            foreach (var item in newProducts)
            {
                var productDTO = new ProductDTO();

                productDTO.id = int.Parse(item.SubItems[0].Text);
                productDTO.description = item.SubItems[1].Text;
                productDTO.name = item.SubItems[2].Text;
                productDTO.value = float.Parse(item.SubItems[3].Text);
                productDTO.qtd = int.Parse(item.SubItems[4].Text);
                productDTO._dateCreation = DateTime.UtcNow;

                content.Add(productDTO);
                InputRemove.Clear();
            }

            var post = new PostDTO<ProductDTO>();
            var api = new ApiConnection.ApiConnection("http://localhost:5231/api/");
            post.Content = content[0];
            var status = api.executePost("Products", post);
            InputRemove.Clear();

        }
    }
}
