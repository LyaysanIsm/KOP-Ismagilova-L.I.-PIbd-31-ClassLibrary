using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class TreeViewControl : UserControl
    {
        /// <summary>
        /// Массив имен свойств
        /// </summary>
        private string[] propNames;

        /// <summary>
        /// Задает или возвращает выделенный узел дерева
        /// </summary>
        public string Selected
        {
            get
            {
                return treeView.SelectedNode?.Name;
            }
            set
            {
                TreeNode selected = treeView.Nodes.Find(value, true)?[0];
                if (selected != null)
                {
                    treeView.SelectedNode = selected;
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TreeViewControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод устанавливает порядок построения дерева
        /// </summary>
        /// <param name="props">Имена свойств</param>
        public void SetPropsOrder(params string[] props)
        {
            treeView.Nodes.Clear();
            propNames = props;
        }

        /// <summary>
        /// Метод построения дерева на основе имен свойств объектов, 
        /// содержащихся в списке treeItems, имена берутся в том порядке,
        /// в котором они содержатся в массиве  propNames
        /// </summary>
        public void BuildTree<T>(List<T> items)
        {
            if (propNames !=null)
            {
                foreach (var item in items)
                {
                    var nodes = treeView.Nodes;
                    foreach (var prop in propNames)
                    {
                        string propValue = item.GetType().GetProperty(prop)?.GetValue(item).ToString();
                        if (!nodes.ContainsKey(propValue))
                        {
                            TreeNode treeNode = new TreeNode
                            {
                                Name = propValue,
                                Text = propValue
                            };
                            nodes.Add(treeNode);
                            nodes = treeNode.Nodes;
                        }
                        else
                        {
                            nodes = nodes.Find(propValue, false)?[0].Nodes;
                        }
                    }
                }
                treeView.Refresh();
            }
        }
    }
}
