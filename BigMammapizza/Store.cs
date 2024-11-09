using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {

        public void start() 
        {
            Pizza pizza1 = new Pizza(1, "Margherita", "Tomat & ost", 69.00);
     
            Pizza pizza14 = new Pizza(14, "Esotica", "Tomato, ost, skinke, rejer & pineapple ", 80.00);

            Pizza pizza19 = new Pizza(19, "Big Mamma", "Tomato, gorgonzola, shrimp, asparagus & parma ham ", 90.00);
            


            Kunde kunde1 = new Kunde(1, "Rasmus", "letardgade", 12345678, "funkymonkey@jazzyjizzer.dk");
            Kunde kunde2 = new Kunde(2, "Henrik ", "Skolevej 12 ", 12398746, "Heho@edu.zealand.dk");
            Kunde kunde3 = new Kunde(3, "Mikkel ", "vejen 12 ", 29834722, "pikMail@Gmail.com");

            Ordre ordre1 = new Ordre(1, kunde1, 1, pizza1, pizza1.PizzaPris,"kommentar");
            Ordre ordre2 = new Ordre(2, kunde2, 14, pizza14, pizza14.PizzaPris, "kommentar");
            Ordre ordre3 = new Ordre(3, kunde3, 19, pizza19, pizza19.PizzaPris, "kommentar");

            Console.WriteLine(ordre1);
            Console.WriteLine();
            Console.WriteLine(ordre2);
            Console.WriteLine();
            Console.WriteLine(ordre3);
        }
    }

}
