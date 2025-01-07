using Mall.Models;
using Mall.Utils.ConnectionApi;
using Mall.Utils.ConnectionApi.DTO;

namespace Mall.Controls
{
    public partial class UCProductManeger : UserControl
    {
        List<ListViewItem> newProducts = new List<ListViewItem>();
        private LoginDTO _loginDTO;
        public UCProductManeger(LoginDTO loginDTO)
        {
            this._loginDTO = loginDTO;
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

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            List<ProductDTO> content = new List<ProductDTO>();

            foreach (var item in newProducts)
            {
                var productDTO = new ProductDTO();
                productDTO.userId = this._loginDTO.userId;
                productDTO.id = int.Parse(item.SubItems[0].Text);
                productDTO.description = item.SubItems[2].Text;
                productDTO.name = item.SubItems[1].Text;
                productDTO.value = float.Parse(item.SubItems[3].Text);
                productDTO.qtd = int.Parse(item.SubItems[4].Text);
                productDTO._dateCreation = DateTime.UtcNow;

                content.Add(productDTO);
                InputRemove.Clear();
            }

            var post = new PostDTO<ProductDTO>();
            Api api = new Api("http://localhost:5231/api/");
            post.Content = content[0];
            var response = await api.Post<ProductDTO>("Products", post);
            InputRemove.Clear();
            listView.Items.Clear();
            this.newProducts = new List<ListViewItem>();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.newProducts = new List<ListViewItem>();
            listView.Items.Clear();
        }
    }
}
