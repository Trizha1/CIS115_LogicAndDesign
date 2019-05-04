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
            const double SINGLE = .22;
            const double MARRIED = .15;
            const double DIVORCED = .23;
            const double WIDOWED = .13;
            double hourlyRate = 0; // Value is set to 0 until users inputs hourlyRate
            double netPay = 0; // 0 until value after taces and overPay & taxes are calculated
            double grossPay = 0; // Value is 0 until calculated from hoursWorked, hourlyRate
            double overPay = 0; // Value is calculated only if user inputs >40 for hoursWorked
            double hoursWorked = 0; // Set by user
            double taxAmount = 0; // Determined by grossPay * maritalStatus
            double taxRate = 0; // Based on maritalStatus
            double regPay = 0;
            string maritalStatus = "S";

            Console.Write("Enter hourly pay: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your marital status: (S)ingle, (M)arried, (D)ivored, (W)idowed? ");
            maritalStatus = Console.ReadLine();
            if (maritalStatus == "S")
            {
                taxRate = SINGLE;
            }
            else if (maritalStatus == "M")
            {
                taxRate = MARRIED;
            }
            else if (maritalStatus == "D")
            {
                taxRate = DIVORCED;
            }
            else if (maritalStatus == "W")
            {
                taxRate = WIDOWED;
            }
            if (hoursWorked > 40)
            {
                regPay = 40 * hourlyRate;
                overPay = (hoursWorked - 40) * hourlyRate * 1.5;
                grossPay = regPay + overPay;
                taxAmount = grossPay * taxRate;
                netPay = grossPay - taxAmount;
                Console.WriteLine("Regular pay is: " + regPay.ToString("C"));
                Console.WriteLine("Overtime pay is: " + overPay.ToString("C"));
                Console.WriteLine("Gross pay is: " + grossPay.ToString("C"));
                Console.WriteLine("Net pay is: " + netPay.ToString("C"));
            }
            else
            {
                grossPay = hourlyRate * hoursWorked;
                taxAmount = grossPay * taxRate;
                netPay = grossPay - taxAmount;
                Console.WriteLine("Gross pay is: " + grossPay.ToString("C"));
                Console.WriteLine("Net pay is: " + netPay.ToString("C"));
            }
            Console.ReadLine(); //keep console window open
        }
    }
}
