using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Utils.ConnectionApi.DTO
{
    class ApiMessageDTO <T>
    {
        public T? data { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
}
