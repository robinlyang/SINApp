using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sinNumberStr = "";
            Console.WriteLine("Please enter your SIN:");
            sinNumberStr = Console.ReadLine();
            char[] sinNumberChar = sinNumberStr.ToCharArray();
            int[] sinNumberInt = new int[sinNumberChar.Length];
            for (int x = 0; x < sinNumberChar.Length; x++)
            {
                sinNumberInt[x] = Convert.ToInt32(sinNumberChar[x].ToString());
            }
            int total = 0;

            for (int x = 0; x < sinNumberInt.Length; x++)
            {
                int num1 = 0;
                int num2 = 0;
                if(x % 2==0)
                {
                    num1 = sinNumberInt[x] * 1;
                    if (num1 > 9)
                    {
                        num2 = (num1 / 10) + (num1 % 10);
                        total = total + num2;
                    }
                    else
                        total = total + num1;
                }
                else
                {
                    num1 = sinNumberInt[x] * 2;
                    if (num1 > 9)
                    {
                        num2 = (num1 / 10) + (num1 % 10);
                        total = total + num2;
                    }
                    else
                        total = total + num1;
                }
            }

            Console.WriteLine("Total: " + total);
            
            Console.ReadLine();
        }
    }
}
