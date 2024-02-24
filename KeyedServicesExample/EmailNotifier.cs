using KeyedServicesExample.Interfaces;

namespace KeyedServicesExample
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("I'm EmailNotifier! You called me.");
        }
    }
}
