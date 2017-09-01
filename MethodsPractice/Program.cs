using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice using the created methods
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1, number2); 
            Console.WriteLine(total);
            Console.WriteLine(Multiply(number1, number2)); //don't have to create a variable to store the total necessarily but you don't have access to it later
            Greeting();
            string name = "Katie";
            RobotWarning(name);

        }



        //CREATING THE METHOD
        public static int Add(int firstNumber, int secondNumber) //public is an access modifier: who can access the method; Add is the name of the method (action-based); int is the data type; ( ) enclose the parameters
        //firstNumber and secondNumber are placeholders
        {
            int sum = firstNumber + secondNumber;
            return sum; //returns integer value to the user who called the method
        }

        //ANOTHER METHOD
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            return product; 
        }

        //VOID METHOD
        public static void Greeting()
        {
            Console.WriteLine("Hello world");
        }

        //ANOTHER METHOD
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name);
        }
    }
}
