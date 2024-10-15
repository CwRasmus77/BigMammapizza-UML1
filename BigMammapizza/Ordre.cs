using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Ordre
    {
        public int OrdreNummer { get; private set; }
        public string KundeOplysninger { get; private set; }
        public int ListeBestiltePizzaer { private get; set; }
        public double Pris { get; private set; }
        public Pizza _pizza { get; private set; }
        public Kunde _kunde { get; private set; }


        public Ordre(int ordrenummer, Kunde kunde, int listebestiltepizzaer, Pizza pizza, double pris)
        { 
            OrdreNummer = ordrenummer;
            _kunde = kunde;
            ListeBestiltePizzaer = listebestiltepizzaer;
            _pizza = pizza;
            Pris = CalculateTotalPrice(pizza);


        }
        public static double CalculateTotalPrice(Pizza pizza)
        {
            double tax = 1.25;
            double levering = 40;
            double total = pizza.PizzaPris * tax + levering;
            return total;
        }




        public override string ToString() { return "Order Nr " + OrdreNummer + "  " + _kunde + " Pizza " + _pizza + "   " + " Total pris " + Pris + "kr"; }

    }
}
