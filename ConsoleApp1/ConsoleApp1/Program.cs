using System;
using System.Windows.Markup;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] number = new int[30];
            Console.WriteLine("enter the value of number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int i = int.Parse(Console.ReadLine());
;            for (i = 0; i < n; i++) ;
            {
                int j;
                for (j = i + 1; j < n; j++) ;
                {
                    if (number[i] > number[j]) ;
                }
                int a = number[i];
                number[i] = number[j];
                number[j] = a;
            }
            for (i=0;i<n;i++)
            {
                Console.WriteLine("the number arranged in ascending order are given below");
            }
        }
    }
}
