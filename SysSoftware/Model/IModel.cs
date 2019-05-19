using Model.FileModule;

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
        string GetHash(string password);
    }
}
