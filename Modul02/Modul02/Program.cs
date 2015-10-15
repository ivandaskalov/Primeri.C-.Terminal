using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";

			sum = a + b;

			//За програмата
			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");

			//Писане в конзола
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; //a = 10 + 5, a = a + b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на -=");
			a -= b; //a = 10 - 5, a = a - b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на *=");
			a *= b; //a = 10 * 5, a = a * b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на ++");
			a++; //a = 50 + 1, a = a + b
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно делене: " + (a / b).ToString ()); // -> a {(ab+1) / b = a + 1/b}
			Console.WriteLine ("Остатък делене: " + (a % b).ToString()); // -> 1 {(ab+1) - ab = 1}
		}
	}
}
