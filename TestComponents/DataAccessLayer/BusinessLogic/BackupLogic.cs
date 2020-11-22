using DataAccessLayer.DatabaseModels;
using DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataAccessLayer.BusinessLogic
{
    public class BackupLogic : IBackupLogic<Product>
    {
        private readonly DatabaseContext context;

        public BackupLogic(DatabaseContext context)
        {
            this.context = context;
        }

        public void Backup(string filename)
        {
            var products = context.Products.ToList();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, products);
            }
        }

        public void Restore(List<Product> products)
        {
            var toRemove = context.Products.ToList();
            foreach (var product in toRemove)
            {
                context.Products.Remove(product);
            }
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
