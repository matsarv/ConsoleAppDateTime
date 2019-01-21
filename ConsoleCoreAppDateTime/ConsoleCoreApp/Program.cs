using System;

namespace ConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;    // Gets current system time

            Console.WriteLine(timeNow); // Show Date and Time
            Console.WriteLine(timeNow.ToString());  // same as above
            Console.WriteLine(timeNow.ToShortDateString()); // Show short Date ÅÅÅÅ-MM-DD
            Console.WriteLine(timeNow.ToLongDateString());  // Show long Date  e.g. den 12 januari 2019
            Console.WriteLine(timeNow.ToString("yy-dd-MM")); // Show Date with 2 (yy) digits of the year

            DateTime timeMod = timeNow.AddHours(-1); // Show Date and Time minus one hour

            Console.WriteLine(timeMod); // Show Date and Time 1 hour back in time

            TimeSpan timeSpan = new TimeSpan(12, 45, 30); // Set a timespan of 12:45:30

            DateTime timeModSpan = timeNow.Add(timeSpan); // Add above timespan to the current time

            Console.WriteLine(timeModSpan); // Show the time with added timespan

            Console.ReadKey(); // Pause, wait for any key

            DoWhileWorkTime(timeModSpan); // Call Method DoWhileWorkTime with value

            DateTime myB_Day = new DateTime(1982, 08, 25); // Set a new Date on DateTime

            Console.WriteLine(myB_Day); // Display new Date, the time will be zero's

            Console.ReadKey(); // Pause, whait for any key

        }

        // Show timen every hour fron input Time from above timeModSpan until 16:30
        static void DoWhileWorkTime(DateTime time)
        {
            DateTime endOfWorkDay = time;

            do
            {
                Console.WriteLine(endOfWorkDay.ToShortTimeString()); // Show the time from above every hour
                endOfWorkDay = endOfWorkDay.AddHours(1);  
            } while
            (endOfWorkDay.Hour < 16 || (endOfWorkDay.Hour <= 16 && endOfWorkDay.Minute <= 30)); // Loop and display every hour until 16:30


        }
    }
}
