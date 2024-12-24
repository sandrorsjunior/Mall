using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string data = "{\"data\":[{\"id\":22,\"name\":\"string\",\"qtd\":0,\"value\":0,\"description\":\"string\",\"_dateCreation\":\"2024-12-24T00:09:17.504Z\"},{\"id\":23,\"name\":\"string\",\"qtd\":0,\"value\":0,\"description\":\"string\",\"_dateCreation\":\"2024-12-24T00:12:07.157Z\"},{\"id\":24,\"name\":\"x\",\"qtd\":0,\"value\":2,\"description\":\"x\",\"_dateCreation\":\"2024-12-24T00:13:40.419Z\"},{\"id\":25,\"name\":\"x\",\"qtd\":0,\"value\":2,\"description\":\"x\",\"_dateCreation\":\"2024-12-24T00:13:40.419Z\"},{\"id\":26,\"name\":\"Arrived the new Dragon's Eraser \",\"qtd\":100,\"value\":0.3,\"description\":\"Eraser\",\"_dateCreation\":\"2024-12-24T09:33:46.982767Z\"}],\"status\":true,\"message\":\"All products were collected\"}";
            ResonseProductAPI jsonData = JsonSerializer.Deserialize<ResonseProductAPI>(data);
            Console.Write(jsonData.data);
        }
    }

    public class ProductDTO
    {
        public long id { get; set; }
        public string name { get; set; }
        public int qtd { get; set; }
        public float value { get; set; }
        public string description { get; set; }
        public DateTime _dateCreation { get; set; }
    }

    public class ResonseProductAPI
    {
        public List<ProductDTO> data { get; set; }
        public bool status { get; set; } = true;
        public string message { get; set; } = "";

    }
}