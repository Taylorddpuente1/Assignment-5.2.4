// check whether given string is Palindrome or not using recursion

using System;
using System.Globalization;
class Program
{
    static bool Recursive_Palindrome(string s, int left, int right)
    {
        if (left >= right)
            return true;

        if (s[left] != s[right])
            return false;


        return Recursive_Palindrome(s, left + 1, right - 1);
    }
        static void Main()
        {

            Console.WriteLine("Please input string : ");
            string input = Console.ReadLine();

           

            if(Recursive_Palindrome(input.ToUpper(),0, input.Length-1))
            Console.WriteLine("The string is Palindrome.");
            else
                Console.WriteLine("The string is not Palindrome.");
        }
    }

