using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryComboBox
{
    public partial class ControlComboBox : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _comboBoxSelectedElementChange;

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                try
                {
                    if (value > -2 && value < comboBox.Items.Count)
                    {
                        _selectedIndex = value;
                        comboBox.SelectedIndex = _selectedIndex;
                    }
                    else if (value != 0)
                        throw new Exception("Выход за пределы массива значений");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Текст выбранной записи
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return comboBox.Text; }
        }

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChange += value; }
            remove { _comboBoxSelectedElementChange -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ControlComboBox()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => { _comboBoxSelectedElementChange?.Invoke(sender, e); };
        }

        /// <summary>
        /// Добавление в список элемента
        /// </summary>
        /// <param name="element">тип-object</param>
        public void LoadObject(object element)
        {
            comboBox.Items.Add(element.ToString());
        }
    }
}