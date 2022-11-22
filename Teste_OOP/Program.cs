using OOP_Beispiel;

namespace Teste_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OOP_Beispiel.Lebewesen lebewesen1 = new Lebewesen("Hugo Schmidt", "Lasagne", new DateTime(2002, 2, 12), 182);
            Lebewesen lebewesen2 = new Lebewesen("Anna Meier", "Kartoffeln", new DateTime(2004, 12, 24), 178);

            Console.WriteLine(lebewesen1.Name);
            Console.WriteLine(lebewesen2.Name);
            Console.WriteLine(lebewesen1.Lieblingsnahrung);
            Console.WriteLine(lebewesen2.Lieblingsnahrung);

            lebewesen1.Lieblingsnahrung = "Spagetti";

            Console.WriteLine(lebewesen1.Lieblingsnahrung);
            Console.WriteLine(lebewesen2.Lieblingsnahrung);

            Console.WriteLine(lebewesen2.Alter);

            Console.WriteLine(lebewesen1.Größe);
            lebewesen1.Wachse();
            Console.WriteLine(lebewesen1.Größe);

            lebewesen1 = lebewesen2.ProduziereNachwuchs("Maria Meier");

        }
    }
}