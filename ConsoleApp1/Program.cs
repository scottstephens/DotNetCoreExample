using System;
using System.Collections.Generic;
using System.Configuration;
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
            var num1 = Int32.Parse(ConfigurationManager.AppSettings["num1"]);
            var num2 = Int32.Parse(ConfigurationManager.AppSettings["num2"]);

            Console.WriteLine($"{num1} + {num2} = {Adder.Add(num1,num2)}");

            var now = SystemClock.Instance.GetCurrentInstant();
            var now_local = now.InZone(DateTimeZoneProviders.Tzdb.GetSystemDefault());
            Console.WriteLine($"{now_local}");

            Console.ReadLine();
        }
    }
}
