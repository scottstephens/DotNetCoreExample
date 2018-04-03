using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib1;
using NodaTime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 + 2 = {Adder.Add(1,2)}");

            var now = SystemClock.Instance.GetCurrentInstant();
            var now_local = now.InZone(DateTimeZoneProviders.Tzdb.GetSystemDefault());
            Console.WriteLine($"{now_local}");

            Console.ReadLine();
        }
    }
}
