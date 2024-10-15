using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
     public class ExtraToppings
    {
        private int ToppingId { get; set; }
        private string ToppingNavn { get; set; }
        private string Beskrivelse { get; set; }
        private double Pris { get; set; }


      
         public ExtraToppings(int toppingID, string toppingnavn, string beskrivelse, double pris)
        {  
            ToppingId = toppingID;
            ToppingNavn = toppingnavn;
            Beskrivelse = beskrivelse;
            Pris = pris;
        }

        public override string ToString() { return ToppingId + " " + ToppingNavn + " " + Beskrivelse + " " + Pris ; }
    }


}
