using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int num,rev,sum = 0,temp;
            Console.Write("131");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum*10)+rev;
                num = num/10;
            }
            if (temp == sum)
            Console.Write("Yay! the given number is Palindrome.");
            else
            Console.Write("Oops!the given number is not Palindrome.");


        }
    }
}
