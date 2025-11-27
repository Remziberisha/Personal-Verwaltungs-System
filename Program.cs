using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonalVerwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MitarbeiterVerwaltung verwaltung = new MitarbeiterVerwaltung();

            while (true)
            {
                Console.WriteLine("=== Personalverwaltung ===");
                Console.WriteLine("1 – Mitarbeiter anlegen");
                Console.WriteLine("2 – Mitarbeiter anzeigen");
                Console.WriteLine("3 – Mitarbeiter löschen");
                Console.WriteLine("4 – Krankheitstag hinzufügen");
                Console.WriteLine("5 – Beenden");
                Console.Write("Auswahl: ");

                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        Console.Write("Vorname: ");
                        string v = Console.ReadLine();

                        Console.Write("Nachname: ");
                        string n = Console.ReadLine();

                        Console.Write("Urlaubstage: ");
                        int u = int.Parse(Console.ReadLine());

                        verwaltung.MitarbeiterAnlegen(v, n, u);
                        break;

                    case "2":
                        verwaltung.MitarbeiterAusgeben();
                        break;

                    case "3":
                        verwaltung.MitarbeiterAusgeben();
                        Console.Write("Nummer zum Löschen: ");
                        int delIndex = int.Parse(Console.ReadLine()) - 1;
                        verwaltung.MitarbeiterLoeschen(delIndex);
                        break;

                    case "4":
                        verwaltung.MitarbeiterAusgeben();
                        Console.Write("Mitarbeiter-Nummer: ");
                        int krankIndex = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Datum (z. B. 2025-02-01): ");
                        string datum = Console.ReadLine();

                        verwaltung.KrankheitstagHinzufuegen(krankIndex, datum);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Ungültige Eingabe!\n");
                        break;
                }
            }

        }
    }
}
