namespace Mall.Utils.ConnectionApi.DTO
{
    public class LoginDTO
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public byte[] salt { get; set; }

        public override string ToString()
        {
            {
                return $"Email: {email}";
            }
        }
    }
}
