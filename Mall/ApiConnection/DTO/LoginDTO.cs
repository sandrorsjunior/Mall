using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.ApiConnection.DTO
{
    class LoginDTO
    {
        public string email { get; set; }
        public string password { get; set; }

        public override string ToString(){
            {
                return $"Email: {this.email}";
            }
        }
    }
}
