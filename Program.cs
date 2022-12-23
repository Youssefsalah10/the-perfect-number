using System;
using System.Linq;

namespace Lab
{
	public static class Program
	{
		public static void Main()
		{
            Console.WriteLine("please enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect numbers between num1 and num2 is");
            for (int i = num1 ; i <= num2 ; i++)
            {
            	if (Isperfect(i)) Console.WriteLine("{0}" , i);
            }
		}
	

               public static bool Isperfect(int number)
                {
                	int sum = 0;
                	for(int i = 1; i < number; i++)
                	{
                		if (number % i == 0) sum = sum + i;
                	}
                	if (sum == number) return true;
                	return false;
                }
	}
}