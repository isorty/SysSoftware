using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Model
{
    public class JSONFile : IFile
    {
        public void Write(string filePath, List<IRecord> objectToWrite)
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public List<IRecord> Read(string filePath)
        {
            TextReader reader = null;
            try
            {
                List<IRecord> dataList = new List<IRecord>();
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                List<AccessInfoRecord> jsonFileRecord = JsonConvert.DeserializeObject<List<AccessInfoRecord>>(fileContents);
                if (jsonFileRecord != null)
                    foreach (AccessInfoRecord record in jsonFileRecord)
                        dataList.Add(record);
                return dataList;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
