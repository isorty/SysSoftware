using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model.DataBaseModule
{
    class AccessInfoRecord : JSONFileRecord
    {
        public int Id { get; set; }

        public AccessInfoRecord() { }

        public AccessInfoRecord(string login, string hashPassword, string email) : base(login, hashPassword, email) { }
      
    }
}
