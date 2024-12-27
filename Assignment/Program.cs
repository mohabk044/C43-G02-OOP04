using Assignment.Interface_01;
using Assignment.Interface_02;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            IAuthenticationService authService = new BasicAuthenticationService();

            Console.WriteLine("Authentication Test");
            string username = "admin";
            string password = "password123";
            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine($"User '{username}' authenticated successfully.");
            }
            else
            {
                Console.WriteLine($"Authentication failed for user '{username}'.");
            }

            Console.WriteLine("\nAuthorization Test");
            string role = "Administrator";
            if (authService.AuthorizeUser(username, role))
            {
                Console.WriteLine($"User '{username}' is authorized as '{role}'.");
            }
            else
            {
                Console.WriteLine($"User '{username}' is not authorized as '{role}'.");
            }
            #endregion

            #region Q2
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.PrintNotificationType();
            emailService.SendNotification("Mohab@Gmail.com", "Welcome to our service!");

            smsService.PrintNotificationType();
            smsService.SendNotification("01272501297", "Your OTP is 12356.");

            pushService.PrintNotificationType();
            pushService.SendNotification("DeviceToken1764", "You have a new alert.");
            #endregion

        }
    }
}