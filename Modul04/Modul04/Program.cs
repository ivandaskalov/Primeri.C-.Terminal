using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{ "Иван",		"Георгиев",		"19" },
				{ "Васил",		"Иванов",		"23" },
				{ "Милен",		"Георгиев",		"58" },
				{ "Цветан",		"Бориславов",	"14" },
				{ "Гергана",	"Василева",		"25" },
				{ "Ивана",		"Христова",		"21" },
			};

			//Антетка за таблицата
			Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight(12) + "Възраст".PadRight(12));
			Console.WriteLine ("".PadRight(36,'='));

			//Тяло на таблицата
			for (int i = 0; i < _table.GetLength(0); i++) {
				//Код на цикъла
				for (int j = 0 ; j < _table.GetLength(1); j++)
					Console.Write (_table[i,j].PadRight(12));
				Console.WriteLine ();
			}
		}
	}
}
