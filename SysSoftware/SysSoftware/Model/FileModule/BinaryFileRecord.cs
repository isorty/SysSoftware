using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model
{
    public class BinaryFileRecord : IRecord
    {
        public string Path { get; set; }

        public double Size { get; set; }

        public string CreationDate { get; set; }

        public BinaryFileRecord() { }

        public BinaryFileRecord(string path, double size, string creationDate)
        {
            Path = path;
            Size = size;
            CreationDate = creationDate;
        }
    }
}