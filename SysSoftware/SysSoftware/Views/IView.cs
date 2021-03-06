﻿using System;
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

        event Action ImportAccessInfoClick;

        event Action ImportFileInfoClick;

        event Action ExportDataClick;

        event Action AddRecordClick;

        event Action DeleteRecordClick;

        event Action ModifyRecordClick;

        event Action AnalyzeClick;

        event Action ShowStatusBarClick;

        event Action ComplementClick;

        event Action CompareClick;

        event Action AboutClick;

        event Action ExitClick;

        string GetOpenPath(string title);

        string GetSavePath(string defaultFileName, string defaultExtension, string title);

        int GetRow();

        void TableClear();

        void TableUpdate(BindingList<object> bindingList);

        void ShowStatus();

        void ChangeStatus(string status);

        bool GetAnalyzer();

        string GetConstruction();

        void SetAnalysisResult(string result);

        void EditEnable(bool state);

        void SaveEnable(bool state);

        void SaveAsEnable(bool state);

        void CloseEnable(bool state);

        void ExportEnable(bool state);

        int GetNumeralSystem();

        string GetComplementValue();

        void SetComplementResult(string complementResult);

        string[] GetCompareValues();

        void SetCompareResult(string compareResult);

        void Show();

        void Close();
    }

}