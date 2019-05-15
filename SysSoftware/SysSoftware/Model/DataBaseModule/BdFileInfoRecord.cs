using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model.DataBaseModule
{
    class BdFileInfoRecord : FileInfoRecord
    {
        public int Id { get; set; }

        public BdFileInfoRecord() { }

        public BdFileInfoRecord(string path, double size, string creationDate) : base(path, size, creationDate) { }

    }
}
