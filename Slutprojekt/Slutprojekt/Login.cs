using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Login : AccountsList
    {
        public static string username;
        public static string password;

        static public void SignIn()
        {
            Console.WriteLine("Please enter your username");

            username = Console.ReadLine();



            AccountsList.PrintList();


        }
        




    }
}
