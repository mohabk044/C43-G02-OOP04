using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface_01
{

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string[] usernames = { "admin", "user1", "user2" };
        private string[] passwords = { "password123", "user1pass", "user2pass" };
        private string[] roles = { "Administrator", "Editor", "Viewer" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}