using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins.Interfaces
{
    public interface IChange<T, Y>
    {
        string Name { get; }
        void Change(T obj, Y value);
    }
}