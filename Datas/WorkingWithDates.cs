using System;

namespace Datas
{
    class WorkingWithDates
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);


            Console.WriteLine(utcDate.ToLocalTime());
        }
    }
}