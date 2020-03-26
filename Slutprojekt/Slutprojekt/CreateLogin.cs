using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class CreateLogin
    {
        static string username = "";
        static string password;

        static public void CreateUser()
        {
            Console.WriteLine("Set a username:");
            username = Console.ReadLine();
            Console.WriteLine("Your username is: " + username);

            AccountsList.accountList.Add(username);

            
            
            Console.WriteLine("Set a password:");
            password = Console.ReadLine();
            Console.Clear();
        }
    }
}
