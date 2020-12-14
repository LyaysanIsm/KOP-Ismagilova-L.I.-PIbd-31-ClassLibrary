using ClassLibraryPlugins.Models;
using System;
using System.ComponentModel;

namespace BusinessLogic.VIewModel
{
    [Serializable]
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Количество на складе")]
        public int? Count { get; set; }

        [DisplayName("Категория")]
        public Category Category { get; set; }

        [DisplayName("Вид продукта")]
        public string KindOfProduct { get; set; }

        [DisplayName("Цена")]
        public int Price { get; set; }
    }
}