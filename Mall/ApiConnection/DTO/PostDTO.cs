using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.ApiConnection.DTO
{
    class PostDTO <T>
    {
        public Dictionary<string,string>? header { get; set; } = null;
        public T Content { get; set; }
    }
}
