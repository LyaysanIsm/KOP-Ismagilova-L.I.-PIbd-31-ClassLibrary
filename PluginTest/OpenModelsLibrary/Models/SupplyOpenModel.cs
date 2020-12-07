using OpenModelsLibrary.Interfaces;
using System;

namespace OpenModelsLibrary.Models
{
    public class SupplyOpenModel : IVisitable
    {
        public ProductOpenModel Product { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Process(this);
        }
    }
}
