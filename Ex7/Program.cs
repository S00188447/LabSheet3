using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] schoolname = new string[] { "", "", "", "", "" };
            int[] schoolenroll = new int[] { 1, 1, 1, 1, 1 };
            for (int i = 1; i < schoolenroll.Length; i++)
            {

                Console.WriteLine($"Enter name for school {i}");
                schoolname[i] = Console.ReadLine();

                Console.WriteLine($"Enter school enrollment {i}");
                schoolenroll[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("Sorted Schools");

            for (int i = 1; i < schoolenroll.Length; i++)
            {

           
                Console.WriteLine($"{schoolname[i]} School has {schoolenroll[i]} students ");

       


            }


        

        }
    }
}
