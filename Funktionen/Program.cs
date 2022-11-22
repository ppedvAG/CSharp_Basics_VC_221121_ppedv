namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(123, -23);
            Console.WriteLine(summe);

            double dblSumme = Addiere(2.4, 4.7);
            Console.WriteLine(dblSumme);

            int differenz = Subtrahiere(100, 34, d: 45);

            summe = BildeSumme(3, 5, 7, -2, 7556, 12);

            summe = AddiereUndSubtrahiere(123, 43, out differenz);
            Console.WriteLine(summe);
            Console.WriteLine(differenz);


            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out int geparsterWert))
            {
                Console.WriteLine(geparsterWert * 2);
            }
        }

        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static int Subtrahiere(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (var item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int diff)
        {
            diff = a - b;

            return a + b;
        }

    }
}