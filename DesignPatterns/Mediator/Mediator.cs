
namespace DesignPatterns.Mediator
{
    public abstract class Mediator
    {

        public abstract void Send(string msg, Colleague colleague);
    }

    public abstract class Colleague
    {
        protected Mediator mediator;

        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}
