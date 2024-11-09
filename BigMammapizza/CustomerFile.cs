using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CustomerFile
    {
        public List<Kunde> Kunder = new List<Kunde>();


        public CustomerFile()
        {
            Kunder.Add(new Kunde(1, "Mikkel", "Skolevej 29", 21231243, "Mikkel@Skolemail.dk "));
            Kunder.Add(new Kunde(2, "Rasmus", "Spas-gården 4", 66675243, "Nussegøj@flimmerfod.dk "));
            Kunder.Add(new Kunde(3, "Henrik", "Byvej 2", 78210023, "HeHo@zealand.dk "));
            Kunder.Add(new Kunde(4, "Mads", "RoskildeVej 9", 53992143, "Mads123@gmail.com "));
            Kunder.Add(new Kunde(5, "Alexander", "Astersvej 293", 32111293, "MinMail@gmail.com "));
            Kunder.Add(new Kunde(6, "Fuk mi", "istegade 78", 11112229, "Fukmimail@istegadecougar.dk "));
            Kunder.Add(new Kunde(7, "Su", "Brønby strand 75", 11211287, "Sugmaemail@hotmail.dk "));
            Kunder.Add(new Kunde(8, "Bo", "Pilevej 90", 90834534, "Bananmouseelsker@gmail.com "));
            Kunder.Add(new Kunde(9, "Gurlig-gris", "Græsplæne 11", 47562839, "NoProfit@stealingyourgold.com "));
            Kunder.Add(new Kunde(10, "Zimba", "Savannegade 21", 23258725, "Vildsafari@monke.dk "));
        }
       
        public void RemoveById(int id) 
        {

            if (id != null)
            {
                Kunde temp = Kunder.Find(k => k.KundeId == id);
                Kunder.Remove(temp);
            }

        }
        public void OpdaterNavn(int id, string navn)
        {
            Kunder.Find(k => k.KundeId == id).KundeNavn = navn;
        }
        public void OpdaterAdresse(int id, string adresse)
        {
            Kunder.Find(k => k.KundeId == id).Adresse = adresse;
        }
        public void OpdaterTelefon(int id, int telefonnummer)
        {
            Kunder.Find(k => k.KundeId == id).TelefonNummer = telefonnummer;
        }
        public void OpdaterEmail(int id, string email)
        {
            Kunder.Find(k => k.KundeId == id).Email = email;
        }








        public void PrintMenu()
        {
            foreach (Kunde kunde in Kunder)
            {
                Console.WriteLine(kunde);
            }
        }
        
    }
}
