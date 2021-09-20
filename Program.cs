using System;


namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double amount;
            double result_usd;
            double result_uah;
            double result_lira;
            double rate_usd = 73.58;
            double rate_uah = 2.75;
            double rate_lira = 8.68;

            Console.WriteLine("Enter amount in RUB");
            str = Console.ReadLine();
            amount = Convert.ToDouble(str);
            result_usd = amount / rate_usd;
            result_uah = amount / rate_uah;
            result_lira = amount / rate_lira;
            Console.ReadLine();
            Console.WriteLine("Amount in USD:" +result_usd +" USD");
            Console.ReadLine();
            Console.WriteLine("Amount in UAH:" + result_uah +" UAH");
            Console.ReadLine();
            Console.WriteLine("Amount in TRY:" + result_lira +" TRY");
            Console.ReadLine();
        }
    }
}
