using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();
            bool displayMenu = true;
            while(displayMenu){
                displayMenu = Menu();
            }

        }

        private static bool Menu()
        {
            Console.WriteLine("Choose an option :");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Option 3");
            Console.WriteLine("4) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                Happy h = new Happy();
                h.feelHappy();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            
        private static void PrintNumbers() {

            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result) {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame() {
            Console.WriteLine("Guessing Game");
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                if (result == randomNumber.ToString()) {
                    incorrect = false;
                }
                else {
                    Console.WriteLine("Incorrect!");
                }

            }
            while (incorrect);
            Console.WriteLine("Correct!");

            Console.ReadLine();
        }
    }

    // Feeling happy class
    class Happy
    {
        public string happyMsg = "I'm on top o'the world !";

        public string feelHappy()
        {
            return happyMsg;
        }
    }
}
