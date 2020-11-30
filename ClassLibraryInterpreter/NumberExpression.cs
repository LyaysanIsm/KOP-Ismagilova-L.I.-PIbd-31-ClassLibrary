using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInterpreter
{
    public class NumberExpression : IExpression
    {
        int value;
        public NumberExpression(int _value)
        {
            value = _value;
        }
        public int Interpret(int context)
        {
            return value;
        }
    }
}