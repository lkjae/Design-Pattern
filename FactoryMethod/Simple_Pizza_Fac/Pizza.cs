using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Pizza_Fac.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing" + Name);
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
        public class CheesePizza : Pizza
        {
            public CheesePizza()
            {
                Name = "Cheese Pizza";
                Dough = "Regular Crust";
                Sauce = "Marinara Pizza Sauce";

                Toppings.Add("Fresh Mozzarella");
                Toppings.Add("Parmesan");
            }

        }
        public class ClamPizza : Pizza
        {
            public ClamPizza()
            {
                Name = "Clam Pizza";
                Dough = "Thin crust";
                Sauce = "White garlic sauce";

                Toppings.Add("Clams");
                Toppings.Add("Grated parmesan cheese");
            }
        }

        public class PepperoniPizza : Pizza
        {
            public PepperoniPizza()
            {
                Name = "Pepperoni Pizza";
                Dough = "Crust";
                Sauce = "Marinara sauce";

                Toppings.Add("Sliced Pepperoni");
                Toppings.Add("Sliced Onion");
                Toppings.Add("Grated parmesan cheese");
            }
        }

        public class VeggiePizza : Pizza
        {
            public VeggiePizza()
            {
                Name = "Veggie Pizza";
                Dough = "Crust";
                Sauce = "Marinara sauce";

                Toppings.Add("Shredded mozzarella");
                Toppings.Add("Grated parmesan");
                Toppings.Add("Diced onion");
                Toppings.Add("Sliced mushrooms");
                Toppings.Add("Sliced red pepper");
                Toppings.Add("Sliced black olives");
            }
        }
    }

   
}
