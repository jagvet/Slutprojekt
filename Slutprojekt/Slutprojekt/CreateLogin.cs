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
            AccountsList.accountList.Add("Kalle");
            Console.WriteLine("Set a username:");
            username = Console.ReadLine();
            Console.WriteLine("Your username is: " + username);

            AccountsList.accountList.Add(username);

            UserCheck();
            
            Console.WriteLine("Set a password:");
            password = Console.ReadLine();
            Console.Clear();
        }

        static public void UserCheck()
        {
            for (int i = 0; i < AccountsList.accountList.Count; i++)
            {
                if (username == AccountsList.accountList[i])
                {
                    Console.WriteLine("Username already taken");
                }
            }
        }
    }
}
