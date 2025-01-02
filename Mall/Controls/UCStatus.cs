using Mall.Utils;
using Mall.Utils.ConnectionApi.DTO;

namespace Mall.Controls
{
    public partial class UCStatus : UserControl
    {
        private ResponseMessageDTO<List<ProductSatusDTO>> _reponseApi;
        public UCStatus(ResponseMessageDTO<List<ProductSatusDTO>> reponseApi)
        {
            InitializeComponent();
            this._reponseApi = reponseApi;
            this.InsetDataInListView();
        }
        private void InsetDataInListView()
        {
            for(int i = 0; i<this._reponseApi.Data.Count(); i++)
            {
                for (int j_r = 0; j_r < this._reponseApi.Data[i].productRegister.Count(); j_r++) 
                {
                    ListViewItem item = new(Utility.GetAttrAsStringArray(this._reponseApi.Data[0]));
                    item.SubItems[0].Text = this._reponseApi.Data[i].id.ToString();
                    item.SubItems[1].Text = this._reponseApi.Data[i].name;
                    item.SubItems[2].Text = this._reponseApi.Data[i].description;
                    item.SubItems[3].Text = this._reponseApi.Data[i].value.ToString();
                    item.SubItems[4].Text = this._reponseApi.Data[i].qtd.ToString();
                    item.SubItems[5].Text = this._reponseApi.Data[i].productRegister[j_r]._dateCreation.ToString();
                    item.SubItems.Add("by");
                    item.SubItems[6].Text = this._reponseApi.Data[i].productRegister[j_r].userId.ToString();

                    listViewStatus.Items.Add(item);
                }
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
