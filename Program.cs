using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Activity_Section_B
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 == num2 ? 3 * (num1 + num2) : num1 + num2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("compute the sum of the two numerical values also If the two values are the same, return triple their sum.");
            int[] input1 = { 1, 3, 2 };
            int[] input2 = { 2, 2, 2 };

            for (int i = 0; i < input1.Length; i++)
            {
                int sum = Sum(input1[i], input2[i]);
                Console.WriteLine($"The sum of {input1[i]} , {input2[i]} = {sum}");
            }
            Console.ReadLine();
        }
    }

}
