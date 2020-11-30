using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDecorator
{
    public class NormalProduct : KindOfProductDecoratorClass
    {
        public override string getkindofproduct()
        {
            return "Обычный продукт" + (kindofproduct != null ? ("+" + kindofproduct.getkindofproduct()) : "");
        }
    }
}
