using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Counter
{
    public class Program
    {
        public static void Main()
        {
        Console.WriteLine("Enter a number between 0 and 100 to receive the lowest combination of change.");
        int response = int.Parse(Console.ReadLine());
        User newUser = new User();
        newUser.Quarters(response);
        }
    }

    public class User
    {
        public int Quarters(int number)
        {
            int quarters = number / 25;
            int remainder = number % 25;
            Console.WriteLine("You will receive " + quarters + " quarters.");
            Dimes(remainder);
            return remainder;
        }

        public int Dimes(int QuarterRemainder)
        {
            int dimes = QuarterRemainder / 10;
            int remainder = QuarterRemainder % 10;
            Console.WriteLine("You will receive " + dimes + " dimes.");
            Nickels(remainder);
            return remainder;
        }

        public int Nickels(int DimesRemainder)
        {
            int nickels = DimesRemainder / 5;
            int remainder = DimesRemainder % 5;
            Console.WriteLine("You will receive " + nickels + " nickels.");
            Pennies(remainder);
            return remainder;
        }

        public int Pennies(int NickelsRemainder)
        {
            int pennies = NickelsRemainder / 1;
            int remainder = NickelsRemainder % 1;
            Console.WriteLine("You will receive " + pennies + " pennies.");
            return remainder;
        }
    }
}