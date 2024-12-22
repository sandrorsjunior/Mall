﻿using System;
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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            ChangeView(new UCLogin());
            var api = new ApiConnection("https://jsonplaceholder.typicode.com/users");
            string response = await api.GetUser();
            
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

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            MainForm.ChangeView(new UCStatus());
        }
    }
}
