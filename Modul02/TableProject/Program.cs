using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			int n = 2;
			int m = 3;
			string[,] table = new string[n, m];

			//Въвеждане на първи ред
			table [0,0] = "Иван"; table [0,1] = "Георгиев"; table [0,2] = "41";

			//Въвеждане на втори ред
			table [1,0] = "Георги"; table [1,1] = "Иванов"; table [1,2] = "74";

			//Отпечатване в конзолата
			Console.Write("Кой ред искате да видите?");
			int _index = Convert.ToInt32(Console.ReadLine ()) - 1;
			Console.WriteLine (table[_index,0][0]+". "+table[_index,1]+", "+table[_index,2]+" г.");
			Console.WriteLine ();

		}
	}
}

//			string[] row = new string[3];
//
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//
//			Console.WriteLine ("Масив row: "+row[0]+", "+row[1]+", "+row[2]+"\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
//			Console.WriteLine ("Брой на масива:\n"+"1,2,3,4,5,6,7,8,9\n\nе: "+parse.Length);
//
//			string list1 = string.Join(";",parse);
//			Console.WriteLine ("Новият стринг е:\n"+list1+"\n\n");
//
//			//задача 1
//			int[] integers = new int[20];
//			for (int i = 0; i < integers.Length; i++) {
//				integers [i] = i * 5;
//				Console.WriteLine ("Елемент {0} = {1}",i+1,integers[i]);
//			}
//
//			//задача 2
//			Console.WriteLine("Въведе първия масив като разделяте елементите в него със символа ;!");
//			string row1 = Console.ReadLine ();
//			string[] array1 = row1.Split (';');
//
//			Console.WriteLine("Въведе втория масив като разделяте елементите в него със символа ;!");
//			string row2 = Console.ReadLine ();
//			string[] masiv2 = row2.Split (';');
//
//			bool result = true;
//			string printResult;
//			if (array1.Length != masiv2.Length)
//				result = false;
//			else
//				for (int i = 0; i < array1.Length; i++) {
//					if (array1 [i] != masiv2 [i])
//						result = false;
//				}
//			if (result == true)
//				printResult = "Двата масива са еднакви!";
//			else 
//				printResult = "Двата масива НЕ са еднакви!";
//					
//			Console.WriteLine (printResult);
//
//			//задача 3
//			Console.WriteLine("Въведете цяло число, по-голямо от нула, за дължина на желания масив!");
//			int n = int.Parse (Console.ReadLine());
//			int [] arrayDataNew = new int[n];
//			for (int i = 0; i < n; i++)
//			{
//				Console.WriteLine("Въведе елемент {0} от масива!", i+1);
//				arrayDataNew [i] = int.Parse(Console.ReadLine ());
//			}
//			Console.WriteLine("\nВИЕ ВЪВЕДОХТЕ СЛЕДНИЯ МАСИВ:");
//			for (int j = 0; j < n; j++) {
//				Console.Write (arrayDataNew[j]);
//				if (j < n - 1)
//					Console.Write("; ");
//			}
//			string element = "елемент";
//			if (n > 1) {
//				element += "а";
//			}
//			string isSymmetric = "СИМЕТРИЧЕН";
//			int averageElementNumber = n / 2;
//			for (int k = 0; k < averageElementNumber; k++)
//			{if (arrayDataNew [k] != arrayDataNew [n - 1 - k]) 
//					isSymmetric = "НЕСИМЕТРИЧЕН";
//			}
//			Console.WriteLine("\nТой се състои от {0} {1} и е {2}!\n\n",n, element,isSymmetric);
//
//
//			//задача 4
//			string [] arrayData = new string [7];
//			string [] arrayDataReverse = new string [arrayData.Length];
//			for (int i = 0; i < arrayData.Length; i++)
//			{
//				Console.WriteLine("Въведе елемент {0} от масива!", i+1);
//				arrayData [i] = Console.ReadLine ();
//				arrayDataReverse[arrayData.Length-1-i] = arrayData [i];
//			}
//			Console.WriteLine("Стойностите на масива в обратен ред са:\n");
//			for (int j = 0; j < arrayDataReverse.Length; j++) {
//				Console.Write (arrayDataReverse[j]);
//				if (j < arrayDataReverse.Length - 1)
//					Console.Write("; ");
//			}
//			Console.WriteLine("\n\n");