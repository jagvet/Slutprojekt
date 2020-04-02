using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class AccountsList : CreateLogin
    {
        public static List<string> accountList = new List<string>();

        static public void PrintList()
        {
            for (int i = 0; i < accountList.Count; i++)
            {
                Console.WriteLine(accountList[i]);
            }

        }

        

    }
}
