﻿namespace Fahrzeugpark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region Lab 06: Fahrzeug-Klasse
            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der Info()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.Info() + "\n");

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(-500);
            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");
            #endregion

            #region Lab 08: PKWs, Schiffe und Flugzeuge (Vererbung)

            //Instanziierung verschiedener Fahrzeuge
            PKW pkw1 = new PKW("Mercedes", 210, 23000, 5);
            Schiff schiff1 = new Schiff("Titanic", 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
            Flugzeug flugzeug1 = new Flugzeug("Boeing", 350, 90000000, 9800);

            //Ausgabe der verschiedenen Info()-Methoden
            Console.WriteLine(pkw1.Info());
            Console.WriteLine(schiff1.Info());
            Console.WriteLine(flugzeug1.Info());

            #endregion
        }
    }
}