using Mall.Models;
using Mall.Utils;
using Mall.Utils.ConnectionApi.DTO;
using Mall.Utils.ConnectionApi;
using Mall.Utils.Encryption;

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
            var ix = Utility.GetAttrAsStringArray(user);
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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int inindexRemove = InputRemove.Text == "" ? newUsers.Count() - 1 : int.Parse(InputRemove.Text);
            newUsers.Remove(newUsers[inindexRemove]);
            this.insertItemsInListView();
            InputRemove.Clear();
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            Api api = new Api("http://localhost:5231/api/");
            List<string> UsersNotSend = new();

            foreach (var userItem in this.newUsers)
            {
                byte[] saltArr = new byte[128 / 8];
                var salt = Encryption.GeraSalt(saltArr);

                var newUser = new UserCreationDTO {
                    Name = userItem.SubItems[1].Text,
                    Email = userItem.SubItems[2].Text,
                    Birthday = DateTime.Parse(userItem.SubItems[3].Text).ToUniversalTime(),
                    Role = userItem.SubItems[4].Text,
                    Password = Encryption.CriptografarSenha(userItem.SubItems[5].Text, salt),
                    Salt = salt,
                };

                var post = new PostDTO<UserCreationDTO>
                {
                    Content = newUser
                };
                try
                {
                    var response = await api.Post<UserCreationDTO>("Users/creatUser", post);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK) 
                    {
                        UsersNotSend.Add(newUser.Email);
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Some problem there was when the program tried register the user: {newUser.Email}");
                }
            }

            if (UsersNotSend.Count() == 0)
            {
                MessageBox.Show("New User registered!");
                LWUser.Items.Clear();
            }
            else
            {
                MessageBox.Show(string.Join("\n", UsersNotSend));
            }

        }
    }
}
