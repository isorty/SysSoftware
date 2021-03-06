﻿namespace Model
{
    public class FileInfoRecord : IRecord
    {
        public string Path { get; set; }

        public double Size { get; set; }

        public string CreationDate { get; set; }

        public FileInfoRecord() { }

        public FileInfoRecord(string path, double size, string creationDate)
        {
            Path = path;
            Size = size;
            CreationDate = creationDate;
        }
    }
}