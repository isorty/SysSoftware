using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
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
        FileInfoRecord GetFileInfo(string path);
        string AnalyzeFor(string construction);
        string AnalyzeDoWhile(string construction);
        string GetMD5(string password);
        string AssemblyCompare(params string[] values);
        string AssemblyComplement(string valueString, int numeralSystem);
    }
}
