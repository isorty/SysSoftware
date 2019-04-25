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
        public event Action GetAccessInfoClick;
        public event Action GetFileInfoClick;
        public event Action SaveInfoClick;
        public event Action AddRecordClick;
        public event Action DeleteRecordClick;
        public event Action ModifyRecordClick;
        public event Action AnalyzeClick;
        public event Action ShowStatusBarClick;

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

        public void AnalysisResultSet(string result)
        {
            analysisResultLabel.Text = result;
        }

        public void SaveEnable(bool state)
        {
            saveFileMenu.Enabled = state;
        }

        public void SaveAsEnable(bool state)
        {
            saveAsFileMenu.Enabled = state;
        }

        public void CloseEnable(bool state)
        {
            closeFileMenu.Enabled = state;
        }

        public void ExportEnable(bool state)
        {
            saveInfoMenu.Enabled = state;
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public MainForm()
        {
            InitializeComponent();
            createBinaryFileMenu.Click += delegate { CreateBinaryFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            createJSONFileMenu.Click += delegate { CreateJSONFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            openFileMenu.Click += delegate { OpenFileClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            saveFileMenu.Click += delegate { SaveFileClick?.Invoke(); };
            saveAsFileMenu.Click += delegate { SaveAsFileClick?.Invoke(); };
            closeFileMenu.Click += delegate { CloseFileClick?.Invoke(); };
            getAccessInfoMenu.Click += delegate { GetAccessInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            getFileInfoMenu.Click += delegate { GetFileInfoClick?.Invoke(); mainTabControl.SelectTab(1); table.ClearSelection(); };
            saveInfoMenu.Click += delegate { SaveInfoClick?.Invoke(); };
            addRecord.Click += delegate { AddRecordClick?.Invoke(); };
            deleteRecord.Click += delegate { DeleteRecordClick?.Invoke(); };
            modifyRecord.Click += delegate { ModifyRecordClick?.Invoke(); };
            analyzeButton.Click += delegate { AnalyzeClick?.Invoke(); };
            statusBarMenu.Click += delegate { ShowStatusBarClick?.Invoke(); };
        }      
    }
}
