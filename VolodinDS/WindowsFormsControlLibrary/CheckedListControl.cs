using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class CheckedListControl : UserControl
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CheckedListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод инициализации списка значений
        /// </summary>
        /// <typeparam name="T">Любой тип</typeparam>
        /// <param name="items">Список объектов, на основе которого будет
        /// создан список</param>
        public void InsertItems<T>(List<T> items)
        {
            foreach (var item in items)
            {
                checkedListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Метод для получения списка помеченных объектов
        /// </summary>
        /// <returns>Список помеченных объектов</returns>
        public List<object> GetCheckedItems()
        {
            List<object> checkedItems = new List<object>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            return checkedItems;
        }

        /// <summary>
        /// Метод для получения индексов помеченных объектов списка
        /// </summary>
        /// <returns>Список индексов помеченных объектов списка</returns>
        public List<int> GetCheckedIndices()
        {
            List<int> checkedIndices = new List<int>();
            for (int i = 0; i < checkedListBox.CheckedIndices.Count; i++)
            {
                checkedIndices.Add(checkedListBox.CheckedIndices[i]);
            }
            return checkedIndices;
        }

        /// <summary>
        /// Метод отмечает объекты по индексам
        /// </summary>
        /// <param name="indices">Список индексов</param>
        public void SetCheckedIndices(List<int> indices)
        {
            try
            {
                foreach (int index in indices)
                {
                    checkedListBox.SetItemChecked(index, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                     ex.Message,
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод, отмечающий в списке определенные объекты
        /// </summary>
        /// <param name="items">Список объектов, которые необходимо отметить</param>
        public void SetCheckedItems(List<object> items)
        {
            foreach (var item in items)
            {
                if (checkedListBox.Items.Contains(item))
                {
                    int index = checkedListBox.Items.IndexOf(item);
                    checkedListBox.SetItemChecked(index, true);
                }
            }
        }
    }
}
