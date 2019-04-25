﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSoftware.Model
{
    public interface IModel
    {
        void CreateFile(string path);
        DataList OpenFile(string path);
        void SaveFile(string path, DataList dataList);
        DataList GetAccessInfo();
        DataList GetFileInfo();
        void SaveAccessInfo(DataList dataList);
        void SaveFileInfo(DataList dataList);
        BinaryFileRecord GetFileInfo(string path);
        string AnalyzeFor(string construction);
        string AnalyzeDoWhile(string construction);
    }
}
