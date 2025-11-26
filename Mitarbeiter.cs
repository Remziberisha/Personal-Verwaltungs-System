using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltungssystem
{
    internal class Mitarbeiter
    {
        string name {  get; set; }
        string nachNAme { get; set; }

        int urlaubstage { get; set; }
        int krankheitstage { get; set; }

        public Mitarbeiter(string name, string nachNAme, int urlaubstage, int krankheitstage)
        {
            this.name = name;
            this.nachNAme = nachNAme;
            this.urlaubstage = urlaubstage;
            this.krankheitstage = krankheitstage;
        }
    }
}
