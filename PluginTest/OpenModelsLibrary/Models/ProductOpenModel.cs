using OpenModelsLibrary.Enums;
using OpenModelsLibrary.Interfaces;

namespace OpenModelsLibrary.Models
{
    public class ProductOpenModel : IVisitable 
    {
        public string Name { get; set; }
        public MeasureUnitOpenEnum Unit { get; set; }
        public int Price { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Process(this);
        }
    }
}
