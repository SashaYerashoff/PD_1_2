using System;

namespace PD_1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string yesno = "yes";
			while (yesno == "yes")
			{
				Console.WriteLine("uzdevums 7: ");
				Uzdevums7();
				Console.WriteLine();

				Console.WriteLine("uzdevums 8: ");
				Uzdevums8();
				Console.WriteLine();

				Console.WriteLine("uzdevums 9: ");
				Uzdevums9();
				Console.WriteLine();

				Console.WriteLine("uzdevums 10: ");
				Console.WriteLine(Uzdevums10());
				Console.WriteLine();

				Console.WriteLine("uzdevums 11: ");
				Uzdevums11();
				Console.WriteLine();

				Console.WriteLine("uzdevums 12: ");
				Uzdevums12();
				Console.WriteLine();

				Console.WriteLine("Vēlies atkartot? (Ja ja, tad raksti - yes)");
				yesno = Console.ReadLine();
			}

			//Console.ReadLine();

		}
		//uzdevums 7
		static void Uzdevums7()
		{
			Console.WriteLine("Ievadi kaut-ko, ko vēlies: ");
			string texts1 = Console.ReadLine();
			Console.WriteLine("Ievadi vēl kaut-ko, ko vēlies: ");
			string texts2 = Console.ReadLine();
			Console.WriteLine("Tu ievadīji: " + texts1 + " " + texts2);

		}
		//uzdevums 8
		static void Uzdevums8()
		{
			double a, b, c;
			Console.WriteLine("Ievadi kādu skaitli: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ievadi kādu skaitli: ");
			b = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("tagad izvēlies ko ar tiem cipariem darīt (+, -, *, vai /):");
			char darbibaCh = (char)Console.Read();
			string darbibaStr = Convert.ToString(darbibaCh);

			switch (darbibaStr)
			{
				case "+":
					c = a + b;
					Console.WriteLine("{0} + {1} = {2}", a, b, c);
					break;
				case "-":
					c = a - b;
					Console.WriteLine("{0} - {1} = {2}", a, b, c);
					break;
				case "*":
					c = a * b;
					Console.WriteLine("{0} * {1} = {2}", a, b, c);
					break;
				case "/":
					c = a / b;
					Console.WriteLine("{0} / {1} = {2}", a, b, c);
					break;
				default:
					Console.WriteLine("Visticamāk tu ievadīji kaut-ko ne to :(");
					break;
			}
			string gluk = Console.ReadLine();
			Console.WriteLine(gluk);
		}
		//uzdevums 9
		static void Uzdevums9()
		{
			Console.WriteLine("ievadi GPA atzīmi (no 1 līdz 4.5 ar soli 0.5)");
			string gpatzime = Console.ReadLine();

			switch (gpatzime)
			{
				case "4.5":
					Console.WriteLine("Exceptional, A+");
					break;
				case "4":
					Console.WriteLine("Excellent, A");
					break;
				case "3.5":
					Console.WriteLine("Very Good, B+");
					break;
				case "3":
					Console.WriteLine("Good, B");
					break;
				case "2.5":
					Console.WriteLine("Satisfactory, C+");
					break;
				case "2":
					Console.WriteLine("Adequate, C");
					break;
				case "1":
					Console.WriteLine("Marginal, D");
					break;
				case "0":
					Console.WriteLine("Failure, F");
					break;
				default:
					Console.WriteLine("Kaut-kur mēs sačakarējamies meistarībā, F!");
					break;
			}
			//Console.WriteLine("Te beidzas uzdevums9");
		}
		//Uzdevums 10
		static int Uzdevums10()
		{
		int a, b;
			Console.WriteLine("Ievadi kādu integer ko kāpināt:");
			a = Convert.ToInt32(Console.ReadLine());
			b = a * a;
			return b;
	    }
        //uzdevums 11
		static void Uzdevums11()
		{
			Console.WriteLine("Ievadi kādu skaitli");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ievadi kādu  citu skaitli");
            double b = Convert.ToDouble(Console.ReadLine());

            if(a<b)
			{
				Console.WriteLine("{0} ir mazāks par {1}", a, b);
			}
			else
			{
				if(a>b)
				{
					Console.WriteLine("{0} ir lielāks par {1}", a, b);
				}
				else
				{
					Console.WriteLine("Kāds no mums ir sapisies meistarībā!");
				}
			}
		}
		//Uzdevums 12
		static void Uzdevums12()
		{
			double paterins = 13.9, cena = 1.25, garums = 150, summa;
			summa = paterins / 100 * garums * cena;
			Console.WriteLine("Tavs ceļš izmaksās: {0}", summa);
		}

    }
}
