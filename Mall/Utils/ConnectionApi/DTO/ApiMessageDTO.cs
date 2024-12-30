
namespace Mall.Utils.ConnectionApi.DTO
{
    class ApiMessageDTO <T>
    {
        public T? data { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
}
