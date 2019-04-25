using System;
using System.ComponentModel;

namespace SysSoftware
{
    public interface IView
    {
        event Action CreateBinaryFileClick;
        event Action CreateJSONFileClick;
        event Action OpenFileClick;
        event Action SaveFileClick;
        event Action SaveAsFileClick;
        event Action CloseFileClick;
        event Action GetAccessInfoClick;
        event Action GetFileInfoClick;
        event Action SaveInfoClick;
        event Action AddRecordClick;
        event Action DeleteRecordClick;
        event Action ModifyRecordClick;
        event Action AnalyzeClick;
        event Action ShowStatusBarClick;

        string GetOpenPath(string title);
        string GetSavePath(string defaultFileName, string defaultExtension, string title);

        int GetRow();
        void TableClear();
        void TableUpdate(BindingList<object> bindingList);
        void TableAddColumn(string name, int size);
        void TableAddRow(string[] values);

        void ShowStatus();
        void ChangeStatus(string status);

        bool GetAnalyzer();
        string GetConstruction();
        void AnalysisResultSet(string result);

        void SaveEnable(bool state);
        void SaveAsEnable(bool state);
        void CloseEnable(bool state);
        void ExportEnable(bool state);

        void Show();
    }

}