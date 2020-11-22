using DataAccessLogic.Enums;
using System;

namespace DataAccessLogic.BindingModels
{
    public class ProductBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public MeasureUnit Unit { get; set; }
        public DateTime DateOfSupply { get; set; }
    }
}
