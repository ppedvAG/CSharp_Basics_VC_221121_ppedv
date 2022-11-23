using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    public class Mensch : Lebewesen
    {
        public string Vorname { get; set; }

        public Mensch(string vorname, string nachname, string nahrung, DateTime geburtsdatum, int größe) : base(nachname, nahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
        }

        public override string ToString()
        {
            return this.Vorname + " " + base.ToString();
        }

        public override Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Mensch(kindname, this.Name, "Babybrei", DateTime.Now, 30);
        }
    }
}
