using DataAccessLayer.BindingModels;
using DataAccessLayer.DatabaseModels;
using DataAccessLayer.Interfaces;
using DataAccessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace WinFormsView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICrudLogic<ProductBindingModel, ProductViewModel> logic;
        private readonly IBackupLogic<Product> backup;

        public MainForm(ICrudLogic<ProductBindingModel, ProductViewModel> logic,
            IBackupLogic<Product> backup)
        {
            InitializeComponent();
            this.logic = logic;
            this.backup = backup;
            LoadData();
        }

        private void LoadData()
        {
            var products = logic.Read(null).ToList();
            dataGridViewControl.SetHeaders(new string[] { "Наименование", "Ед. измерения", "Дата поставки"});
            dataGridViewControl.SetData(products, 1);
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var products = restoreFromBinaryComponent
                    .Deserialize<List<Product>>(openFileDialog.FileName, 
                    Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                backup.Restore(products);
                LoadData();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                backup.Backup(saveFileDialog.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var productForm = Container.Resolve<ProductCreationForm>();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ExcelReportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = string.Empty;
            saveFileDialog.Filter = "Файлы Excel|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var products = logic.Read(null).ToList();
                    excelReportComponent.DisplayInExcel(products, saveFileDialog.FileName, 
                        "Список продуктов", new Dictionary<string, string>());
                    MessageBox.Show("Сохранение прошло успешно", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExcelChartButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = string.Empty;
            saveFileDialog.Filter = "Файлы Excel|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Tuple<string, int>> data = new List<Tuple<string, int>>();
                    var groups = logic.Read(null).GroupBy(product => product.Unit).Select(group => new
                    {
                        Name = group.Key,
                        Value = group.Count()
                    });
                    foreach (var productGroup in groups)
                    {
                        data.Add(new Tuple<string, int>(productGroup.Name, productGroup.Value));
                    }
                    excelDiagramComponent.BuiltChart(data, saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
