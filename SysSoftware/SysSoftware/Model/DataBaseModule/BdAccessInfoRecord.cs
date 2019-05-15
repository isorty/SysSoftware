using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model.DataBaseModule
{
    class BdAccessInfoRecord : AccessInfoRecord
    {
        public int Id { get; set; }

        public BdAccessInfoRecord() { }

        public BdAccessInfoRecord(string login, string password, string email) : base(login, password, email) { }
      
    }
}
