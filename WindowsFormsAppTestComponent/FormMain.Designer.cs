namespace WindowsFormsAppTestComponent
{
    partial class FormMain
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
            this.controlTree = new ClassLibraryControlSelected.ControlTreeView();
            this.componentSaveDataBinary = new WindowsFormsComponentLibrary.Data.ComponentSaveDataBinary(this.components);
            this.componentWordChart = new KOP_laba2.ComponentWord(this.components);
            this.wordReportComponent = new ClassLibraryWordComponent.WordReportComponent(this.components);
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonClone = new System.Windows.Forms.Button();
            this.comboBoxPlugins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.componentPrototype1 = new ClassLibraryPrototype.ComponentPrototype(this.components);
            this.buttonPlugin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(12, 12);
            this.controlTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTree.Name = "controlTree";
            this.controlTree.SelectedNode = null;
            this.controlTree.Size = new System.Drawing.Size(511, 237);
            this.controlTree.TabIndex = 0;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(12, 292);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(93, 26);
            this.buttonBackup.TabIndex = 1;
            this.buttonBackup.Text = "Бекап";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(430, 292);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(93, 26);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(151, 292);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(110, 26);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Диаграмма";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(302, 292);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(93, 26);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonClone
            // 
            this.buttonClone.Location = new System.Drawing.Point(551, 292);
            this.buttonClone.Name = "buttonClone";
            this.buttonClone.Size = new System.Drawing.Size(109, 26);
            this.buttonClone.TabIndex = 6;
            this.buttonClone.Text = "Клонировать";
            this.buttonClone.UseVisualStyleBackColor = true;
            this.buttonClone.Click += new System.EventHandler(this.buttonClone_Click);
            // 
            // comboBoxPlugins
            // 
            this.comboBoxPlugins.FormattingEnabled = true;
            this.comboBoxPlugins.Location = new System.Drawing.Point(528, 39);
            this.comboBoxPlugins.Name = "comboBoxPlugins";
            this.comboBoxPlugins.Size = new System.Drawing.Size(319, 21);
            this.comboBoxPlugins.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Плагины:";
            // 
            // buttonPlugin
            // 
            this.buttonPlugin.Location = new System.Drawing.Point(614, 84);
            this.buttonPlugin.Name = "buttonPlugin";
            this.buttonPlugin.Size = new System.Drawing.Size(133, 23);
            this.buttonPlugin.TabIndex = 16;
            this.buttonPlugin.Text = "Плагин";
            this.buttonPlugin.UseVisualStyleBackColor = true;
            this.buttonPlugin.Click += new System.EventHandler(this.buttonPlugin_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 330);
            this.Controls.Add(this.buttonPlugin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlugins);
            this.Controls.Add(this.buttonClone);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.controlTree);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsComponentLibrary.Data.ComponentSaveDataBinary componentSaveDataBinary;
        private ClassLibraryControlSelected.ControlTreeView controlTree;
        private KOP_laba2.ComponentWord componentWordChart;
        private ClassLibraryWordComponent.WordReportComponent wordReportComponent;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonClone;
        private ClassLibraryPrototype.ComponentPrototype componentPrototype1;
        private System.Windows.Forms.ComboBox comboBoxPlugins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlugin;
    }
}