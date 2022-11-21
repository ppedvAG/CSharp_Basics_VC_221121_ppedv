namespace HelloWorld
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int Alter;
            Alter = 32;

            string Stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);

            int DoppeltesAlter = Alter * 2;

            Console.WriteLine(DoppeltesAlter + Alter);


            char Textzeichen = 'A';

            double Gleitkommazahl = 345.12;
            Console.WriteLine(Gleitkommazahl);

            bool wahrheitswert = true;


            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);

            int a = 13;
            int b = 56;
            Console.WriteLine($"{a} + {b} = {a+b}");

            string bsp = $"Dies \\ist ein \t\"Tabulator\" und dies ein \n{{Zeilenumbruch}}.";
            Console.WriteLine(bsp);

            string path = "C:\\Programme\\App.exe";

            bsp = @"Dies ist ein    Tabulator und dies ein 
Zeilenumbruch.";
            Console.WriteLine(bsp);
            path = @"C:\Programme\app.exe";


            string formatierteZahl = String.Format("{0:0.00}", Alter);
            Console.WriteLine(formatierteZahl);

            Console.WriteLine("Bitte gib deinen Namen ein:");
            string eingabe = Console.ReadLine();
            Console.WriteLine($"Du heißt also {eingabe}.");


            Console.WriteLine("Bitte gib deine Lieblingszahl ein:");
            string zahlAlsString = Console.ReadLine();
            int zahl = int.Parse(zahlAlsString);
            zahl = zahl * 2;
            Console.WriteLine(zahl);


            int intZahl = 45;
            double doubleZahl = intZahl;

            doubleZahl = 45.89;
            intZahl = (int)doubleZahl;
            Console.WriteLine(intZahl);

            zahl = Convert.ToInt32(234.56);
            zahl = Convert.ToInt32("567");



        }

    }
}