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
				//Код ако потребителя условието е изпълнено (въвел е цяло число)
				//Печат на резултат
				Console.WriteLine ("Резултата a ("+a.ToString("D")+") + b ("+b.ToString("D")+") е " + (a + b).ToString ("D") + "\n\n\n");
			} else {
				//Код ако потребителя условието не е изпълнено (не е въвел цяло число)
				//Печат на грешката
				Console.WriteLine ("\n\nМоля въведете цяло число!!! Вие въведохте '"+c+"'!");
			}

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";


			Console.WriteLine ("Събираме с += : "+test+"\n");

			test = test.Replace (", ", ";");

			Console.WriteLine ("Работа с  Repalce : "+test+"\n");


			Console.WriteLine ("Трети знак: "+test.Split(';')[2]+"\n");


		}
	}
}
