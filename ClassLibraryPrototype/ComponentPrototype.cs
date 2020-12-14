using ClassLibraryPlugins.Models;
using System;
using System.ComponentModel;

namespace ClassLibraryPrototype
{
    public partial class ComponentPrototype : Component
    {
        public ComponentPrototype()
        {
            InitializeComponent();
        }

        public ComponentPrototype(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public Product CloneProduct(string[] props)
        {
            Category categoryType = Category.Молочка;
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                if (item.ToString() == props[1])
                {
                    categoryType = (Category)item;
                }
            }
            int? amount = string.IsNullOrEmpty(props[2]) ? (int?)null : Convert.ToInt32(props[2]);
            Product obj = new Product
            {
                Name = props[0],
                Category = categoryType,
                Count = amount
            };
            return obj;
        }
    }
}