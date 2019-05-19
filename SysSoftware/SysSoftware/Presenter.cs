using SysSoftware.Model;
using System.ComponentModel;

namespace SysSoftware
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly IModel _model;

        private bool IsBinaryFileOpened = false;
        private bool IsJSONFileOpened = false;
        private bool IsBdBinaryOpened = false;
        private bool IsBdJsonOpened = false;
        //private bool IsSaved = true;
        private string currentPath = null;
        Model.DataList dataList = new Model.DataList();
        BindingList<object> bindingList = new BindingList<object>();             

        private void CreateBinaryFile()
        {            
            var path = _view.GetSavePath("file", "bin", "Создать бинарный файл");
            if (path != null)
            {
                IsBinaryFileOpened = true;
                IsJSONFileOpened = false;
                _model.CreateFile(path);
                OpenFileProcess(path);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Создан файл " + path);
            }
        }

        private void CreateJSONFile()
        {
            var path = _view.GetSavePath("file", "json", "Создать JSON файл");
            if (path != null)
            {
                IsBinaryFileOpened = false;
                IsJSONFileOpened = true;
                _model.CreateFile(path);
                OpenFileProcess(path);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Создан файл " + path);
            }
        }

        private void OpenFile()
        {
            var path = _view.GetOpenPath("Открыть файл");
            if (path != null && path.ToUpper().EndsWith("BIN"))
            {
                currentPath = path;
                IsBinaryFileOpened = true;
                IsJSONFileOpened = false;
                OpenFileProcess(path);
            }
            else if (path != null && path.ToUpper().EndsWith("JSON"))
            {
                currentPath = path;
                IsBinaryFileOpened = false;
                IsJSONFileOpened = true;
                OpenFileProcess(path);
            }
        }

        private void OpenFileProcess(string path)
        {
            bindingList.Clear();
            _view.TableClear();
            dataList = _model.OpenFile(path);
            foreach (var i in dataList.Records)
                bindingList.Add(i);
            if (bindingList.Count > 0)
                _view.TableUpdate(bindingList);           
            _view.SaveAsEnable(true);
            _view.CloseEnable(true);
            _view.ExportEnable(true);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Открыт файл " + path);
        }

        private void SaveFile()
        {
            if (currentPath != null)
            {
                _model.SaveFile(currentPath, dataList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл успешно сохранен");
                _view.SaveEnable(false);
            }
        }

        private void SaveAsFile()
        {
            if (IsBinaryFileOpened | IsBdBinaryOpened)
            {
                var path = _view.GetSavePath("fileBin", "bin", "Сохранить в...");
                if (path != null)
                    {
                       _model.SaveFile(path, dataList);
                       _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл успешно сохранен");
                    }
            }
            if (IsJSONFileOpened | IsBdJsonOpened)
            {
                var path = _view.GetSavePath("fileBin", "json", "Сохранить в...");
                if (path != null)
                {
                    _model.SaveFile(path, dataList);
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл успешно сохранен");
                }
            }
        }

        private void CloseFile()
        {
            currentPath = null;
            bindingList.Clear();           
            dataList.Records.Clear();
            _view.TableClear();
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл закрыт");
            _view.SaveAsEnable(false);
            _view.CloseEnable(false);
            _view.ExportEnable(false);
        }

        private void GetAccessInfo()
        {
            IsBinaryFileOpened = false;
            IsBdBinaryOpened = false;
            IsJSONFileOpened = true;
            IsBdJsonOpened = true;
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
            bindingList.Clear();
            _view.TableClear();
            dataList = _model.GetAccessInfo();
            foreach (var i in dataList.Records)
                bindingList.Add(i);
            if (bindingList.Count > 0)
                _view.TableUpdate(bindingList);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Импорт из БД завершен");
            _view.SaveAsEnable(true);
            _view.CloseEnable(true);
        }

        private void SaveInfo()
        {
            if (IsBdJsonOpened | IsJSONFileOpened)
            {
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
                _model.SaveAccessInfo(dataList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Экспорт в БД завершен");
                _view.ExportEnable(false);
            }
            else if(IsBdBinaryOpened | IsBinaryFileOpened)
            {
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
                _model.SaveFileInfo(dataList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Экспорт в БД завершен");
                _view.ExportEnable(false);
            }
        }

        private void GetFileInfo()
        {
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
            bindingList.Clear();
            _view.TableClear();
            dataList = _model.GetFileInfo();
            foreach (var i in dataList.Records)
                bindingList.Add(i);
            if (bindingList.Count > 0)
                _view.TableUpdate(bindingList);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Импорт из БД завершен");
            _view.SaveAsEnable(true);
            _view.CloseEnable(true);
        }

        private void AddRecord()
        {
            if (IsBinaryFileOpened | IsBdBinaryOpened)
            {
                var path = _view.GetOpenPath("Выбрать файл");
                if (path != null)
                {
                    var record = _model.GetFileInfo(path);
                    AddRecordProcess(record);
                }
            }
            if (IsJSONFileOpened | IsBdJsonOpened)
            {
                Views.NewRecordForm newRecordForm = new Views.NewRecordForm();
                newRecordForm.ShowDialog();
                if (newRecordForm.OK)
                {
                    var record = new AccessInfoRecord(newRecordForm.Login, _model.GetHash(newRecordForm.Password), newRecordForm.Email);
                    AddRecordProcess(record);
                }
                newRecordForm.Dispose();
            }
        }

        private void AddRecordProcess(IRecord record)
        {
            dataList.Add(record);
            bindingList.Add(record);
            _view.TableUpdate(bindingList);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Запись добавлена");
            _view.SaveEnable(true);
            _view.ExportEnable(true);
        }

        private void DeleteRecord()
        {
            int number = _view.GetRow();
            if (number != -1)
            {
                dataList.Delete(number);
                bindingList.RemoveAt(number);
                _view.TableUpdate(bindingList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Запись удалена");
                _view.SaveEnable(true);
                _view.ExportEnable(true);
            }
        }

        private void ModifyRecord()
        {
            int number = _view.GetRow();
            if (number != -1)
            {
                if (IsBinaryFileOpened | IsBdBinaryOpened)
                {
                    var path = _view.GetOpenPath("Выбрать файл");
                    if (path != null)
                    {
                        var record = _model.GetFileInfo(path);
                        ModifyRecordProcess(number, record);
                    }
                }
                if (IsJSONFileOpened | IsBdJsonOpened)
                {
                    Views.NewRecordForm newRecordForm = new Views.NewRecordForm();
                    newRecordForm.ShowDialog();
                    if (newRecordForm.OK)
                    {
                        var record = new AccessInfoRecord(newRecordForm.Login, newRecordForm.Password, newRecordForm.Email);
                        ModifyRecordProcess(number, record);
                    }
                    newRecordForm.Dispose();
                }
            }
        }

        private void ModifyRecordProcess(int number, IRecord record)
        {
            dataList.ChangeAt(number, record);
            bindingList.RemoveAt(number);
            bindingList.Insert(number, record);
            _view.TableUpdate(bindingList);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Запись изменена");
            _view.SaveEnable(true);
            _view.ExportEnable(true);
        }

        private void Analyze()
        {
            if (_view.GetAnalyzer())
                _view.AnalysisResultSet(_model.AnalyzeFor(_view.GetConstruction()));
            else
                _view.AnalysisResultSet(_model.AnalyzeDoWhile(_view.GetConstruction()));
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Анализ завершен");
        }

        private void ShowStatus()
        {
            _view.ShowStatus();
        }

        public void Run()
        {
            _view.Show();
        }

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.CreateBinaryFileClick += CreateBinaryFile;
            _view.CreateJSONFileClick += CreateJSONFile;
            _view.OpenFileClick += OpenFile;
            _view.SaveFileClick += SaveFile;
            _view.SaveAsFileClick += SaveAsFile;
            _view.CloseFileClick += CloseFile;
            _view.GetAccessInfoClick += GetAccessInfo;
            _view.SaveInfoClick += SaveInfo;
            _view.GetFileInfoClick += GetFileInfo;
            _view.AddRecordClick += AddRecord;
            _view.DeleteRecordClick += DeleteRecord;
            _view.ModifyRecordClick += ModifyRecord;
            _view.AnalyzeClick += Analyze;
            _view.ShowStatusBarClick += ShowStatus;
        }
    }
}