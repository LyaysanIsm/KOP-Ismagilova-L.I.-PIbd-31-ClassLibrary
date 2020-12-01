using System;

namespace ApplicationLogic.Abstract
{
    public abstract class DeliveryDecorator : AbstractDelivery
    {
        protected AbstractDelivery delivery;

        public DeliveryDecorator(AbstractDelivery delivery)
        {
            this.delivery = delivery;
        }
    }
}
