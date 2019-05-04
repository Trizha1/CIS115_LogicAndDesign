using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string customerName, customerState;
            int numItems;
            double unitPrice;

            Console.Write("Enter the name of the customer: ");
            customerName = Console.ReadLine();
            Console.Write("In which state (FL / NJ / NY)?: ");
            customerState = Console.ReadLine();
            Console.Write("How many items were purchased?: ");
            numItems = Convert.ToInt32(Console.ReadLine());
            Console.Write("What was the unit price of the items?: ");
            unitPrice = Convert.ToDouble(Console.ReadLine());
            var total = ComputeTotal(numItems, unitPrice);
            Console.WriteLine("The total sales for " + customerName + " are " + total.ToString("C"));
            var tax = ComputeTax(customerState, total); 
            Console.WriteLine("The total with taxes is: " + tax.ToString("C"));

            Console.ReadLine();

        }
        public static double ComputeTotal(int numItems, double unitPrice)
        {
            return numItems * unitPrice;
        }
        public static double ComputeTax(string customerState, double total)

        {
            double totalTax;

            if (customerState == "FL")
            {
                totalTax = total * .06;
                return totalTax + total;
            }
            else if (customerState == "NJ")
            {
                totalTax = total * .07;
                return totalTax + total;

            }
            else if (customerState == "NY")
            {
                totalTax = total * .04;
                return totalTax + total;
            }

            return total;
        }






    }
}
