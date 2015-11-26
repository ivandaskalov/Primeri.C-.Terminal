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

//			//Пример с for
//			for (int i = 0; i < _table.GetLength(0); i++) {
//				//Код на цикъла
//				for (int j = 0 ; j < _table.GetLength(1); j++)
//					Console.Write (_table[i,j].PadRight(12));
//				Console.WriteLine ();
//			}

			//Пример с while
			int i=0;
			while(i < _table.GetLength(0))
			{
				Console.WriteLine (_table[i,0].PadRight(12) + _table[i,1].PadRight(12) + _table[i,2].PadRight(12));
				i++;
			}

		}
	}
}
