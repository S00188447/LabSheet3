using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("12346343", "Tom Smith", 1000);
            BankAccount acc2 = new BankAccount("34656534", "Mary Willis", 2000);

            Console.WriteLine(acc1.GetYourAccountDetails());
            Console.WriteLine(acc2.GetYourAccountDetails());

            Console.WriteLine("Adding €1000 to account 1");
            acc1.Desposit(1000);
            Console.WriteLine(acc1.GetYourAccountDetails());

            Console.WriteLine("Withdrawing €500 from account 2");
            acc2.WithDraw(500);
            Console.WriteLine(acc2.GetYourAccountDetails());



        }
    }
}
