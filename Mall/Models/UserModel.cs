using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Models
{
    class UserModel
    {
        private DateTime _dateCreation;
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
        public string role { get; set; }
        public string password { get; set; }

        public UserModel()
        {
            this._dateCreation = DateTime.Now;
        }

    }
}
