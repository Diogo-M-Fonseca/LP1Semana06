using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);

            crono1.Stop();
            crono2.Stop();

            TimeSpan cr1 = crono1.Elapsed;
            TimeSpan cr2 = crono2.Elapsed;

            Console.WriteLine($"{cr1}");
            Console.WriteLine($"{cr2}");

            string elpasedTimeCrono1 = String.Format("{0:0}.{1:00}{2:00}", 
            cr1.Seconds, cr1.Milliseconds / 10, cr1.Microseconds / 100);
            string elpasedTimeCrono2 = String.Format("{0:0}.{1:00}{2:00}", 
            cr2.Seconds, cr2.Milliseconds / 10, cr2.Microseconds / 100);

            System.Console.WriteLine($"{elpasedTimeCrono1}, {elpasedTimeCrono2}");
        }
    }
}
