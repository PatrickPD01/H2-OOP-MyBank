using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Press enter to generate a new card in the console

            BankAccount account = new MyBankerAccount("yeet");
            Card card1 = new Debit("Debit", account);
            Card card2 = new Visa("Visa", account);
            Card card3 = new Maestro("Maestro", account);
            Card card4 = new Electron("Electron", account);
            Card card5 = new Mastercard("Mastercard", account); 

            Console.WriteLine(card1.ToString());
            Console.ReadLine();
            Console.WriteLine(card2.ToString());
            Console.ReadLine();
            Console.WriteLine(card3.ToString());
            Console.ReadLine();
            Console.WriteLine(card4.ToString());
            Console.ReadLine();
            Console.WriteLine(card5.ToString());
            Console.ReadLine();
        }
    }
}
