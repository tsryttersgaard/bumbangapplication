using System;
using System.Linq;

namespace TimeInBeijing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date/time GMT: {0}", DateTime.UtcNow);
            Console.WriteLine("Date/time Copenhagen: {0}", GetTimeZoneTimestamp("København"));
            Console.WriteLine("Date/time Beijing: {0}", GetTimeZoneTimestamp("Beijing"));
            Console.ReadLine();
        }

        static string GetTimeZoneTimestamp(string cityName)
        {
            var zone = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(x => x.DisplayName.Contains(cityName));
            return zone != null ? TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, zone).ToString() : "(not found)";
        }
    }
}
