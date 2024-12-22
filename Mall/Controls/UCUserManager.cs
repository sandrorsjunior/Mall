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
using Mall.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mall.Controls
{
    public partial class UCUserManager : UserControl
    {
        List<ListViewItem> newUsers = new List<ListViewItem>();
        public UCUserManager()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UserModel user = this.factoryUserModel();
            ListViewItem newItem = new ListViewItem(Utility.GetAttrAsStringArray(user));
            newUsers.Add(newItem);
            this.insertItemsInListView();
            this.clearFields();
        }

        private void clearFields()
        {
            InputName.Clear();
            InputEmail.Clear();
            InputRole.Clear();
            IputTimePicker.Value = DateTime.Now;
            InputPassword.Clear();
        }

        private void insertItemsInListView()
        {
            LWUser.Items.Clear();
            long index_id = 0;
            foreach (var item in newUsers)
            {

                item.SubItems[0].Text = index_id.ToString();
                LWUser.Items.Add(item);
                index_id++;
            }

        }
        private UserModel factoryUserModel()
        {
            UserModel userModel = new UserModel();
            userModel.name = InputName.Text;
            userModel.email = InputEmail.Text;
            userModel.birthday = IputTimePicker.Value;
            userModel.role = InputRole.Text;
            userModel.password = InputPassword.Text;
            userModel.id = -1;
            return userModel;
        }
    }
}
