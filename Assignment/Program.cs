using Assignment.Interface_01;

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

        }
    }
}