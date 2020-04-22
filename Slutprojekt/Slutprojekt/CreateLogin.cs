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
        static public bool check; //Skapar variablerna jag behöver

        static public void CreateUser() //Metoden för att skapa en användare
        {
            
            Console.WriteLine("Set a username:");
            username = Console.ReadLine();
            username = username.ToLower(); //Först skapar man ett användarnamn

            check = AccountsList.accountList.Contains(username); //Kollar om användarnamnet redan finns. check blir true eller false

            while (check == true) //Om det finns måste man ta ett annat
            {
                Console.WriteLine("Username already taken");
                username = Console.ReadLine();
                username.ToLower();

                check = AccountsList.accountList.Contains(username); //Kollar igen
            }

            Console.WriteLine("Your username is: " + username); //Skriver ut ens användarnamn

            AccountsList.accountList.Add(username); //Om man har ett unikt användarnamn läggs det till i listan

            
            Console.WriteLine("Set a password:"); //Här ska jag göra så man skapar ett lösenord också
            password = Console.ReadLine();
            Console.Clear();
        }
        
    }
}
