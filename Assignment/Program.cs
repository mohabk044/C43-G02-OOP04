using Assignment.First_Program;
using Assignment.Interface_01;
using Assignment.Interface_02;

namespace Assignment
{
    internal class Program
    {
        #region Part 2

        static Point3D ReadPoint()
        {
            int x, y, z;

            Console.Write("X: ");
            x = ReadInt();

            Console.Write("Y: ");
            y = ReadInt();

            Console.Write("Z: ");
            z = ReadInt();

            return new Point3D(x, y, z);
        }

        static int ReadInt()
        {
            string input;
            int result;

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
        #endregion
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

            #region Part 2 
            Console.WriteLine("Enter coordinates for Point P1:");
            Point3D P1 = ReadPoint();

            Console.WriteLine("Enter coordinates for Point P2:");
            Point3D P2 = ReadPoint();

            Console.WriteLine(P1);
            Console.WriteLine(P2);

            Console.WriteLine($"Are P1 and P2 equal? {(P1 == P2 ? "Yes" : "No")}");

            Point3D[] points = new Point3D[]
            {
            new Point3D(5, 2, 3),
            new Point3D(1, 4, 2),
            new Point3D(3, 3, 5),
            new Point3D(2, 1, 4),
            };

            Array.Sort(points);
            Console.WriteLine("\nSorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }

            Point3D clonedP1 = (Point3D)P1.Clone();
            Console.WriteLine($"\nCloned P1: {clonedP1}");
            #endregion

        }

    }
}