using ApplicationLogic.Interfaces;

namespace ApplicationLogic.Abstract
{
    public abstract class Manager
    {
        protected IMediator mediator;

        public Manager(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
