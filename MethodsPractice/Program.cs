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
            string faveFoodType = "fruit";
            string faveFoodName = "banana";
            FavoriteFood(faveFoodType, faveFoodName);
            FavoriteFood("Fruit", "Apples");
            int myAge = 26;
            RetirementCalculator(myAge);
            Console.WriteLine(DaysLived(2));
            NameStartsWith("Panda");
            Console.WriteLine("How many hours do you work in a month?");
            double monthlyHours = double.Parse(Console.ReadLine());
            Console.WriteLine("How much do you make per hour?");
            double hourlyWage = double.Parse(Console.ReadLine());
            Console.WriteLine("You make $" + WageCalculator(monthlyHours, hourlyWage) + " per month.");
                        
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

        //Create a method called FavoriteFood. It should take two string parameters: type of the food and name of the food
        //Use void return type and the method should concatenate the two values

        public static void FavoriteFood(string foodType, string foodName)
        {
            Console.WriteLine(foodType + " " + foodName);
        }

        //Create a method called RetirementCalculator
        //It should take int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires (using 65 as the age of retirement)
        //The return type should be void
        //Once it calculates the user's retirement age it should print:
        //The user will retire in X years, where X represents the value that was calculated.

        public static void RetirementCalculator(int userAge)
        {
            int ageToRetire = 65 - userAge;
            Console.WriteLine("The user will retire in " + ageToRetire + " years.");
        }

        //Create a method called WageCalculator.
        //It should take two double parameters.One should represent the hours worked and the other represent the hourly wage. 
        //The return type should be of type of double.
        //The method should calculate the monthly wage.
        //Once it calculates the monthly wage it should return that value

        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hoursWorked * hourlyWage;
            return (monthlyWage);
        }


// Create two methods of your choosing.At least one of the methods should have a non-void return type.
// Both of the methods should take at least one parameter
// Remember when naming your method that it should represent what your method should do.
// Your method should only aim to accomplish one thing.
// Be creative.

            //Method One:
        public static float DaysLived(int ageInput)
        {
            float numberOfDays = ageInput * 365;
            return (numberOfDays);
        }

        //Method Two:
        public static void NameStartsWith(string name)
        {
            if (name.StartsWith("a", StringComparison.CurrentCultureIgnoreCase) || name.StartsWith("e", StringComparison.CurrentCultureIgnoreCase)  || name.StartsWith ("i", StringComparison.CurrentCultureIgnoreCase) || name.StartsWith("o", StringComparison.CurrentCultureIgnoreCase) || name.StartsWith("u", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Your name starts with a vowel!");
            }
            else
            {
                Console.WriteLine("Your name does not start with a vowel!");
            }

        }

    }

}
