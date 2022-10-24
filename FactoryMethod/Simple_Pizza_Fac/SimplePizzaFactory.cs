using Simple_Pizza_Fac.Pizzas;
using static Simple_Pizza_Fac.Pizzas.Pizza;

namespace Simple_Pizza_Fac.SimpleFactories
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "peperoni":
                    pizza = new PepperoniPizza();
                    break;

            }

            return pizza;

        }
    }
}