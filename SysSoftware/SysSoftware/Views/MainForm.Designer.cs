namespace SysSoftware
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBinaryFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createJSONFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.импортироватьИзБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAccessInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.getFileInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.analizatorPage = new System.Windows.Forms.TabPage();
            this.isAnalyzerDoWhile = new System.Windows.Forms.RadioButton();
            this.isAnalyzerFor = new System.Windows.Forms.RadioButton();
            this.analysisResultLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.constructionBox = new System.Windows.Forms.GroupBox();
            this.constructionTextBox = new System.Windows.Forms.RichTextBox();
            this.filePage = new System.Windows.Forms.TabPage();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.modifyRecord = new System.Windows.Forms.Button();
            this.addRecord = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.functionPage = new System.Windows.Forms.TabPage();
            this.compareFunctionBox = new System.Windows.Forms.GroupBox();
            this.compareLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.execCompare = new System.Windows.Forms.Button();
            this.compareSecondOperand = new System.Windows.Forms.TextBox();
            this.compareFirstOperand = new System.Windows.Forms.TextBox();
            this.complementFunctionBox = new System.Windows.Forms.GroupBox();
            this.complementResultText = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.execComplement = new System.Windows.Forms.Button();
            this.formatBox = new System.Windows.Forms.GroupBox();
            this.decRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.binRadioButton = new System.Windows.Forms.RadioButton();
            this.complementValue = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.analizatorPage.SuspendLayout();
            this.constructionBox.SuspendLayout();
            this.filePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.functionPage.SuspendLayout();
            this.compareFunctionBox.SuspendLayout();
            this.complementFunctionBox.SuspendLayout();
            this.formatBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(545, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.openFileMenu,
            this.toolStripSeparator2,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.toolStripSeparator3,
            this.closeFileMenu,
            this.toolStripSeparator1,
            this.импортироватьИзБДToolStripMenuItem,
            this.saveInfoMenu,
            this.toolStripSeparator4,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBinaryFileMenu,
            this.createJSONFileMenu});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // createBinaryFileMenu
            // 
            this.createBinaryFileMenu.Name = "createBinaryFileMenu";
            this.createBinaryFileMenu.Size = new System.Drawing.Size(172, 22);
            this.createBinaryFileMenu.Text = "Бинарный файл...";
            // 
            // createJSONFileMenu
            // 
            this.createJSONFileMenu.Name = "createJSONFileMenu";
            this.createJSONFileMenu.Size = new System.Drawing.Size(172, 22);
            this.createJSONFileMenu.Text = "Файл JSON...";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(195, 22);
            this.openFileMenu.Text = "Открыть...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Enabled = false;
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.Size = new System.Drawing.Size(195, 22);
            this.saveFileMenu.Text = "Сохранить";
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.Enabled = false;
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(195, 22);
            this.saveAsFileMenu.Text = "Сохранить как...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // closeFileMenu
            // 
            this.closeFileMenu.Enabled = false;
            this.closeFileMenu.Name = "closeFileMenu";
            this.closeFileMenu.Size = new System.Drawing.Size(195, 22);
            this.closeFileMenu.Text = "Закрыть";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // импортироватьИзБДToolStripMenuItem
            // 
            this.импортироватьИзБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAccessInfoMenu,
            this.getFileInfoMenu});
            this.импортироватьИзБДToolStripMenuItem.Name = "импортироватьИзБДToolStripMenuItem";
            this.импортироватьИзБДToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.импортироватьИзБДToolStripMenuItem.Text = "Импортировать из БД";
            // 
            // getAccessInfoMenu
            // 
            this.getAccessInfoMenu.Name = "getAccessInfoMenu";
            this.getAccessInfoMenu.Size = new System.Drawing.Size(173, 22);
            this.getAccessInfoMenu.Text = "Данные о доступе";
            // 
            // getFileInfoMenu
            // 
            this.getFileInfoMenu.Name = "getFileInfoMenu";
            this.getFileInfoMenu.Size = new System.Drawing.Size(173, 22);
            this.getFileInfoMenu.Text = "Данные о файлах";
            // 
            // saveInfoMenu
            // 
            this.saveInfoMenu.Enabled = false;
            this.saveInfoMenu.Name = "saveInfoMenu";
            this.saveInfoMenu.Size = new System.Drawing.Size(195, 22);
            this.saveInfoMenu.Text = "Экспортировать в БД";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMenu});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // statusBarMenu
            // 
            this.statusBarMenu.Checked = true;
            this.statusBarMenu.CheckOnClick = true;
            this.statusBarMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarMenu.Name = "statusBarMenu";
            this.statusBarMenu.Size = new System.Drawing.Size(173, 22);
            this.statusBarMenu.Text = "Строка состояния";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.analizatorPage);
            this.mainTabControl.Controls.Add(this.filePage);
            this.mainTabControl.Controls.Add(this.functionPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(525, 433);
            this.mainTabControl.TabIndex = 10;
            // 
            // analizatorPage
            // 
            this.analizatorPage.Controls.Add(this.isAnalyzerDoWhile);
            this.analizatorPage.Controls.Add(this.isAnalyzerFor);
            this.analizatorPage.Controls.Add(this.analysisResultLabel);
            this.analizatorPage.Controls.Add(this.analyzeButton);
            this.analizatorPage.Controls.Add(this.constructionBox);
            this.analizatorPage.Location = new System.Drawing.Point(4, 22);
            this.analizatorPage.Name = "analizatorPage";
            this.analizatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.analizatorPage.Size = new System.Drawing.Size(517, 407);
            this.analizatorPage.TabIndex = 0;
            this.analizatorPage.Text = "Анализатор";
            this.analizatorPage.UseVisualStyleBackColor = true;
            // 
            // isAnalyzerDoWhile
            // 
            this.isAnalyzerDoWhile.AutoSize = true;
            this.isAnalyzerDoWhile.Location = new System.Drawing.Point(14, 31);
            this.isAnalyzerDoWhile.Name = "isAnalyzerDoWhile";
            this.isAnalyzerDoWhile.Size = new System.Drawing.Size(132, 17);
            this.isAnalyzerDoWhile.TabIndex = 4;
            this.isAnalyzerDoWhile.Text = "Анализатор Do-While";
            this.isAnalyzerDoWhile.UseVisualStyleBackColor = true;
            // 
            // isAnalyzerFor
            // 
            this.isAnalyzerFor.AutoSize = true;
            this.isAnalyzerFor.Checked = true;
            this.isAnalyzerFor.Location = new System.Drawing.Point(14, 7);
            this.isAnalyzerFor.Name = "isAnalyzerFor";
            this.isAnalyzerFor.Size = new System.Drawing.Size(103, 17);
            this.isAnalyzerFor.TabIndex = 3;
            this.isAnalyzerFor.TabStop = true;
            this.isAnalyzerFor.Text = "Анализатор For";
            this.isAnalyzerFor.UseVisualStyleBackColor = true;
            // 
            // analysisResultLabel
            // 
            this.analysisResultLabel.AutoSize = true;
            this.analysisResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analysisResultLabel.Location = new System.Drawing.Point(4, 366);
            this.analysisResultLabel.Name = "analysisResultLabel";
            this.analysisResultLabel.Size = new System.Drawing.Size(0, 16);
            this.analysisResultLabel.TabIndex = 2;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(7, 330);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Анализ";
            this.analyzeButton.UseVisualStyleBackColor = true;
            // 
            // constructionBox
            // 
            this.constructionBox.Controls.Add(this.constructionTextBox);
            this.constructionBox.Location = new System.Drawing.Point(7, 61);
            this.constructionBox.Name = "constructionBox";
            this.constructionBox.Size = new System.Drawing.Size(504, 263);
            this.constructionBox.TabIndex = 0;
            this.constructionBox.TabStop = false;
            this.constructionBox.Text = "Конструкция";
            // 
            // constructionTextBox
            // 
            this.constructionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.constructionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constructionTextBox.Location = new System.Drawing.Point(7, 20);
            this.constructionTextBox.Name = "constructionTextBox";
            this.constructionTextBox.Size = new System.Drawing.Size(491, 237);
            this.constructionTextBox.TabIndex = 0;
            this.constructionTextBox.Text = "double i = 0;\nfor ( int j = 0; j < 14; j++ )\n{\n       i = (i + 5) / 2;\n}";
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.deleteRecord);
            this.filePage.Controls.Add(this.modifyRecord);
            this.filePage.Controls.Add(this.addRecord);
            this.filePage.Controls.Add(this.table);
            this.filePage.Location = new System.Drawing.Point(4, 22);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(517, 407);
            this.filePage.TabIndex = 1;
            this.filePage.Text = "Работа с данными";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(168, 378);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(75, 23);
            this.deleteRecord.TabIndex = 3;
            this.deleteRecord.Text = "Удалить";
            this.deleteRecord.UseVisualStyleBackColor = true;
            // 
            // modifyRecord
            // 
            this.modifyRecord.Location = new System.Drawing.Point(87, 378);
            this.modifyRecord.Name = "modifyRecord";
            this.modifyRecord.Size = new System.Drawing.Size(75, 23);
            this.modifyRecord.TabIndex = 2;
            this.modifyRecord.Text = "Изменить";
            this.modifyRecord.UseVisualStyleBackColor = true;
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(6, 378);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(75, 23);
            this.addRecord.TabIndex = 1;
            this.addRecord.Text = "Добавить";
            this.addRecord.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(6, 3);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(505, 369);
            this.table.TabIndex = 0;
            // 
            // functionPage
            // 
            this.functionPage.Controls.Add(this.compareFunctionBox);
            this.functionPage.Controls.Add(this.complementFunctionBox);
            this.functionPage.Location = new System.Drawing.Point(4, 22);
            this.functionPage.Name = "functionPage";
            this.functionPage.Padding = new System.Windows.Forms.Padding(3);
            this.functionPage.Size = new System.Drawing.Size(517, 407);
            this.functionPage.TabIndex = 2;
            this.functionPage.Text = "Низкоуровневая функция";
            this.functionPage.UseVisualStyleBackColor = true;
            // 
            // compareFunctionBox
            // 
            this.compareFunctionBox.Controls.Add(this.compareLabel);
            this.compareFunctionBox.Controls.Add(this.label2);
            this.compareFunctionBox.Controls.Add(this.label1);
            this.compareFunctionBox.Controls.Add(this.execCompare);
            this.compareFunctionBox.Controls.Add(this.compareSecondOperand);
            this.compareFunctionBox.Controls.Add(this.compareFirstOperand);
            this.compareFunctionBox.Location = new System.Drawing.Point(260, 7);
            this.compareFunctionBox.Name = "compareFunctionBox";
            this.compareFunctionBox.Size = new System.Drawing.Size(249, 394);
            this.compareFunctionBox.TabIndex = 1;
            this.compareFunctionBox.TabStop = false;
            this.compareFunctionBox.Text = "Сравнение";
            // 
            // compareLabel
            // 
            this.compareLabel.AutoSize = true;
            this.compareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compareLabel.Location = new System.Drawing.Point(117, 52);
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(0, 15);
            this.compareLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Правый операнд:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Левый операнд:";
            // 
            // execCompare
            // 
            this.execCompare.Location = new System.Drawing.Point(7, 91);
            this.execCompare.Name = "execCompare";
            this.execCompare.Size = new System.Drawing.Size(75, 23);
            this.execCompare.TabIndex = 2;
            this.execCompare.Text = "Сравнить";
            this.execCompare.UseVisualStyleBackColor = true;
            // 
            // compareSecondOperand
            // 
            this.compareSecondOperand.Location = new System.Drawing.Point(143, 50);
            this.compareSecondOperand.Name = "compareSecondOperand";
            this.compareSecondOperand.Size = new System.Drawing.Size(100, 20);
            this.compareSecondOperand.TabIndex = 1;
            // 
            // compareFirstOperand
            // 
            this.compareFirstOperand.Location = new System.Drawing.Point(7, 50);
            this.compareFirstOperand.Name = "compareFirstOperand";
            this.compareFirstOperand.Size = new System.Drawing.Size(100, 20);
            this.compareFirstOperand.TabIndex = 0;
            // 
            // complementFunctionBox
            // 
            this.complementFunctionBox.Controls.Add(this.complementResultText);
            this.complementFunctionBox.Controls.Add(this.resultLabel);
            this.complementFunctionBox.Controls.Add(this.execComplement);
            this.complementFunctionBox.Controls.Add(this.formatBox);
            this.complementFunctionBox.Controls.Add(this.complementValue);
            this.complementFunctionBox.Controls.Add(this.dataLabel);
            this.complementFunctionBox.Location = new System.Drawing.Point(7, 7);
            this.complementFunctionBox.Name = "complementFunctionBox";
            this.complementFunctionBox.Size = new System.Drawing.Size(250, 394);
            this.complementFunctionBox.TabIndex = 0;
            this.complementFunctionBox.TabStop = false;
            this.complementFunctionBox.Text = "Побитовое дополнение";
            // 
            // complementResultText
            // 
            this.complementResultText.Location = new System.Drawing.Point(7, 264);
            this.complementResultText.MaxLength = 32768;
            this.complementResultText.Name = "complementResultText";
            this.complementResultText.ReadOnly = true;
            this.complementResultText.Size = new System.Drawing.Size(200, 20);
            this.complementResultText.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(7, 245);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(71, 15);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Результат:";
            // 
            // execComplement
            // 
            this.execComplement.Location = new System.Drawing.Point(10, 201);
            this.execComplement.Name = "execComplement";
            this.execComplement.Size = new System.Drawing.Size(75, 23);
            this.execComplement.TabIndex = 3;
            this.execComplement.Text = "Вычислить";
            this.execComplement.UseVisualStyleBackColor = true;
            // 
            // formatBox
            // 
            this.formatBox.Controls.Add(this.decRadioButton);
            this.formatBox.Controls.Add(this.hexRadioButton);
            this.formatBox.Controls.Add(this.binRadioButton);
            this.formatBox.Location = new System.Drawing.Point(10, 91);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(164, 94);
            this.formatBox.TabIndex = 2;
            this.formatBox.TabStop = false;
            this.formatBox.Text = "Формат данных результата";
            // 
            // decRadioButton
            // 
            this.decRadioButton.AutoSize = true;
            this.decRadioButton.Location = new System.Drawing.Point(7, 44);
            this.decRadioButton.Name = "decRadioButton";
            this.decRadioButton.Size = new System.Drawing.Size(47, 17);
            this.decRadioButton.TabIndex = 3;
            this.decRadioButton.TabStop = true;
            this.decRadioButton.Text = "DEC";
            this.decRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Checked = true;
            this.hexRadioButton.Location = new System.Drawing.Point(7, 67);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(47, 17);
            this.hexRadioButton.TabIndex = 2;
            this.hexRadioButton.TabStop = true;
            this.hexRadioButton.Text = "HEX";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            // 
            // binRadioButton
            // 
            this.binRadioButton.AutoSize = true;
            this.binRadioButton.Location = new System.Drawing.Point(7, 20);
            this.binRadioButton.Name = "binRadioButton";
            this.binRadioButton.Size = new System.Drawing.Size(43, 17);
            this.binRadioButton.TabIndex = 0;
            this.binRadioButton.Text = "BIN";
            this.binRadioButton.UseVisualStyleBackColor = true;
            // 
            // complementValue
            // 
            this.complementValue.Location = new System.Drawing.Point(10, 50);
            this.complementValue.Name = "complementValue";
            this.complementValue.Size = new System.Drawing.Size(118, 20);
            this.complementValue.TabIndex = 1;
            this.complementValue.Text = "10011001";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Location = new System.Drawing.Point(7, 31);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(56, 15);
            this.dataLabel.TabIndex = 0;
            this.dataLabel.Text = "Данные:";
            // 
            // statusBar
            // 
            this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusBar.Location = new System.Drawing.Point(0, 463);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(545, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 11;
            this.statusBar.Text = "statusBar";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 485);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysSoftware";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.analizatorPage.ResumeLayout(false);
            this.analizatorPage.PerformLayout();
            this.constructionBox.ResumeLayout(false);
            this.filePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.functionPage.ResumeLayout(false);
            this.compareFunctionBox.ResumeLayout(false);
            this.compareFunctionBox.PerformLayout();
            this.complementFunctionBox.ResumeLayout(false);
            this.complementFunctionBox.PerformLayout();
            this.formatBox.ResumeLayout(false);
            this.formatBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarMenu;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage analizatorPage;
        private System.Windows.Forms.TabPage filePage;
        private System.Windows.Forms.TabPage functionPage;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox constructionBox;
        private System.Windows.Forms.RichTextBox constructionTextBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button modifyRecord;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox complementFunctionBox;
        private System.Windows.Forms.TextBox complementValue;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.GroupBox formatBox;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private System.Windows.Forms.RadioButton binRadioButton;
        private System.Windows.Forms.TextBox complementResultText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button execComplement;
        private System.Windows.Forms.ToolStripMenuItem createBinaryFileMenu;
        private System.Windows.Forms.ToolStripMenuItem createJSONFileMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label analysisResultLabel;
        private System.Windows.Forms.RadioButton isAnalyzerDoWhile;
        private System.Windows.Forms.RadioButton isAnalyzerFor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenu;
        private System.Windows.Forms.ToolStripMenuItem импортироватьИзБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAccessInfoMenu;
        private System.Windows.Forms.ToolStripMenuItem getFileInfoMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem saveInfoMenu;
        private System.Windows.Forms.GroupBox compareFunctionBox;
        private System.Windows.Forms.Button execCompare;
        private System.Windows.Forms.TextBox compareSecondOperand;
        private System.Windows.Forms.TextBox compareFirstOperand;
        private System.Windows.Forms.Label compareLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton decRadioButton;
    }
}

