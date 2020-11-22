using DataAccessLogic.Enums;
using System;

namespace DataAccessLogic.DatabaseModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasureUnit Unit { get; set; }
        public DateTime DateOfSupply { get; set; }
    }
}
