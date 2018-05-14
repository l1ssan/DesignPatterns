using System;


namespace DesignPatterns.Mediator
{
    public class Vendor:Colleague
    {
        public Vendor(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to vendor: " + message);
        }
    }
}
