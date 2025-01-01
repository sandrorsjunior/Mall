using Mall.ApiConnection.DTO;
using Mall.Forms;
using Mall.Utils.ConnectionApi;
using Mall.Utils.ConnectionApi.DTO;
using Mall.Utils.Encryption;

namespace Mall.Controls
{
    public partial class UCLogin : UserControl
    {
        private Button _BtnStatus;
        private Button _BtnProduct;
        private Button _BtnUserManeger;
        public UCLogin(Button BtnStatus, Button BtnProduct, Button BtnUserManeger)
        {
            this._BtnStatus = BtnStatus;
            this._BtnProduct = BtnProduct;
            this._BtnUserManeger = BtnUserManeger;
            InitializeComponent();
        }

        public void ControlStateOfMenu(bool isLogin)
        {
            if (isLogin)
            {
                this._BtnStatus.Enabled = true;
                this._BtnProduct.Enabled = true;
                this._BtnUserManeger.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.ChangeView(new UCUserManager());
        }

        private async void BtnEnter_Click(object sender, EventArgs e)
        {
            string msg;
            var Login = await this.ComparePassword(InputPassWord.Text);
            if (Login != null)
            {
                MainForm.LoginDTO = Login;
                this.ControlStateOfMenu(true);
                msg = "user into";
            }
            else 
            {
                msg = "user out";
            }
            MessageBox.Show(msg);
        }


        private async Task<ResponseMessageDTO<LoginDTO>> GetHashSavedApi() {

            Api api = new Api("http://localhost:5231/api/");
            var content = new LoginDTO
            {
                email = InputUser.Text,
                password = InputPassWord.Text
            };
            var post = new PostDTO<LoginDTO>
            {
                Content = content
            };
            var response = await api.Post<LoginDTO>("Users/login", post);

            return response;
        }

        public async Task<LoginDTO>? ComparePassword(string passwordRaw)
        {
            var HashCodeFromApi = await this.GetHashSavedApi();
            var dataLogin = HashCodeFromApi.Data;

            var passwordEncrypt = Encryption.CriptografarSenha(passwordRaw, dataLogin.salt);

            if (passwordEncrypt == dataLogin.password)
            {
                return dataLogin;
            }
            else 
            {
                return null;
            }

        }
    }
}
