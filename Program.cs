using System;

namespace nizovi
{
    class Program
    {
        static void Main(string[] args)
        {

			int a = 5;
			int b = a;
			a++;

			Console.WriteLine($"a je {a} a b je {b}");

			int[] nizA = { 1, 2, 3 };
			int[] nizB = nizA; //nizb je 1,2,3

			nizA[0] = 1001; //menjam samo niz A

			Console.WriteLine($"Niz A prvi element {nizA[0]}");
			Console.WriteLine($"Niz B prvi element {nizB[0]}");

			nizB[0] = 500;
			Console.WriteLine($"Niz A prvi element {nizA[0]}");
			Console.WriteLine($"Niz B prvi element {nizB[0]}");

			string sA = "asd";
			string sB = sA; //asd, po vrednosti 
			sA = "qqq";

			Console.WriteLine(sB);


			/*for (int indeks = 0; indeks < nizA.Length; indeks++)
			{
				Console.Write($"  {nizA[indeks]}  ");
			}
			Console.WriteLine();
			Console.WriteLine("Niz B:");
			for (int indeks = 0; indeks < nizB.Length; indeks++)
			{
				Console.Write($"  {nizB[indeks]}  ");
			}*/

			Console.ReadKey();
		}
    }
}
