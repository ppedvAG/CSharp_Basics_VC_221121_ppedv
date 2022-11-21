namespace Arrays_Bedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 2, 34, 12, -456, 10000, 0, 982 };

            Console.WriteLine(zahlen[2]);
            zahlen[2] = 666;
            Console.WriteLine(zahlen[2]);

            string[] worte = new string[5];

            Console.WriteLine(zahlen.Length);

            Console.WriteLine(zahlen.Contains(-456));
            Console.WriteLine(zahlen.Contains(999));


            string beispiel = "Hallo";
            Console.WriteLine(beispiel[1]);


            int a = 45;
            int b = 45;

            if(a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if(a == 123 && b == 12)
            {
                Console.WriteLine("A ist 123 und B ist 12");
            }
            else if(a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
                Console.WriteLine("A ist gleich B");

            Console.WriteLine("ENDE DES IF-BLOCKS");


            string ausgabe = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            string name1 = "Hans";
            string name2 = "Hans";

            if (name1.Equals(name2))
            {
                Console.WriteLine("Namen sind gleich");
            }
        }
    }
}
