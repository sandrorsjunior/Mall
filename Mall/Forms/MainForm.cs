
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mall.ApiConnection.DTO;
using Mall.Controls;
using Mall.Utils.ConnectionApi;
using Mall.Utils.ConnectionApi.DTO;

namespace Mall.Forms
{
    public partial class MainForm : Form
    {
        public static LoginDTO LoginDTO { get; set; }
        public MainForm()
        {
            InitializeComponent();
            UCHome home = new UCHome();
            MainPanel.Controls.Add(home);
            ControlStateOfMenu();
        }

        public void ControlStateOfMenu()
        {
            BtnStatus.Enabled = false;
            BtnProduct.Enabled = false;
            BtnUserManeger.Enabled = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ChangeView(new UCLogin(BtnStatus, BtnProduct, BtnUserManeger));
        }

        public static void ChangeView(UserControl userControl)
        {
            MainForm.MainPanel.Controls.Clear();
            userControl.Location = new System.Drawing.Point(0, 0);
            MainForm.MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnUserManeger_Click(object sender, EventArgs e)
        {
            MainForm.ChangeView(new UCUserManager());
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            MainForm.ChangeView(new UCProductManeger(LoginDTO));
        }

        private async void BtnStatus_Click(object sender, EventArgs e)
        {
            var api = new Api("http://localhost:5231/api/");
            var response = await api.Get<List<ProductSatusDTO>> ("Products");
            MainForm.ChangeView(new UCStatus(response));
        }
    }
}
