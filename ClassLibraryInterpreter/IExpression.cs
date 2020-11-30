using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInterpreter
{
    public interface IExpression
    {
        int Interpret(int context);
    }
}