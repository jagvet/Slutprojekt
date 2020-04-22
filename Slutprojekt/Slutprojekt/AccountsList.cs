using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class AccountsList : CreateLogin
    {
        public static List<string> accountList = new List<string>(); //Skapar min lista som jag lagrar användarnamn i
        
        
        static public void PrintList() //Metoden som skriver ut listan, används mest bara för att se om saker fungerat
        {
            for (int i = 0; i < accountList.Count; i++)
            {
                Console.WriteLine(accountList[i]);
            }

        }

        

    }
}
