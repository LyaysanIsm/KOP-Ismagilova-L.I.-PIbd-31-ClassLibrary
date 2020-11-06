using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WindowsFormsComponentLibrary.PDF;

namespace WindowsFormsComponentLibrary
{
    public partial class TablePDF : Component
    {
        private DocParams docParams;

        public TablePDF()
        {
            InitializeComponent();
        }

        public TablePDF(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void SetTableData(DataTable data, int[] cellsToUnify)
        {
            docParams = new DocParams
            {
                Data = data,
                CellsToUnify = cellsToUnify
            };
        }

        public void SaveDoc(string path)
        {
            try
            {
                docParams.Path = path;
                DocumentBuilder.BuildDoc(docParams);
                MessageBox.Show("Сохранение прошло успешно", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
