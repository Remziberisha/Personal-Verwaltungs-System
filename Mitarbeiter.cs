using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltungssystem
{
    public class Mitarbeiter
    {
        public string Vorname {  get; set; }
        public string Nachname { get; set; }

        public int Urlaubstage { get; set; }
        
        public List <string> Krankheitstage { get; set; }

        public Mitarbeiter ()
        {
            Krankheitstage = new List <string> ();
        }

        public Mitarbeiter(string name, string nachNAme, int urlaubstage)
        {
            Vorname = name;
            Nachname = nachNAme;
            Urlaubstage = urlaubstage;
            Krankheitstage = new List<string> ();
        }
    }
}
