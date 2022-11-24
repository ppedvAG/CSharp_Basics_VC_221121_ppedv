namespace Delegates
{
    public delegate int MeinDelegate(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;

            delegateVariable = Addiere;

            int erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            delegateVariable = Subtrahiere;
            erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;

            erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Addiere;

            delegateVariable = null;


            Func<int, int, int> meinFunc = Addiere;

            FühreAus(meinFunc);
            FühreAus(Subtrahiere);



            List<string> Städteliste = new List<string>() { "München", "Berlin", "Hamburg", "Köln" };
            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            gefundeneStadt = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('H');
                    }
                );

            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith('H'); });

            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith('H'));

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

        }

        static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith('H');
        }

        static void FühreAus(Func<int, int, int> mehrLogik)
        {
            Console.WriteLine(mehrLogik(12, 34));
        }

        static int Addiere(int a, int b) {Console.WriteLine("Addiere"); return a + b;  }
        static int Subtrahiere(int a, int b) { Console.WriteLine("Subtrahiere"); return a - b; }
    }
}