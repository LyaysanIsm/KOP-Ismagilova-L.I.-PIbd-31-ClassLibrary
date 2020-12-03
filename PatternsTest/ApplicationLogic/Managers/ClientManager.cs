using ApplicationLogic.Abstract;
using ApplicationLogic.BindingModels;
using ApplicationLogic.Interfaces;

namespace ApplicationLogic.Managers
{
    public class ClientManager : Manager
    {
        public ClientManager(IMediator mediator) : base(mediator)
        {
        }

        public void OrderDelivery(DeliveryDataBindingModel deliveryData)
        {
            if (deliveryData != null)
            {
                mediator.Notify(deliveryData, this);
            }
        }
    }
}
