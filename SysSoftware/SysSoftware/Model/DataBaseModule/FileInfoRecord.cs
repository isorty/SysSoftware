using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model.DataBaseModule
{
    class FileInfoRecord : BinaryFileRecord
    {
        public int Id { get; set; }

        public FileInfoRecord() { }

        public FileInfoRecord(string path, double size, string creationDate) : base(path, size, creationDate) { }

    }
}
