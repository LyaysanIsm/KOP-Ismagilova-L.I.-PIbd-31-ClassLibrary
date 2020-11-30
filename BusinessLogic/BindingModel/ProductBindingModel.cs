using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
    public class ProductBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int? Count { get; set; }

        public Category Category { get; set; }
        public string KindOfProduct { get; set; }
    }
}