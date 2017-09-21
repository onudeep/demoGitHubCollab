using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HandlingEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(500);
            timer.Elapsed += Timer_Elapsed;
            timer.Elapsed += Timer_Elapsed1;
            timer.Start();
            Console.WriteLine("Press enter to detach red event handler");
            Console.ReadLine();

            timer.Elapsed -= Timer_Elapsed1;
            Console.ReadLine();
        }

        private static void Timer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ELapsed : {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Press enter to detach red event handler");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ELapsed : {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
