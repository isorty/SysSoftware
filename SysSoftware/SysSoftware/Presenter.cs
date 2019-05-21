using Model;
using System;
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
        private bool IsSaved = true;
        private string currentPath = null;
        DataList dataList = new DataList();
        BindingList<object> bindingList = new BindingList<object>();             

        private void CreateBinaryFile()
        {
            CheckSave();
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
            CheckSave();
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
            CheckSave();
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
            else ShowError("Неверный формат файла.");
        }

        private void ShowError(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Вычисление завершилось ошибкой");
        }

        private System.Windows.Forms.DialogResult ShowWarning(string message)
        {
            return System.Windows.Forms.MessageBox.Show(message, "", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
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
            _view.EditEnable(true);
            _view.SaveAsEnable(true);
            _view.CloseEnable(true);
            _view.ExportEnable(true);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Открыт файл " + path);
        }

        private void CheckSave()
        {
            if (!IsSaved)
            {
                switch (ShowWarning("Сохранить текущий файл?"))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        {
                            if (currentPath != null)
                                SaveFile();
                            else
                                SaveAsFile();
                            IsSaved = true;
                            break;
                        }
                    case System.Windows.Forms.DialogResult.No:
                        {
                            IsSaved = true;
                            break;
                        }
                }
            }
        }

        private void SaveFile()
        {
            if (currentPath != null)
            {
                _model.SaveFile(currentPath, dataList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл успешно сохранен");
                IsSaved = true;
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
                    IsSaved = true;
                }
            }
            if (IsJSONFileOpened | IsBdJsonOpened)
            {
                var path = _view.GetSavePath("fileBin", "json", "Сохранить в...");
                if (path != null)
                {
                    _model.SaveFile(path, dataList);
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл успешно сохранен");
                    IsSaved = true;
                }
            }
        }

        private void CloseFile()
        {
            CheckSave();
            currentPath = null;
            bindingList.Clear();           
            dataList.Records.Clear();
            _view.TableClear();
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Файл закрыт");
            _view.EditEnable(false);
            _view.SaveAsEnable(false);
            _view.CloseEnable(false);
            _view.ExportEnable(false);
        }

        private void ImportAccessInfo()
        {
            CheckSave();        
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
            bindingList.Clear();
            _view.TableClear();
            try
            {
                dataList = _model.GetAccessInfo();
                foreach (var i in dataList.Records)
                    bindingList.Add(i);
                if (bindingList.Count > 0)
                    _view.TableUpdate(bindingList);
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Импорт из БД завершен");
                IsBinaryFileOpened = false;
                IsBdBinaryOpened = false;
                IsJSONFileOpened = true;
                IsBdJsonOpened = true;
                IsSaved = false;
                _view.EditEnable(true);
                _view.SaveAsEnable(true);
                _view.CloseEnable(true);
            }
            catch (DbConnectionException e)
            {
                ShowError(e.Message);
            }
        }

        private void ExportData()
        {
            try
            {
                if (IsBdJsonOpened | IsJSONFileOpened)
                {
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
                    _model.SaveAccessInfo(dataList);
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Экспорт в БД завершен");
                    _view.ExportEnable(false);
                }
                else if (IsBdBinaryOpened | IsBinaryFileOpened)
                {
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Подключение к БД");
                    _model.SaveFileInfo(dataList);
                    _view.ChangeStatus(System.DateTime.Now.ToString() + " Экспорт в БД завершен");
                    _view.ExportEnable(false);
                }
            }
            catch (DbConnectionException e)
            {
                ShowError(e.Message);
            }
        }

        private void ImportFileInfo()
        {
            CheckSave();
            try
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
                IsBinaryFileOpened = true;
                IsBdBinaryOpened = true;
                IsJSONFileOpened = false;
                IsBdJsonOpened = false;
                IsSaved = false;
                _view.EditEnable(true);
                _view.SaveAsEnable(true);
                _view.CloseEnable(true);
            }
            catch (DbConnectionException e)
            {
                ShowError(e.Message);
            }
        }

        private void AddRecord()
        {
            if (IsBinaryFileOpened | IsBdBinaryOpened)
            {
                var path = _view.GetOpenPath("Выбрать файл");
                if (path != null)
                    AddRecordProcess(_model.GetFileInfo(path));
            }
            if (IsJSONFileOpened | IsBdJsonOpened)
            {
                NewRecordForm newRecordForm = new NewRecordForm();
                newRecordForm.ShowDialog();
                if (newRecordForm.OK)
                {
                    if (IsEmailValid(newRecordForm.Email))
                        AddRecordProcess(new AccessInfoRecord(newRecordForm.Login, _model.GetMD5(newRecordForm.Password), newRecordForm.Email));
                    else
                        ShowError("Некорректный email.");
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
            IsSaved = false;
            _view.SaveEnable(true);
            _view.ExportEnable(true);
        }

        private bool IsEmailValid(string email)
        {
            return new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email);
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
                IsSaved = false;
                _view.SaveEnable(true);
                _view.ExportEnable(true);
            }
        }

        private void ModifyRecord()
        {
            int recordNumber = _view.GetRow();
            if (recordNumber != -1)
            {
                if (IsBinaryFileOpened | IsBdBinaryOpened)
                {
                    var path = _view.GetOpenPath("Выбрать файл");
                    if (path != null)
                        ModifyRecordProcess(recordNumber, _model.GetFileInfo(path));
                }
                if (IsJSONFileOpened | IsBdJsonOpened)
                {
                    NewRecordForm newRecordForm = new NewRecordForm();
                    newRecordForm.ShowDialog();
                    if (newRecordForm.OK)
                        ModifyRecordProcess(recordNumber, new AccessInfoRecord(newRecordForm.Login, newRecordForm.Password, newRecordForm.Email));
                    newRecordForm.Dispose();
                }
            }
        }

        private void ModifyRecordProcess(int recordNumber, IRecord record)
        {
            dataList.ChangeAt(recordNumber, record);
            bindingList.RemoveAt(recordNumber);
            bindingList.Insert(recordNumber, record);
            _view.TableUpdate(bindingList);
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Запись изменена");
            IsSaved = false;
            _view.SaveEnable(true);
            _view.ExportEnable(true);
        }

        private void Analyze()
        {
            if (_view.GetAnalyzer())
                _view.SetAnalysisResult(_model.AnalyzeFor(_view.GetConstruction()));
            else
                _view.SetAnalysisResult(_model.AnalyzeDoWhile(_view.GetConstruction()));
            _view.ChangeStatus(System.DateTime.Now.ToString() + " Анализ завершен");
        }

        private void ShowStatus()
        {
            _view.ShowStatus();
        }

        private void Complement()
        {

            try
            {
                _view.SetComplementResult(_model.AssemblyComplement(_view.GetComplementValue(), _view.GetNumeralSystem()));
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Вычисление завершено");
            }
            catch (InvalidInputDataException e)
            {
                ShowError(e.Message);
            }
        }

        private void Compare()
        {
            try
            {
                _view.SetCompareResult(_model.AssemblyCompare(_view.GetCompareValues()));
                _view.ChangeStatus(System.DateTime.Now.ToString() + " Вычисление завершено");

            }
            catch (InvalidInputDataException e)
            {
                ShowError(e.Message);
            }
            catch (Exception e)
            {
                ShowError(e.StackTrace);
            }
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
            _view.ImportAccessInfoClick += ImportAccessInfo;
            _view.ExportDataClick += ExportData;
            _view.ImportFileInfoClick += ImportFileInfo;
            _view.AddRecordClick += AddRecord;
            _view.DeleteRecordClick += DeleteRecord;
            _view.ModifyRecordClick += ModifyRecord;
            _view.AnalyzeClick += Analyze;
            _view.ShowStatusBarClick += ShowStatus;
            _view.ComplementClick += Complement;
            _view.CompareClick += Compare;
        }
    }
}