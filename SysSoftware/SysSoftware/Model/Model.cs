using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SysSoftware.Model.DataBaseModule;

namespace SysSoftware.Model
{
    public class Model : IModel
    {
        public void CreateFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            fileStream.Close();
        }

        public DataList OpenFile(string path)
        {
            if (path.ToUpper().EndsWith(".BIN"))
                return new DataList { Records = new BinaryFile().Read(path) };
            else if (path.ToUpper().EndsWith(".JSON"))
                return new DataList { Records = new JSONFile().Read(path) };
            else return null;
        }

        public void SaveFile(string path, DataList dataList)
        {
            if (path.ToUpper().EndsWith(".BIN"))
                new BinaryFile().Write(path, dataList.Records);
            else if (path.ToUpper().EndsWith(".JSON"))
                new JSONFile().Write(path, dataList.Records);
        }

        public DataList GetAccessInfo()
        {
            DataList dataList = new DataList();
            using (AccessInfoContext db = new AccessInfoContext())
            {
                var records = db.AccessInfoRecords;
                if (records != null)
                    foreach (DbAccessInfoRecord record in records)
                        dataList.Add(new AccessInfoRecord(record.Login, record.HashPassword, record.Email));
            }
            return dataList;
        }

        public DataList GetFileInfo()
        {
            DataList dataList = new DataList();
            using (FileInfoContext db = new FileInfoContext())
            {
                var records = db.FileInfoRecords;
                if (records != null)
                    foreach (DbFileInfoRecord record in records)
                        dataList.Add(new FileInfoRecord(record.Path, record.Size, record.CreationDate));
            }
            return dataList;
        }

        public void SaveAccessInfo(DataList dataList)
        {
            using (AccessInfoContext db = new AccessInfoContext())
            {
                if (dataList.Records != null)
                {
                    db.AccessInfoRecords.RemoveRange(db.AccessInfoRecords);
                    foreach (AccessInfoRecord record in dataList.Records)
                        db.AccessInfoRecords.Add(new DbAccessInfoRecord(record.Login, record.HashPassword, record.Email));
                }
                db.SaveChanges();
            }
        }

        public void SaveFileInfo(DataList dataList)
        {
            using (FileInfoContext db = new FileInfoContext())
            {
                if (dataList.Records != null)
                {
                    db.FileInfoRecords.RemoveRange(db.FileInfoRecords);
                    foreach (FileInfoRecord record in dataList.Records)
                        if (record != null)
                            db.FileInfoRecords.Add(new DbFileInfoRecord(record.Path, record.Size, record.CreationDate));
                }
                db.SaveChanges();
            }
        }

        public FileInfoRecord GetFileInfo(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            return new FileInfoRecord(path, fileInfo.Length, fileInfo.CreationTime.ToString());
        }

        public string AnalyzeFor(string construction)
        {
            Analyzer_for.Analyze(construction);
            return "Количество итераций цикла: " + Analyzer_for.Analyze(construction).RepeatCount.ToString();
        }

        public string AnalyzeDoWhile(string construction)
        {
            //AnalyzerDoWhile analizator = new AnalyzerDoWhile(construction);
            //return analizator.AnalysisResult();
            Analyzer_for.Analyze(construction);
            return "Количество итераций цикла: " + Analyzer_do_while.Analyze(construction).RepeatCount.ToString();
        }

        public string GetMD5(string password)
        {
            byte[] data = MD5.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }

        public string AssemblyCompare(params string[] values)
        {
            double firstValue;
            double secondValue;
            if (!double.TryParse(values[0], out firstValue) || !double.TryParse(values[1], out secondValue))
                throw new InvalidInputDataException("Неверный формат данных.");
            Assembly asm = Assembly.Load(System.IO.File.ReadAllBytes("AssemblyModule.dll"));
            Type t = asm.GetType("AssemblyModuleDLL");
            MethodInfo method = t.GetMethod("Compare", BindingFlags.Instance | BindingFlags.Public);
            object instance = Activator.CreateInstance(t);
            var result = Convert.ToByte(method.Invoke(instance, new object[] { firstValue, secondValue }));
            return result == 0 ? "≥" : "<";
        }

        public string AssemblyComplement(string valueString, int numeralSystem)
        {
            try
            {
                uint value = Convert.ToUInt32(valueString, numeralSystem);
                Assembly asm = Assembly.Load(System.IO.File.ReadAllBytes("AssemblyModule.dll"));
                Type t = asm.GetType("AssemblyModuleDLL");
                MethodInfo method = t.GetMethod("Complement", BindingFlags.Instance | BindingFlags.Public);
                object instance = Activator.CreateInstance(t);
                var result = Convert.ToUInt32(method.Invoke(instance, new object[] { value }));
                return Convert.ToString(result, numeralSystem).ToUpper();
            }
            catch
            {
                throw new InvalidInputDataException("Неверный формат данных.");
            }
        }
    }
}
