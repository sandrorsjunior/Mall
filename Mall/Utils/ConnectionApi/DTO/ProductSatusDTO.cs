
namespace Mall.Utils.ConnectionApi.DTO
{
    public class ProductSatusDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int qtd { get; set; }
        public float value { get; set; }
        public string description { get; set; }
        public ProductRegister[] productRegister { get; set; }
    }

    public class ProductRegister
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int userId { get; set; }
        public string task { get; set; }
        public DateTime _dateCreation { get; set; }
    }
}
