using PizzaStore;

Store store = new Store();
store.start();

CustomerFile kundeliste = new CustomerFile();
kundeliste.Kunder.Add(new Kunde(11, "Seb-o natchoman", "kæmpeslangegade 21", 112, "massivsnake@anaconda.dk "));
kundeliste.RemoveById(10);
kundeliste.OpdaterNavn(2, "El Dorado");
kundeliste.OpdaterAdresse(2, "Nyvej 12");
kundeliste.OpdaterTelefon(2, 92389012);
kundeliste.OpdaterEmail(2, "updateretmail@mail.dk");

Console.WriteLine("\n");
kundeliste.PrintMenu();
Console.WriteLine("\n");
PizzaMenu pizzaMenu = new PizzaMenu();
pizzaMenu.Pizzas.Add(20,new Pizza(20, "Hawaii", "Tomat, Ost & ananas", 80));
pizzaMenu.OpdaterNavn(2, "Hawaii");
pizzaMenu.OpdaterBeskrivelse(2, "Tomat, Ost & ananas");
pizzaMenu.OpdaterPris(2, 80);
pizzaMenu.PrintMenu();
Console.WriteLine("\n");
pizzaMenu.FindPizzaByToppings("ananas");