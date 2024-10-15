using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Kunde
    {
        private int KundeId {  get; set; }
        private string KundeNavn { get; set; }
        private string Adresse { get; set; }
        private int TelefonNummer { get; set; }
        private string Email { get; set; }



        public Kunde(int kundeid, string kundenavn, string adresse, int telefonnummer, string email)
        {
            KundeId = kundeid;
            KundeNavn = kundenavn;
            Adresse = adresse;
            TelefonNummer = telefonnummer;
            Email = email;
        }

        public void Start()
        {
            Kunde kunde1 = new Kunde(1, "Rasmus", "letardgade", 12345678, "funkymonkey@jazzyjizzer.dk");


            Kunde kunde2 = new Kunde(2, "Henrik ", "Skolevej 12 ", 12398746, "Heho@edu.zealand.dk");
            
            
            Kunde kunde3 = new Kunde(3, "Mikkel ", "vejen 12 ", 29834722, "pikMail@Gmail.com");



        }
        public override string ToString() { return "kundenr " + KundeId + " Navn " + KundeNavn + " " + Adresse + " " + TelefonNummer + " " + Email; }
    }
}
