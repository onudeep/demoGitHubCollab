using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses
{
    class Program
    {
        static void Main(string[] args) {
            Car car1 = new Car();
            car1.Make = "Mercedes";
            car1.Model = "Kicherer";
            car1.Year = 2008;
            car1.Color = "SandGray";

            Console.WriteLine("car1 :: {0} {1} {2} {3}",
                car1.Make,
                car1.Model,
                car1.Year,
                car1.Color);
            
            //decimal value = DetermineMarketValue(car1);
            //Console.WriteLine("{0:C}",value);

            //Console.WriteLine("{0:C}",car1.DetermineMarketValue());
            Car car2 = new Car();
            car2 = car1;

            Console.WriteLine("car2 :: {0} {1} {2} {3}",
                 car2.Make,
                 car2.Model,
                 car2.Year,
                 car2.Color);

            Console.WriteLine("car2.Model=\"Benz\"; ", car2.Model ="Benz");

            Console.WriteLine("car2 :: {0} {1} {2} {3}",
                 car2.Make,
                 car2.Model,
                 car2.Year,
                 car2.Color);
            //car2 = null; //car2(reference to the object of car1) is removed
            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car) {
            decimal carValue = 100.0M;
            return carValue;
        }
    }
    class Car {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue() {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 10000;
            } else {
                carValue = 2000;
            }

            return carValue;
        }
    }
}
