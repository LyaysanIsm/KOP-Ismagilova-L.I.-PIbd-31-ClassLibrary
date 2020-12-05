using System;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class Supply
    {
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
