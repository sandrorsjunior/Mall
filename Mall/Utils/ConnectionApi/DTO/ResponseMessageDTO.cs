using System.Net;


namespace Mall.Utils.ConnectionApi.DTO
{
    class ResponseMessageDTO <T>
    {
        public T? Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
