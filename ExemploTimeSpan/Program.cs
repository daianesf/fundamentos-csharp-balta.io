using System;

namespace ExemploTimeSpan
{
    class Program
    {
        static void Main(string[] args){

            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundo = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundo);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5 , 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanNanosegundoMilissegundo = new TimeSpan();
            Console.WriteLine(timeSpanNanosegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }
    }
}