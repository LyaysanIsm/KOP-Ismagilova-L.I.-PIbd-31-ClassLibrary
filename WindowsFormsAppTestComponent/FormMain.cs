using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.VIewModel;
using ClassLibraryPlugins;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsAppTestComponent
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly PluginManager manager;
        private readonly IProductLogic logic;

        public FormMain(IProductLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            controlTree.Order("Name", "Category", "Count", "KindOfProduct");

            manager = new PluginManager();
            if (manager.Headers != null && manager.Headers.Count() != 0)
            {
                comboBoxPlugins.Items.AddRange(manager.Headers.ToArray());
                comboBoxPlugins.Text = comboBoxPlugins.Items[0].ToString();
            }
        }

        private void LoadData()
        {
            controlTree.ClearNodes();
            List<ProductViewModel> list = new List<ProductViewModel>();
            var products = logic.Read(null);
            if (products != null)
            {
                foreach (var product in products)
                {
                    list.Add(product);
                }
                controlTree.BuildTree(list);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreate>();
            form.ShowDialog();
            LoadData();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            var products = logic.Read(null);
            using (var dialog = new SaveFileDialog { })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        componentSaveDataBinary.SaveData(dialog.FileName, products.ToList());
                        MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            var products = logic.Read(null);
            DataTable table = new DataTable();
            DataColumn firstColumn = new DataColumn("Продукты");
            table.Columns.Add(firstColumn);
            List<string> names = new List<string>();
            foreach (var product in products)
            {
                table.Rows.Add(product.Count);
                names.Add(product.Name);
            }
            componentWordChart.Categories = names.ToArray();
            componentWordChart.DiagramName = "Гистограмма по продуктам";
            componentWordChart.SetData(table);
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentWordChart.Path = dialog.FileName;
                    componentWordChart.CreateDoc();
                }
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var products = logic.Read(null);
            int count = 0;
            Product[] classProducts = new Product[products.Count];
            foreach (var product in products)
            {
                classProducts[count] = new Product
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = product.Category,
                    Count = product.Count,
                    KindOfProduct = product.KindOfProduct
                };
                count++;
            }
            for (int i = 0; i < classProducts.Length; i++)
            {
                Console.WriteLine(classProducts[i]);
            }
            using (var dialog = new SaveFileDialog { Filter = "*.docx|*.doc" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        wordReportComponent.AddTable<Product>(classProducts.ToList(), "Продукты", dialog.FileName);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonClone_Click(object sender, EventArgs e)
        {
            string[] elems = controlTree.FullPath;
            Product obj = componentPrototype1.CloneProduct(elems);
            // controlTree.addNode(obj.Clone());
        }

        private void buttonPlugin_Click(object sender, EventArgs e)
        {
            if (comboBoxPlugins.Text == "Изменение категории продуктов")
            {
                var product = logic.Read(null)[controlTree.Index];
                string cng = comboBoxPlugins.Text;
                var form = new FormChangeCategory(cng, product, manager, logic);
                form.ShowDialog();
                LoadData();
            }
            else if (comboBoxPlugins.Text == "Пополнение склада")
            {
                var product = logic.Read(null)[controlTree.Index];
                string cng = comboBoxPlugins.Text;
                var form = new FormAdd(cng, product, manager, logic);
                form.ShowDialog();
                LoadData();
            }
            else if (comboBoxPlugins.Text == "Формирование накладной")
            {
                if (manager == null)
                {
                    return;
                }
                if (string.IsNullOrEmpty(controlTree.SelectedNode))
                {
                    MessageBox.Show("Выберите продукт", "Ошибка");
                    return;
                }
                var product = logic.Read(null)[controlTree.Index];
                string cng = comboBoxPlugins.Text;

                Product obj = new Product
                {
                    Id = product.Id,
                    Name = product.Name,
                    KindOfProduct = product.KindOfProduct,
                    Category = product.Category,
                    Count = product.Count
                };
                manager.WaybillsDict[cng](obj);
            }
        }
    }
}