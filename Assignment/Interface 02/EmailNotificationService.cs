using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface_02
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }

        public void PrintNotificationType()
        {
            Console.WriteLine("This is an Email Notification Service.");
        }
    }
}