using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string haveAccount = "";

            Console.WriteLine("Welcome to MySpase");
            Console.WriteLine("");
            Console.WriteLine("Do you already have an account?");

            haveAccount = Console.ReadLine();
            Console.Clear();
            haveAccount.ToLower();

            while (haveAccount != "yes" && haveAccount != "no")
            {
                Console.Clear();
                Console.WriteLine("Welcome to MySpase");
                Console.WriteLine("");
                Console.WriteLine("Please, enter yes or no.");
                haveAccount = Console.ReadLine();
                haveAccount.ToLower();
            }

            while(haveAccount != "yes")
            {
                Console.Clear();
                Console.WriteLine("Welcome to MySpase");
                Console.WriteLine("");
                CreateLogin.CreateUser();
                haveAccount = "yes";
            }

            //AccountsList.PrintList();

            Login.SignIn();


            Console.ReadLine();
        }
    }
}
