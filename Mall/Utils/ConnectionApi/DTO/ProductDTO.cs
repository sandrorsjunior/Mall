using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Utils.ConnectionApi.DTO
{
    public class ProductDTO
    {
        public long id { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public int qtd { get; set; }
        public float value { get; set; }
        public string description { get; set; }
        public DateTime _dateCreation { get; set; }
    }

    public class ResonseProductAPI
    {
        public List<ProductDTO> data { get; set; }
        public bool status { get; set; }
        public string message { get; set; }

    }

}
