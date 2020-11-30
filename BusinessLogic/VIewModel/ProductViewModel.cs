using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
    }
}