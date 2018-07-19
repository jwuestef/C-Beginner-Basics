using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {

            // DATETIME

            //DateTime dateTime = new DateTime(2015, 1, 1);
            //DateTime now = DateTime.Now;
            //DateTime today = DateTime.Today;

            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);

            //// DateTimes are immutable unless using built-in method

            //DateTime tmrw = now.AddDays(1);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));


            // TIMESPAN

            //TimeSpan timeSpan = new TimeSpan(1, 2, 3); // One hour, 2 minutes, 3 seconds

            //DateTime start = DateTime.Now;
            //DateTime end = DateTime.Now.AddMinutes(2);
            //TimeSpan duration = end - start;

            //Console.WriteLine(timeSpan.Minutes);  // 2
            //Console.WriteLine(timeSpan.TotalMinutes);  // 32.05

            //Console.WriteLine(timeSpan.ToString());
            //Console.WriteLine(TimeSpan.Parse("01:02:03"));


        }
    }
}
