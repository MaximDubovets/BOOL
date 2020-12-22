using System;

namespace ConsoleApp4
{
	class Program
	{

		static void Main(string[] args)
		{
			double a, b;
			Console.WriteLine("Введите любое число a:");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите любое другое число b:");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine();
			bool x1 = (a > b) & ((a - b) > 0);
			Console.WriteLine("a > b и разность чисел положительна: " + x1);
			bool x2 = (a > 0) & (b > 0); 
            Console.WriteLine("Оба числа положительные: "+x2);
			Console.WriteLine();
			bool x3 = (a > 0) | (b > 0);
			Console.WriteLine("Одно из чисел положительно: " + x3);
			bool x4 = ((a > 0) & (a < 100)) | ((b > 0) & (b < 100));
			Console.WriteLine("Одно из чисел больше нуля и меньше 100 :" + x4);
			Console.WriteLine();
			bool x5 = a > b;
			Console.WriteLine("a > b : "+x5);
			Console.ReadLine(); 
		}
	}
}

