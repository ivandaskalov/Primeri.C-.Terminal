using System;

namespace HelloAula
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello My Aula!");
//			Console.ReadKey ();

			string ea = "Hello";
			string eb = "World";
			object ec;
			string ed;

			ec = ea + " " + eb;
			ed = (string)ec;
			Console.WriteLine(ec);
			Console.WriteLine(ed);


			int cifra = 150;
			string slovom = "сто и петдесет";
			string result = "Цифрата '" + cifra.ToString() + "' словом е '" + slovom + "'!";
			int resultLenght = result.Length;
			Console.WriteLine(result+", "+resultLenght);
			Console.WriteLine("Цифрата '{0}' словом е '{1}'!, {2}", cifra, slovom,resultLenght);
		}
	}
}
