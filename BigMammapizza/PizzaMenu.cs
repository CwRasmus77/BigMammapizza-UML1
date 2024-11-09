using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaMenu
    {
        public Dictionary<int, Pizza> Pizzas = new Dictionary<int, Pizza>();

        public PizzaMenu()
        {
            Pizzas.Add(1, new Pizza(1, "Margherita", "Tomato & Cheese", 69));
            Pizzas.Add(2, new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75));
            Pizzas.Add(3, new Pizza(3, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80));

        }
        public void RemoveById(int id)
        {

            if (id != null)
            {
                Pizzas.Remove(id);
            }

        }
        public void OpdaterNavn(int id, string navn)
        {
             Pizzas.ElementAt(id).Value.PizzaNavn = navn;
        }
        public void OpdaterBeskrivelse(int id, string beskrivelse)
        {
            Pizzas.ElementAt(id).Value.PizzaBeskrivelse = beskrivelse;
        }
        public void OpdaterPris(int id, double pris)
        {
            Pizzas.ElementAt(id).Value.PizzaPris = pris;
        }
       
        public List<Pizza> FindPizzaByToppings(string toppings)
        {
            List<Pizza> pizzas = new List<Pizza>();
            
            foreach (KeyValuePair<int, Pizza> entry in Pizzas)
                                                               
            {
                if (entry.Value.PizzaBeskrivelse.ToLower().Contains(toppings.ToLower()))
                {
                    pizzas.Add(entry.Value);
                }
          
            }
            PrintToppings(pizzas);
            return pizzas;
        }

        public void PrintToppings(List<Pizza> list)
        {
            foreach (Pizza pizza in list)
            {
                Console.WriteLine(pizza);
            }
        }



        public void PrintMenu()
        {
            
            foreach (KeyValuePair<int, Pizza> entry in Pizzas)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
    }
