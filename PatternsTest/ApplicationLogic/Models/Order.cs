using System;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class Order
    { 
        public Product Product { get; set; }
        public int Count { get; set; }
        public string Delivery { get; set; }
    }
}
