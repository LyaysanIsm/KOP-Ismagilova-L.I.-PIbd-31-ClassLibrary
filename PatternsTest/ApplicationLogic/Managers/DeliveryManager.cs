using ApplicationLogic.Abstract;
using ApplicationLogic.BindingModels;
using ApplicationLogic.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLogic.Managers
{
    public class DeliveryManager : Manager
    {
        public DeliveryManager(IMediator mediator) : base(mediator)
        {
        }

        public async void OrderAsync(DeliveryDataBindingModel model)
        {
            await Task.Run(() => OrderDelivery(model));
            mediator.Notify(model, this);
        }

        public void OrderDelivery(DeliveryDataBindingModel model)
        {
            Thread.Sleep(2000);
            if (!string.IsNullOrWhiteSpace(model.WarehouseName))
            {
                model.DeliveryDetails = $"Доставка товара {model.ProductName} " +
                    $"заказана на адрес {model.Address}";
            }
        }
    }
}
