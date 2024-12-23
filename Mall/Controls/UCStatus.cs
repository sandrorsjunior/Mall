using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mall.ApiConnection.DTO;
using Mall.Utils;

namespace Mall.Controls
{
    public partial class UCStatus : UserControl
    {
        private ResonseProductAPI _reponseApi;
        public UCStatus(ResonseProductAPI reponseApi)
        {
            InitializeComponent();
            this._reponseApi = reponseApi;
            this.InsetDataInListView();
        }
        private void InsetDataInListView()
        {
            for(int i = 0; i<this._reponseApi.data.Count(); i++)
            {
                ListViewItem item = new(Utility.GetAttrAsStringArray(this._reponseApi.data[0]));
                item.SubItems[0].Text = this._reponseApi.data[i].id.ToString();
                item.SubItems[1].Text = this._reponseApi.data[i].name;
                item.SubItems[2].Text = this._reponseApi.data[i].description;
                item.SubItems[3].Text = this._reponseApi.data[i].value.ToString();
                item.SubItems[4].Text = this._reponseApi.data[i].qtd.ToString();
                item.SubItems[5].Text = this._reponseApi.data[i]._dateCreation.ToString();
                item.SubItems.Add("by");
                item.SubItems[6].Text = "root";

                listViewStatus.Items.Add(item);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
