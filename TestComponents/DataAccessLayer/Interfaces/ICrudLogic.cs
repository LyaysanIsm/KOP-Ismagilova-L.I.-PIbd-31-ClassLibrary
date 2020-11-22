using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface ICrudLogic<TBindingModel, TViewModel>
    {
        void Create(TBindingModel newItem);
        void Update(TBindingModel item);
        void Delete(TBindingModel item);
        IEnumerable<TViewModel> Read(TBindingModel conditions);
    }
}
