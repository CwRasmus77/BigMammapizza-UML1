using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Kunde
    {
        public int KundeId { get; set; }
        public string KundeNavn { get; set; }
        public string Adresse { get; set; }
        public int TelefonNummer { get; set; }
        public string Email { get; set; }



        public Kunde(int kundeid, string kundenavn, string adresse, int telefonnummer, string email)
        {
            KundeId = kundeid;
            KundeNavn = kundenavn;
            Adresse = adresse;
            TelefonNummer = telefonnummer;
            Email = email;
        }

       


        public override string ToString() { return "kundenr " + KundeId + " Navn " + KundeNavn + " " + Adresse + " " + TelefonNummer + " " + Email; }
    }
}
