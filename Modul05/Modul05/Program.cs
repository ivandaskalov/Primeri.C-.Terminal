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
					else
					{
						Console.WriteLine("Командата не е въведена коректно!");
					}
				}
				if(usercommand.Contains ("cmd04"))
				{
					double _t = 5, _c = -2;
					if(cmd04(ref _t))
					{
						Console.WriteLine(_t);
					}
					if(cmd04(ref _c))
					{
						Console.WriteLine(_c);
					}
				}
				if(usercommand.Contains("cmd05"))
				{
					Console.WriteLine("Брой четни числа: {0}",cmd05(usercommand).Length);
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
				//__p = Convert.ToDouble(_p);
			}catch{
				//Console.WriteLine ("Грешка в catch");
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

		public static string [] cmd05(string _input)
		{
			string _temp = "";
			int _border = 0;
			if (int.TryParse (_input.Split(' ')[1], out _border)) 
			{
				if (_border % 2 == 0) {
					_border--;
				} 
				for (int i = 0; i <= _border; i++) {
					if (i % 2 == 0) {
						_temp += i;
						if (i < _border - 1 ) {
							_temp += ",";
						}
					}
				}
			}
			Console.WriteLine (_temp);
			return _temp.Split (',');
		}
	}
}