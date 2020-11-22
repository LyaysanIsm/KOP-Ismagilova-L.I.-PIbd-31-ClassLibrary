using System.ComponentModel;

namespace DataAccessLayer.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string DateOfSupply { get; set; }
    }
}
