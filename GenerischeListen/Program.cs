namespace GenerischeListen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Städteliste = new List<string>()
            {
                "Nürnberg",
                "Dortmund",
                "Bielefeld"
            };

            Städteliste.Add("Hamburg");
            Städteliste.Add("Berlin");
            Städteliste.Add("München");
            Städteliste.Add("Köln");
            Städteliste.Add("Düsseldorf");

            Console.WriteLine(Städteliste.Count);

            Console.WriteLine(Städteliste[3]);

            Städteliste[3] = "Dresden";
            Console.WriteLine(Städteliste[3]);

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            Städteliste.Remove("Hamburg");


            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("Hallo", 123);
            dict.Add("Ahoj", -2);
            dict.Add("Moin", 666);
            dict.Add("Ciao", 0);

            Console.WriteLine(dict["Moin"]);
        }
    }
}