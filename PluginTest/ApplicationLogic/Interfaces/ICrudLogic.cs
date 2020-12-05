using System.Collections.Generic;

namespace ApplicationLogic.Interfaces
{
    public interface ICrudLogic<TModel>
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        List<TModel> Read(TModel model);
    }
}
