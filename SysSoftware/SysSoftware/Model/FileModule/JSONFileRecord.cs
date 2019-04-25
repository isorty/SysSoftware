using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model
{
    public class JSONFileRecord : IRecord
    {

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }

        public JSONFileRecord() { }

        public JSONFileRecord(string login, string hashPassword, string email)
        {
            Login = login;
            HashPassword = hashPassword;
            Email = email;
        }
    }
}
