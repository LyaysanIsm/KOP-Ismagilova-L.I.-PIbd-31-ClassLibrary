using System.Collections.Generic;
using System;

namespace ApplicationLogic.Abstract
{
    [Serializable]
    public abstract class AbstractDelivery
    {
        protected readonly List<string> options;

        public AbstractDelivery()
        {
            options = new List<string>();
        }

        public abstract void SetOptions();

        public virtual string GetInfo()
        {
            string info = "Тип доставки: ";
            foreach (var option in options)
            {
                info += option;
            }
            return info;
        }
    }
}
