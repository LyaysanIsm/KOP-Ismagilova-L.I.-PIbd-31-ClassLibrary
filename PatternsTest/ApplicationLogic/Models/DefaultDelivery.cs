using ApplicationLogic.Abstract;
using System;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class DefaultDelivery : AbstractDelivery
    {
        public DefaultDelivery() : base()
        {
            SetOptions();
        }

        public override void SetOptions()
        {
            options.Add("до ближайшего пункта выдачи");
        }
    }
}
