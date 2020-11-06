using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WindowsFormsComponentLibrary.WORD;

namespace WindowsFormsComponentLibrary
{
    public partial class WordDiagram : Component
    {
        public string DiagramName
        {
            set
            {
                wordDocData.DiagramName = value;
            }
        }

        public string[] Categories
        {
            set
            {
                wordDocData.CategoryNames = value;
            }
        }

        public string Path
        {
            set
            {
                wordDocData.Path = value;
            }
        }

        private readonly WordDocData wordDocData;

        public WordDiagram()
        {
            InitializeComponent();
        }

        public WordDiagram(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            wordDocData = new WordDocData();
        }

        public void SetData(DataTable data)
        {
            wordDocData.Data = data;
        }

        public void CreateDoc()
        {
            try
            {
                WordDataVerifier.CheckData(wordDocData);
                WordBuilder wordBuilder = new WordBuilder();
                wordBuilder.CreatePackage(wordDocData);
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
