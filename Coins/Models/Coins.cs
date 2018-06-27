using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Counter
{
    static class Program
    {
        static void Main()
        {

        }
    }

    public class User
    {
        
        public string UserInput(string n)
        {
            string response = Console.ReadLine();
            return response;
        }

        public int Quarters(int number)
        {
            int quarters = number / 25;
            int remainder = number % 25;
            return remainder;
        }

        public int Dimes(int QuarterRemainder)
        {
            int dimes = QuarterRemainder / 10;
            int remainder = QuarterRemainder % 10;
            return remainder;
        }

        public int Nickels(int DimesRemainder)
        {
            int nickels = DimesRemainder / 5;
            int remainder = DimesRemainder % 5;
            Console.WriteLine(remainder);
            return remainder;
        }

        public int Pennies(int NickelsRemainder)
        {
            int pennies = NickelsRemainder / 1;
            int remainder = NickelsRemainder % 1;
            Console.WriteLine(remainder);
            return remainder;
        }
    }
}