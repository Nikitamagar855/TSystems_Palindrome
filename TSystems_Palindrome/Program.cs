using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("ENTER ANY NUMBER");
            int NUM = Convert.ToInt32(Console.ReadLine());
            int temp, r, sum = 0;
            temp = NUM;
            while (NUM > 0)
            {
                r = NUM % 10;
                sum = (sum * 10) + r;
                NUM = NUM / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("NUMBER IS PALINDROME");
            }
            else
            {
                Console.WriteLine("NOT PALINDROME");
            }
            Console.ReadLine();
            goto start;

        }
    }
}
