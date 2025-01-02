using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Utils.ConnectionApi.DTO
{
    class UserCreationDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
