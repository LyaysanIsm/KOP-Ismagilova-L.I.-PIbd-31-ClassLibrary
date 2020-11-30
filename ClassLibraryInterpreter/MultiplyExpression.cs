using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInterpreter
{
    public class MultiplyExpression : IExpression
    {
        IExpression countExpression;
        IExpression priceExpression;

        public MultiplyExpression(IExpression count, IExpression price)
        {
            countExpression = count;
            priceExpression = price;
        }

        public int Interpret(int context)
        {
            return countExpression.Interpret(context) * priceExpression.Interpret(context);
        }
    }
}