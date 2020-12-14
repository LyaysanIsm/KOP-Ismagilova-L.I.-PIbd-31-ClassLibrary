using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Count { get; set; }

        [Required]
        public Category Category { get; set; }

        public string KindOfProduct { get; set; }

        public int Price { get; set; }
    }
}