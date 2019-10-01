using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class CashReg
    {
        public static double totalMoneyALLCRs { get; set }

        public static int totalItemsALLCRs { get; set; }

        public int NumberOfItems { get; private set; }

        public double Total { get; private set; }

        public void AddItem(double itemPrice)
        {
            Total = itemPrice;
            NumberOfItems++;

            totalItemsALLCRs++;
            totalMoneyALLCRs += itemPrice;

        }
    }
}
