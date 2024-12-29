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
using Mall.Forms;
using Mall.Utils.ConnectionApi;

namespace Mall.Controls
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.ChangeView(new UCUserManager());
        }

        private async void BtnEnter_Click(object sender, EventArgs e)
        {
            Api api = new Api("http://localhost:5231/api/");
            var content = new LoginDTO {
                email = "root@root",
                password = "admin_root"
            };
            var post = new PostDTO<LoginDTO> {
                Content = content
            };
            var response = await api.Post<LoginDTO>("Users/login", post);
            MessageBox.Show(response.Data.email);
        }
    }
}
