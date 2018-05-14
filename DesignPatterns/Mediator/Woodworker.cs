using System;

namespace DesignPatterns.Mediator
{
    public class Woodworker : Colleague
    {
        public Woodworker(Mediator mediator)
        : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to woodworker: " + message);
        }
    }
}
