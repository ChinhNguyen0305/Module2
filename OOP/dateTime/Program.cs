using System;

namespace dateTime
{

    public class Example
    {
        public static void Main()
        {
            DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            Console.WriteLine(date1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = date1.Date;
            // Display date using short date string.
            Console.WriteLine(dateOnly.ToString("d"));
            // Display date using 24-hour clock.
            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));

            DateTime date2 = DateTime.Now;
            System.Console.WriteLine($"date2 {date2}");

            DateTime date3 = new DateTime(2028, 8, 1, 9, 9, 20);
            DateTime date3dateOnly = date3.Date;
            System.Console.WriteLine($"Date3 date only {date3dateOnly}");
            System.Console.WriteLine($"use string ne` hihi {date3dateOnly.ToShortTimeString()}");
            // double elapseTime = date3 - date2;
            // System.Console.WriteLine(elapseTime);
            TimeSpan interval = date3-date2;
            System.Console.WriteLine($"Time interval: {interval.ToString()}");
        }
    }
    // The example displays output like the following output:
    //       6/1/2008 7:47:00 AM
    //       6/1/2008
    //       6/1/2008 12:00 AM
    //       06/01/2008 00:00

}

