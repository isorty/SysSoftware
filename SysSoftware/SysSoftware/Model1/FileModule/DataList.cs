using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model
{
    public class DataList
    {

        public List<IRecord> Records { get; set; }

        public void Add(IRecord record)
        {
            if (Records == null)
            {
                Records = new List<IRecord>();
                Records.Add(record);
            }
            else
                Records.Add(record);
        }

        public void ChangeAt(int number, IRecord record)
        {
            if (Records != null)
            {
                Records.RemoveAt(number);
                Records.Insert(number, record);
            }
        }

        public void Delete()
        {
            if (Records != null)
                Records.RemoveAt(Records.Count);
        }

        public void Delete(int number)
        {
            if (Records != null)
                Records.RemoveAt(number);
        }
    }
}
