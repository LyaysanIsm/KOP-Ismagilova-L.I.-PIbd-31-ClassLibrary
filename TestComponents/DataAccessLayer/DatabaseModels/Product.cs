using DataAccessLayer.Enums;
using System;

namespace DataAccessLayer.DatabaseModels
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasureUnit Unit { get; set; }
        public DateTime DateOfSupply { get; set; }
    }
}
