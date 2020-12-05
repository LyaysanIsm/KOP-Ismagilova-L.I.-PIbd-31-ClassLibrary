using ApplicationLogic.Enums;
using System;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public MeasureUnit Unit { get; set; }
        public int Price { get; set; }
    }
}
