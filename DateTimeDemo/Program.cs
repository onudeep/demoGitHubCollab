using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            DateTime date1 = new DateTime();
            DateTime date2 = DateTime.Parse("nov-02-1993");
            Console.WriteLine("ToString() " + date2.ToLongDateString()); 
            Console.WriteLine("ToShortDateString() " + dateTime.ToShortDateString());
            DateTime date =DateTime.Parse("16\\03\\1995");
            TimeSpan timeSpan=DateTime.Now.Subtract(date);
            Console.WriteLine(timeSpan.TotalDays+"chnaged by rahul");
            Console.ReadLine();            
        }
        
    }
}
