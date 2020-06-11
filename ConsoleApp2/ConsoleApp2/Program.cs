using System;
using System.Windows.Markup;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("how many number?");
            int n = int.Parse(Console.ReadLine())
            int[] number = new int[10];
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("enter number {0}", i);
                int value = int.Parse(Console.ReadLine());
                number[i]=value;
            }
            int max = number[0];
            int min = number[0];
            for (int i = 1; i < n; i++) 
            {
                if (number[i] > max) 
                {
                    max = number[i];
                }
                if (number[i]<min)
                {
                    min = number[i];
                }
            }
            Console.WriteLine("the highest number in the array is {0}", max);
            Console.WriteLine("the lowest numbe in the array is {0}", min);
            Console.WriteLine("good bye and see you again");

        }
    }
}

