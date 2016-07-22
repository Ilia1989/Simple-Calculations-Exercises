using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = usd * (decimal)1.79549;

            Console.WriteLine(Math.Round(bgn,2));
        }
    }
}