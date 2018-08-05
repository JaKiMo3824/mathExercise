using System;

namespace mathExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number and I will multiply it by 50!");
            string firstNumber = Console.ReadLine();
            int firNum = Convert.ToInt32(firstNumber);
            int firstTotal = firNum * 50;
            Console.WriteLine("Your number multiplied by 50 = " + firstTotal);
            Console.ReadLine();

            Console.WriteLine("Please type in a number and I will add 25 to it!");
            string secondNumber = Console.ReadLine();
            int secNum = Convert.ToInt32(secondNumber);
            int secondTotal = secNum + 25;
            Console.WriteLine("Your number plus 25 = " + secondTotal);
            Console.ReadLine();

            Console.WriteLine("Please type in a number and I will divide it by 12.5!");
            string thirdNumber = Console.ReadLine();
            double thiNum = Convert.ToDouble(thirdNumber);
            double thirdTotal = thiNum / (double)12.5;
            Console.WriteLine("Your number divided by 12.5 = " + thirdTotal);
            Console.ReadLine();

            Console.WriteLine("Please type in a number and I will tell you if it is greater than 50!");
            string fourthNumber = Console.ReadLine();
            int fouNum = Convert.ToInt32(fourthNumber);
            bool result = fouNum > 50;
            Console.WriteLine("Is your number greater than 50? " + result);
            Console.ReadLine();

            Console.WriteLine("Please type in a number and I will divide it by 7 and give you the remainder!");
            string fifthNumber = Console.ReadLine();
            int fifNum = Convert.ToInt32(fifthNumber);
            int remainder = fifNum % 7;
            Console.WriteLine("The remainder of your number: " + fifNum + " divided by 7 = " + remainder);
            Console.ReadLine();







           

        }
    }
}
