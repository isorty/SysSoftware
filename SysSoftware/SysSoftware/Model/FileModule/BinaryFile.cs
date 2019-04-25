using System.Collections.Generic;
using System.IO;

namespace SysSoftware.Model
{
    public class BinaryFile : IFile
    {
        public void Write(string path, List<IRecord> dataList)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    BinaryFileRecord record = (BinaryFileRecord)dataList[i];
                    binaryWriter.Write(record.Path);
                    binaryWriter.Write(record.Size);
                    binaryWriter.Write(record.CreationDate);
                }
            }

        }

        public List<IRecord> Read(string path)
        {
            List<IRecord> dataList = new List<IRecord>();
            using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
            {               
                while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
                {
                    var record = new BinaryFileRecord(binaryReader.ReadString(), binaryReader.ReadDouble(), binaryReader.ReadString());
                    dataList.Add(record);
                }
            }
            return dataList;
        }
    }
}
