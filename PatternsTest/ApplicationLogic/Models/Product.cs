using ApplicationLogic.Interfaces;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ApplicationLogic.Models
{
    [Serializable]
    public class Product : IPrototype
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Company Manufacturer { get; set; }

        public object Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (Product)formatter.Deserialize(stream);
            }
        }
    }
}
