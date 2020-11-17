using BusinessLogic.BindingModel;
using BusinessLogic.VIewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        void CreateOrUpdate(ProductBindingModel model);
        List<ProductViewModel> Read(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}