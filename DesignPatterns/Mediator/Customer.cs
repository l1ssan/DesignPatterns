﻿using System;


namespace DesignPatterns.Mediator
{
  
  public class Customer : Colleague
    {
        public Customer(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to customer: " + message);
        }
    }
}
