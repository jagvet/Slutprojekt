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

            AccountsList.accountList.Add("kalle");
            AccountsList.accountList.Add("oskar");
            AccountsList.accountList.Add("Chris"); //Tre stycken användare läggs till i listan vid start.
            

            Console.WriteLine("Welcome to MySpase");
            Console.WriteLine("");
            Console.WriteLine("Do you already have an account?");

            haveAccount = Console.ReadLine(); //Låter användaren svara ifall den har ett konto eller inte
            haveAccount = haveAccount.ToLower(); //Gör svaret till små bokstäver
            Console.Clear(); //Rensar

            while (haveAccount != "yes" && haveAccount != "no") //Gör så att användaren måste svara yes/no för att fortsätta
            {
                Console.Clear();
                Console.WriteLine("Welcome to MySpase");
                Console.WriteLine("");
                Console.WriteLine("Do you already have an account?");
                Console.WriteLine("Please, enter yes or no.");
                haveAccount = Console.ReadLine();
                haveAccount.ToLower();
            }

            while(haveAccount == "no") //Om man svarar no körs en metod från en annan klass
            {
                Console.Clear();
                Console.WriteLine("Welcome to MySpase");
                Console.WriteLine("");
                CreateLogin.CreateUser(); //Metoden som skapar en användare
                haveAccount = "yes";
            }

            if (haveAccount == "yes") //Om man redan har ett konto eller precis skapat ett
            {
                Login.SignIn(); //Metod för att logga in

            }

            //AccountsList.PrintList();



            Console.ReadLine();
        }
    }
}
