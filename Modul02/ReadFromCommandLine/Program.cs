using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметCoри
			Console.Write ("Моля въведете b: ");
//			b = Convert.ToInt32(Console.ReadLine ());
			string c = Console.ReadLine ();
			if (int.TryParse (c, out b)) {
				//Код ако потребителя е въвел коректно число
				//Печат на резултат
				Console.WriteLine ("Резултата a + b е " + (a + b).ToString () + "\n\n\n");
			} else 
			{
				Console.WriteLine ("\n\nМоля въведете цяло число!!! Вие въведохте '"+c+"'!");
			}
		}
	}
}
