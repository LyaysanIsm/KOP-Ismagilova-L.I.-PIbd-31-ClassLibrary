using ApplicationLogic.Abstract;
using System;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class CourierDelivery : AbstractDelivery
    {
        public CourierDelivery() : base()
        {
            SetOptions();
        }

        public override void SetOptions()
        {
            options.Add("курьером до дома");
        }
    }
}
