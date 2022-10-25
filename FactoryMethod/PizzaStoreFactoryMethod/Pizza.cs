using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in Toppings)
            {
                Console.WriteLine("   " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("----" + Name + "----");
            result.AppendLine(Dough);
            result.AppendLine(Sauce);
            foreach(var toppings in Toppings)
            {
                result.AppendLine(toppings);
            }

            return result.ToString();
        }

        public class ChicagoStyleCheesePizza : Pizza
        {
            public ChicagoStyleCheesePizza()
            {
                Name = "Chicago Style Deep Dish Cheese Pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Shredded Mozzarella Cheese";

                Toppings.Add("Shredded Mozzarella Cheese");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }


        public class ChicagoStyleClamPizza : Pizza
        {
            public ChicagoStyleClamPizza()
            {
                Name = "Chicago Style Clam Pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Plum Tomato Sauce";

                Toppings.Add("Shredded Mozzarella Cheese");
                Toppings.Add("Frozen Clams from Chesapeake Bay");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        public class ChicagoStylePepperoniPizza : Pizza
        {
            public ChicagoStylePepperoniPizza()
            {
                Name = "Chicago Style Pepperoni Pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Plum Tomato Sauce";

                Toppings.Add("Shredded Mozzarella Cheese");
                Toppings.Add("Black Olives");
                Toppings.Add("Spinach");
                Toppings.Add("Eggplant");
                Toppings.Add("Sliced Pepperoni");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        public class ChicagoStyleVeggiePizza : Pizza
        {
            public ChicagoStyleVeggiePizza()
            {
                Name = "Chicago Deep Dish Veggie Pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Plum Tomato Sauce";

                Toppings.Add("Shredded Mozzarella Cheese");
                Toppings.Add("Black Olives");
                Toppings.Add("Spinach");
                Toppings.Add("Eggplant");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        public class NYStyleCheesePizza : Pizza
        {
            public NYStyleCheesePizza()
            {
                Name = "NY Style Sauce and Cheese Pizza";
                Dough = "Thin Crust Dough";
                Sauce = "Marinara Sauce";

                Toppings.Add("Grated Reggiano Cheese");
            }
        }


        public class NYStyleClamPizza : Pizza
        {
            public NYStyleClamPizza()
            {
                Name = "NY Style Clam Pizza";
                Dough = "Thin Crust Dough";
                Sauce = "Marinara Sauce";

                Toppings.Add("Grated Reggiano Cheese");
                Toppings.Add("Fresh Clams from Long Island Sound");
            }
        }

        public class NYStylePepperoniPizza : Pizza
        {
            public NYStylePepperoniPizza()
            {
                Name = "NY Style Pepperoni Pizza";
                Dough = "Thin Crust Dough";
                Sauce = "Marinara Sauce";

                Toppings.Add("Grated Reggiano Cheese");
                Toppings.Add("Sliced Pepperoni");
                Toppings.Add("Garlic");
                Toppings.Add("Onion");
                Toppings.Add("Mushrooms");
                Toppings.Add("Red Pepper");
            }
        }


        public class NYStyleVeggiePizza : Pizza
        {
            public NYStyleVeggiePizza()
            {
                Name = "NY Style Veggie Pizza";
                Dough = "Thin Crust Dough";
                Sauce = "Marinara Sauce";

                Toppings.Add("Grated Reggiano Cheese");
                Toppings.Add("Garlic");
                Toppings.Add("Onion");
                Toppings.Add("Mushrooms");
                Toppings.Add("Red Pepper");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }
    }
}
