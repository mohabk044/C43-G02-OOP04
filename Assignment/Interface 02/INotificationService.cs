using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface_02
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);

        public void PrintNotificationType()
        {
            Console.WriteLine("This is a generic notification service.");
        }
    }
}