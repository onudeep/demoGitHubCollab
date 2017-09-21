﻿using System;
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
            Console.WriteLine("Testing...");
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString() + "date");
            Console.ReadLine();            
        }
        
    }
}
