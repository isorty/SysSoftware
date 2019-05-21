using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SysSoftware
{
    public partial class MainForm : Form, IView
    {
        public event Action CreateBinaryFileClick;
        public event Action CreateJSONFileClick;
        public event Action OpenFileClick;
        public event Action SaveFileClick;
        public event Action SaveAsFileClick;
        public event Action CloseFileClick;
        public event Action ImportAccessInfoClick;
        public event Action ImportFileInfoClick;
        public event Action ExportDataClick;
        public event Action AddRecordClick;
        public event Action DeleteRecordClick;
        public event Action ModifyRecordClick;
        public event Action AnalyzeClick;
        public event Action ShowStatusBarClick;
        public event Action ComplementClick;
        public event Action CompareClick;

        public string GetOpenPath(string title)
        {
            openFileDialog.Title = title;
            return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
        }

        public string GetSavePath(string defaultFileName, string defaultExtension, string title)
        {
            saveFileDialog.FileName = defaultFileName;
            saveFileDialog.DefaultExt = defaultExtension;
            saveFileDialog.Title = title;
            return saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : null;
        }

        public int GetRow()
        {
            return table.SelectedRows.Count == 1 ? table.Rows.IndexOf(table.SelectedRows[0]) : -1;
        }

        public void TableClear()
        {
            table.Rows.Clear();
            table.Columns.Clear();
            table.DataSource = null;
            table.Update();
        }

        public void TableUpdate(BindingList<object> bindingList)
        {
            table.DataSource = bindingList;
            table.Update();
        }

        public void TableAddColumn(string name, int size)
        {
            var column = new DataGridViewColumn
            {
                HeaderText = name,
                Width = size,
                ReadOnly = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            table.Columns.Add(column);
        }

        public void TableAddRow(string[] values)
        {
            table.Rows.Add();
            table.Rows[table.Rows.Count - 1].SetValues(values);
        }

        public void ShowStatus()
        {
            statusBar.Visible = statusBarMenu.Checked;
        }

        public void ChangeStatus(string status)
        {
            statusText.Text = status;
        }

        public bool GetAnalyzer()
        {
            return isAnalyzerFor.Checked ? true : false;
        }

        public string GetConstruction()
        {
            return constructionTextBox.Text;
        }

        public void SetAnalysisResult(string result)
        {
            analysisResultLabel.Text = result;
        }

        public void EditEnable(bool state)
        {
            addRecord.Enabled = state;
            toolAddRecordButton.Enabled = state;
            modifyRecord.Enabled = state;
            toolModifyRecordButton.Enabled = state;
            deleteRecord.Enabled = state;
            toolDeleteRecordButton.Enabled = state;
        }

        public void SaveEnable(bool state)
        {
            saveFileMenu.Enabled = state;
            toolSaveButton.Enabled = state;
        }

        public void SaveAsEnable(bool state)
        {
            saveAsFileMenu.Enabled = state;
            toolSaveAsButton.Enabled = state;
        }

        public void CloseEnable(bool state)
        {
            closeFileMenu.Enabled = state;
            toolCloseButton.Enabled = state;
        }

        public void ExportEnable(bool state)
        {
            saveInfoMenu.Enabled = state;
            toolExportButton.Enabled = state;
        }

        public int GetNumeralSystem()
        {
            if (binRadioButton.Checked)
                return 2;
            else if (decRadioButton.Checked)
                return 10;
            else if (hexRadioButton.Checked)
                return 16;
            else return 0;
        }

        public string GetComplementValue()
        {
            return complementValue.Text;
        }

        public void SetComplementResult(string complementResult)
        {
            complementResultText.Text = complementResult;
        }

        public string[] GetCompareValues()
        {
            return new string[] { compareFirstOperand.Text, compareSecondOperand.Text };
        }

        public void SetCompareResult(string compareResult)
        {
            compareLabel.Text = compareResult;
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public MainForm()
        {
            InitializeComponent();
            createBinaryFileMenu.Click += delegate { CreateBinaryFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            toolCreateBinButton.Click += delegate { CreateBinaryFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            createJSONFileMenu.Click += delegate { CreateJSONFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            toolCreateJsonButton.Click += delegate { CreateJSONFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            openFileMenu.Click += delegate { OpenFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            toolOpenButton.Click += delegate { OpenFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            saveFileMenu.Click += delegate { SaveFileClick?.Invoke(); };
            saveAsFileMenu.Click += delegate { SaveAsFileClick?.Invoke(); };
            toolSaveButton.Click += delegate { SaveFileClick?.Invoke(); };
            toolSaveAsButton.Click += delegate { SaveAsFileClick?.Invoke(); };
            closeFileMenu.Click += delegate { CloseFileClick?.Invoke(); };
            toolCloseButton.Click += delegate { CloseFileClick?.Invoke(); };
            getAccessInfoMenu.Click += delegate { ImportAccessInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            toolMenuAccessImport.Click += delegate { ImportAccessInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            getFileInfoMenu.Click += delegate { ImportFileInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            toolMenuFileInfoImport.Click += delegate { ImportFileInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            saveInfoMenu.Click += delegate { ExportDataClick?.Invoke(); };
            toolExportButton.Click += delegate { ExportDataClick?.Invoke(); };
            addRecord.Click += delegate { AddRecordClick?.Invoke(); };
            toolAddRecordButton.Click += delegate { AddRecordClick?.Invoke(); };
            deleteRecord.Click += delegate { DeleteRecordClick?.Invoke(); };
            toolDeleteRecordButton.Click += delegate { DeleteRecordClick?.Invoke(); };
            modifyRecord.Click += delegate { ModifyRecordClick?.Invoke(); };
            toolModifyRecordButton.Click += delegate { ModifyRecordClick?.Invoke(); };
            analyzeButton.Click += delegate { AnalyzeClick?.Invoke(); };
            statusBarMenu.Click += delegate { ShowStatusBarClick?.Invoke(); };
            execComplement.Click += delegate { ComplementClick?.Invoke(); };
            execCompare.Click += delegate { CompareClick?.Invoke(); };
        }      
    }
}
