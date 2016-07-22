using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            

            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;

            switch (input)
            {
                case "BGN":
                    break;
                case "USD":
                    value *= usd;
                    break;
                case "EUR":
                    value *= eur;
                    break;
                case "GBP":
                    value *= gbp;
                    break;
                default:
                    break;
            }
            switch (output)
            {
                case "BGN":
                    break;
                case "USD":
                    value /= usd;
                    break;
                case "EUR":
                    value /= eur;
                    break;
                case "GBP":
                    value /= gbp;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(value,2) + " " + output);
        }
    }
}
