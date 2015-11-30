using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string usercommand = "";

			//Потребителски команди
			do {
				Console.Write ("$ ");
				usercommand = Console.ReadLine ();
				if(usercommand.Contains("cmd01"))					cmd01(usercommand);
				if(usercommand.Contains("cmd02"))					Console.WriteLine( cmd02(usercommand));
				if(usercommand.Contains("cmd03"))					
				{
					double _a = 0;
					if(cmd03(usercommand, out _a))
					{
						Console.WriteLine("a * a = " +_a.ToString());
					}
				}

				double _t = 5, _c = -2;
				if(cmd04(ref _t))
				{
					Console.WriteLine(_t);
				}
				if(cmd04(ref _c))
				{
					Console.WriteLine(_c);
				}

			} while (!usercommand.ToLower ().Contains ("exit"));
		}

		//Методи - код с опции:
		//Само да се изпълни
		public static void cmd01( string _input)   //cmd01 5 --> 5^2
		{
			try
			{
				double _temp = 0;
				if(double.TryParse(_input.Split(' ')[1], out _temp))
				{
					Console.WriteLine("\nРезулат от "+_temp.ToString()+"^2: "+(_temp*_temp).ToString());
				}
			}catch{
			}
		}

		//Да върне параметри
		public static int cmd02(string _input)  // cmd02 5    --> 5*5*5
		{
			try {
				int _temp = 0;
				if (int.TryParse (_input.Split (' ') [1], out _temp)) {
					_temp = _temp * _temp * _temp;
				}
				return _temp;
			} catch {return 10;
			}
		}

		//Референция
		public static bool cmd03(string _input, out double _i)
		{
			try{
				string _p = _input.Split(' ')[1];
				double __p = 0;
				if(double.TryParse(_p, out __p))
				{
					_i = __p * __p;
					return true;
				}
				else
				{
					Console.WriteLine("Командата не е въведена коректно!");
				}
			}catch{
			}

			_i = 0;
			return false;					
		}

		public static bool cmd04(ref double _i)
		{
			double _temp = _i;
			_i = _i * _i;

			return(_temp > 0);
		}
	}
}
