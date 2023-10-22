using System;

namespace PilotonTip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double totalbill;
            double liquorcharge;
            double tipPercentage;
            double tip;

            Console.WriteLine("Enter Totalbill: ");
            totalbill = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter liquorcharge: ");
            liquorcharge = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter tipPercentage: ");
            tipPercentage = double.Parse(Console.ReadLine());

            tip = (totalbill - liquorcharge) * tipPercentage;

            Console.WriteLine($"TIP: {tip}");
        }
    }
}