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
            string LoginOrCreate = "";

            Console.WriteLine("Welcome to MySpase");
            Console.WriteLine("");
            Console.WriteLine("Do you want to LOGIN or CREATE ACCOUNT ?");

            LoginOrCreate = Console.ReadLine();

            CreateLogin.CreateUser();

            Console.ReadLine();
        }
    }
}
