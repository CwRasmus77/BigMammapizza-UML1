using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Menu
    {
        private int PizzaId {  get; set; }
        private string PizzaMenu { get; set; }
        private string ListeToppings { get; set; }
        private string ListeIngredienser { get; set; }



        public Menu(int pizzaid, string pizzamenu, string listetoppings, string listeingredienser)
        {
            PizzaId = pizzaid;
            PizzaMenu = pizzamenu;
            ListeToppings = listetoppings;
            ListeIngredienser = listeingredienser;

        }
        public override string ToString() {  return PizzaId + " " + PizzaMenu + " " + ListeToppings + " " + ListeIngredienser; }

    }
}
