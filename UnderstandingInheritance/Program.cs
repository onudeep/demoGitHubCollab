using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "i8";
            car.Year = 2010;
            car.Color = "Cobalt";
            printCarDetails(car);

            Truck truck = new Truck();
            truck.Make = "Tata";
            truck.Model = "H2";
            truck.Year = 1990;
            truck.Color = "Blue";
            truck.TowingCapacity = 1200;
            printCarDetails(truck);     //truck inherits properties of car

        }

        private static void printCarDetails(Car car) {
            Console.WriteLine("Car's details :: {0}",car.FormatMe());
            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public virtual string FormatMe() { //Virtual function may or maynot be overridden
                                           //Abstract function hsa to be overriddem
            return String.Format("{0}-{1}-{2}-{3}", 
                this.Make, 
                this.Model, 
                this.Year, 
                this.Color);
        }
    }

    class Truck : Car
    {
        public int TowingCapacity { get; set; }
        
        public override string FormatMe()
        {
            return String.Format("{0}-{1}-{2}",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }

    }

    class Semi : Truck
    {

    }
}
