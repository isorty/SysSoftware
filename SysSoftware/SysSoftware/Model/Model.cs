using System;
using System.IO;
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
            {
                DataList datalist = new DataList();
                BinaryFile binaryFile = new BinaryFile();
                datalist.Records = binaryFile.Read(path);
                return datalist;
            }
            else if (path.ToUpper().EndsWith(".JSON"))
            {
                DataList datalist = new DataList();
                JSONFile jsonFile = new JSONFile();
                datalist.Records = jsonFile.Read(path);
                return datalist;
            }
            else return null;
        }

        public void SaveFile(string path, DataList dataList)
        {
            if (path.ToUpper().EndsWith(".BIN"))
            {
                BinaryFile binaryFile = new BinaryFile();
                binaryFile.Write(path, dataList.Records);
            }
            else if (path.ToUpper().EndsWith(".JSON"))
            {
                JSONFile jsonFile = new JSONFile();
                jsonFile.Write(path, dataList.Records);
            }
        }

        public DataList GetAccessInfo()
        {
            DataList dataList = new DataList();
            using (AccessInfoContext db = new AccessInfoContext())
            {
                var records = db.AccessInfoRecords;
                if (records != null)
                    foreach (AccessInfoRecord record in records)
                        dataList.Add(new JSONFileRecord(record.Login, record.HashPassword, record.Email));
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
                    foreach (FileInfoRecord record in records)
                        dataList.Add(new BinaryFileRecord(record.Path, record.Size, record.CreationDate));
            }
            return dataList;
        }

        public void SaveAccessInfo(DataList dataList)
        {
            using (AccessInfoContext db = new AccessInfoContext())
            {
                if (dataList.Records != null)
                    foreach (JSONFileRecord record in dataList.Records)
                        db.AccessInfoRecords.Add(new AccessInfoRecord(record.Login, record.HashPassword, record.Email));
                db.SaveChanges();
            }
        }

        public void SaveFileInfo(DataList dataList)
        {
            using (FileInfoContext db = new FileInfoContext())
            {
                if (dataList.Records != null)
                    foreach (BinaryFileRecord record in dataList.Records)
                        if (record != null)
                            db.FileInfoRecords.Add(new FileInfoRecord(record.Path, record.Size, record.CreationDate));
                db.SaveChanges();
            }
        }

        public BinaryFileRecord GetFileInfo(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            return new BinaryFileRecord(path, fileInfo.Length, fileInfo.CreationTime.ToString());
        }

        public string AnalyzeFor(string construction)
        {
            Analyzer_for.Analyze(construction);
            return "Количество итераций цикла: " + Analyzer_for.Analyze(construction).RepeatCount.ToString();
        }

        public string AnalyzeDoWhile(string construction)
        {
            AnalyzerDoWhile analizator = new AnalyzerDoWhile(construction);
            return analizator.AnalysisResult();
        }
    }
}
