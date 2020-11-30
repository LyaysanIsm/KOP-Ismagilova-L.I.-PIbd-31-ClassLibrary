using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDecorator
{
    public class LuxuryProduct : KindOfProductDecoratorClass
    {
        public override string getkindofproduct()
        {
            return "Люкс продукт" + (kindofproduct != null ? (" + " + kindofproduct.getkindofproduct()) : "");
        }
    }
}