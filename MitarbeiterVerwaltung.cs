using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace PersonalVerwaltungssystem
{
    public class MitarbeiterVerwaltung
    {
        private string dateiPfad = "mitarbeiter.json";
        public List<Mitarbeiter> MitarbeiterListe { get; private set; }

        public MitarbeiterVerwaltung()
        {
            LadeDaten();
        }

        // -----------------------
        // Json laden & speichern
        // -----------------------
        private void LadeDaten()
        {
            if (File.Exists(dateiPfad))
            {
                string json = File.ReadAllText(dateiPfad);
                MitarbeiterListe = JsonSerializer.Deserialize<List<Mitarbeiter>>(json);
            }
            else
            {
                MitarbeiterListe = new List<Mitarbeiter>();
            }
        }

        private void SpeichereDaten()
        {
            string json = JsonSerializer.Serialize(MitarbeiterListe, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dateiPfad, json);
        }

        // -----------------------
        // Mitarbeiter-Funktionen
        // -----------------------
        public void MitarbeiterAnlegen(string vorname, string nachname, int urlaubstage)
        {
            MitarbeiterListe.Add(new Mitarbeiter(vorname, nachname, urlaubstage));
            SpeichereDaten();
        }

        public void MitarbeiterLoeschen(int index)
        {
            if (index >= 0 && index < MitarbeiterListe.Count)
            {
                MitarbeiterListe.RemoveAt(index);
                SpeichereDaten();
            }
            else
            {
                Console.WriteLine("Ungültiger Index.");
            }
        }

        public void KrankheitstagHinzufuegen(int index, string datum)
        {
            if (index >= 0 && index < MitarbeiterListe.Count)
            {
                MitarbeiterListe[index].Krankheitstage.Add(datum);
                SpeichereDaten();
            }
            else
            {
                Console.WriteLine("Ungültiger Index.");
            }
        }

        public void MitarbeiterAusgeben()
        {
            if (MitarbeiterListe.Count == 0)
            {
                Console.WriteLine("Keine Mitarbeiter vorhanden.\n");
                return;
            }

            Console.WriteLine("\n--- Mitarbeiterliste ---");

            for (int i = 0; i < MitarbeiterListe.Count; i++)
            {
                var m = MitarbeiterListe[i];
                Console.WriteLine($"{i + 1}. {m.Vorname} {m.Nachname} | Urlaubstage: {m.Urlaubstage}");

                if (m.Krankheitstage.Count > 0)
                    Console.WriteLine($"   Krankheitstage: {string.Join(", ", m.Krankheitstage)}");
                else
                    Console.WriteLine("   Krankheitstage: Keine");
            }

            Console.WriteLine();
        }

    }
}
