using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mall.Controls;

namespace Mall.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UCHome home = new UCHome();
            MainPanel.Controls.Add(home);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ChangeView(new UCLogin());
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
            MainForm.ChangeView(new UCProductManeger());
        }

        private async void BtnStatus_Click(object sender, EventArgs e)
        {
            var api = new ApiConnection.ApiConnection("http://localhost:5231/api/");
            var response = await api.executeURL("Products");
            MainForm.ChangeView(new UCStatus(response));
        }
    }
}
