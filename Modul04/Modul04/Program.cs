using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] _table = {"Иван", "Гошо", "Гергана"};

			//Антетка за таблицата
			Console.WriteLine ("Име");
			Console.WriteLine ("=============");
			for (int i = 0; i < _table.Length; i++) {
				Console.WriteLine (_table[i]);
			}
		}
	}
}
