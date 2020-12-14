using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins.Interfaces
{
    public interface IWaybill<T>
    {
        string Name { get; }
        void Create(T obj);
    }
}