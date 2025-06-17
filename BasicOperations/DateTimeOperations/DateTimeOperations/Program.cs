using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime f = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = f.ToLongDateString();
            string s2 = f.ToLongTimeString();
            string s3 = f.ToShortDateString();
            string s4 = f.ToShortTimeString();
            string s5 = f.ToString();
            string s6 = f.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = f.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime y1 = x.AddDays(3);
            DateTime y2 = x.AddHours(3);
            DateTime y3 = x.AddMilliseconds(3);
            DateTime y4 = x.AddMinutes(3);
            DateTime y5 = x.AddMonths(3);
            DateTime y6 = x.AddSeconds(3);
            DateTime y7 = x.AddTicks(3);
            DateTime y8 = x.AddYears(3);

            DateTime y9 = x.Add(TimeSpan.FromDays(3));
            DateTime y10 = x.Subtract(TimeSpan.FromDays(3));
            TimeSpan t = x.Subtract(new DateTime(2001, 8, 12, 13, 45, 58));

            Console.WriteLine("Original: " + x);
            Console.WriteLine("AddDays(3): " + y1);
            Console.WriteLine("Subtract 3 days: " + y10);
            Console.WriteLine("Difference (TimeSpan): " + t);
        }
    }
}