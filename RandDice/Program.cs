using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random(int.Parse(args[1]));
            int n = 0;
            int maxValue = 0;
             while (n < int.Parse(args[0]))
            {
                maxValue += random.Next(1, 6);
                n++;
            }
            System.Console.WriteLine(maxValue);
        }
    }
}