using ApplicationLogic.Abstract;
using System;

namespace ApplicationLogic.Decorators
{
    public class ContactlessDelivery : DeliveryDecorator
    {
        public ContactlessDelivery(AbstractDelivery delivery) : base(delivery)
        {
            SetOptions();
        }

        public override void SetOptions()
        {
            options.Add(" c бесконтактной передачей");
        }

        public override string GetInfo()
        {
            string info = delivery.GetInfo();
            foreach (var option in options)
            {
                info += option;
            }
            return info;
        }
    }
}
