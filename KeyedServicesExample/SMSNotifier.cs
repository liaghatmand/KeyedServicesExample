using KeyedServicesExample.Interfaces;

namespace KeyedServicesExample
{
    public class SMSNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("I'm SMSNotifier! You called me.");
        }
    }
}
