// See https://aka.ms/new-console-template for more information
using System;
public class GFG
    {

        // Function to check if x is power of 2
        static bool isPowerofTwo(int n)
        {
            if (n == 0)
                return false;
            if ((n & (~(n - 1))) == n)
                return true;
            return false;
        }
        public static void Main(String[] args)
        {
            if (isPowerofTwo(30) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            if (isPowerofTwo(128) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }

// This code contributed by gauravrajput1
