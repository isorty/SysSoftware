﻿using System.IO;
using System.Security.Cryptography;
using Model.FileModule;
using Model.Analyzers;
using Model.AssemblyFunctions;
using Model.DataBaseModule;

namespace Model
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
                    foreach (BdAccessInfoRecord record in records)
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
                    foreach (BdFileInfoRecord record in records)
                        dataList.Add(new FileInfoRecord(record.Path, record.Size, record.CreationDate));
            }
            return dataList;
        }

        public void SaveAccessInfo(DataList dataList)
        {
            using (AccessInfoContext db = new AccessInfoContext())
            {
                if (dataList.Records != null)
                    foreach (AccessInfoRecord record in dataList.Records)
                        db.AccessInfoRecords.Add(new BdAccessInfoRecord(record.Login, record.HashPassword, record.Email));
                db.SaveChanges();
            }
        }

        public void SaveFileInfo(DataList dataList)
        {
            using (FileInfoContext db = new FileInfoContext())
            {
                if (dataList.Records != null)
                    foreach (FileInfoRecord record in dataList.Records)
                        if (record != null)
                            db.FileInfoRecords.Add(new BdFileInfoRecord(record.Path, record.Size, record.CreationDate));
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
            AnalyzerDoWhile analizator = new AnalyzerDoWhile(construction);
            return analizator.AnalysisResult();
        }

        public string GetHash(string password)
        {
            byte[] data = MD5.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }
    }
}