using OpenModelsLibrary.Models;

namespace OpenModelsLibrary.Interfaces
{
    public interface IVisitor
    {
        void Process(ProductOpenModel productOpen);
        void Process(SupplyOpenModel supplyOpen);
    }
}
