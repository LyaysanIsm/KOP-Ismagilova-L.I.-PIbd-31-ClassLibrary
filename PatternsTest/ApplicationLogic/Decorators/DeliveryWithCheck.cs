using ApplicationLogic.Abstract;
using System;

namespace ApplicationLogic.Decorators
{
    [Serializable]
    public class DeliveryWithCheck : DeliveryDecorator
    {
        public DeliveryWithCheck(AbstractDelivery delivery) : base (delivery)
        {
            SetOptions();
        }

        public override void SetOptions()
        {
            options.Add(" с проверкой");
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
