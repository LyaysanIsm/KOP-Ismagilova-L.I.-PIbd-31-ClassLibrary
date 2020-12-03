using ApplicationLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Interfaces
{
    public interface IMediator
    {
        void Notify(object message, Manager manager);
    }
}
