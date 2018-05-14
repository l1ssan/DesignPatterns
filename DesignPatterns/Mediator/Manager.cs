

namespace DesignPatterns.Mediator
{
    public class Manager : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague WoodWorker { get; set; }
        public Colleague Vendor { get; set; }

        public override void Send(string msg, Colleague colleague)
        {

            //notify worker to do request
            if (Customer == colleague)
                WoodWorker.Notify(msg);

            //send job to vendor
            else if (WoodWorker == colleague)
                Vendor.Notify(msg);

            //job is done
            else if (Vendor == colleague)
                Customer.Notify(msg);
        }
    }
}
