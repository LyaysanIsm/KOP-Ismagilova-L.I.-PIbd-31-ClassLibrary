
namespace WinFormsView
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
            this.components = new System.ComponentModel.Container();
            this.addProductButton = new System.Windows.Forms.Button();
            this.excelChartButton = new System.Windows.Forms.Button();
            this.excelReportButton = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.dataGridViewControl = new WinFormsElemsLibrary.DataGridViewControl();
            this.restoreFromBinaryComponent = new WinFormsElemsLibrary.RestoreFromBinaryComponent(this.components);
            this.excelDiagramComponent = new WinFormsElemsLibrary.ExcelDiagramComponent(this.components);
            this.excelReportComponent = new WinFormsElemsLibrary.ExcelReportComponent(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(519, 12);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(200, 50);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Добавить продукт";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // excelChartButton
            // 
            this.excelChartButton.Location = new System.Drawing.Point(519, 124);
            this.excelChartButton.Name = "excelChartButton";
            this.excelChartButton.Size = new System.Drawing.Size(200, 50);
            this.excelChartButton.TabIndex = 1;
            this.excelChartButton.Text = "Диаграмма Excel";
            this.excelChartButton.UseVisualStyleBackColor = true;
            this.excelChartButton.Click += new System.EventHandler(this.ExcelChartButton_Click);
            // 
            // excelReportButton
            // 
            this.excelReportButton.Location = new System.Drawing.Point(519, 68);
            this.excelReportButton.Name = "excelReportButton";
            this.excelReportButton.Size = new System.Drawing.Size(200, 50);
            this.excelReportButton.TabIndex = 2;
            this.excelReportButton.Text = "Отчёт Excel";
            this.excelReportButton.UseVisualStyleBackColor = true;
            this.excelReportButton.Click += new System.EventHandler(this.ExcelReportButton_Click);
            // 
            // loadFromFile
            // 
            this.loadFromFile.Location = new System.Drawing.Point(12, 319);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(249, 50);
            this.loadFromFile.TabIndex = 3;
            this.loadFromFile.Text = "Загрузить данные из файла";
            this.loadFromFile.UseVisualStyleBackColor = true;
            this.loadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // dataGridViewControl
            // 
            this.dataGridViewControl.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewControl.Name = "dataGridViewControl";
            this.dataGridViewControl.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewControl.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(268, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 50);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Бэкап";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridViewControl);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.excelReportButton);
            this.Controls.Add(this.excelChartButton);
            this.Controls.Add(this.addProductButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт продуктов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button excelChartButton;
        private System.Windows.Forms.Button excelReportButton;
        private System.Windows.Forms.Button loadFromFile;
        private WinFormsElemsLibrary.DataGridViewControl dataGridViewControl;
        private WinFormsElemsLibrary.RestoreFromBinaryComponent restoreFromBinaryComponent;
        private WinFormsElemsLibrary.ExcelDiagramComponent excelDiagramComponent;
        private WinFormsElemsLibrary.ExcelReportComponent excelReportComponent;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

