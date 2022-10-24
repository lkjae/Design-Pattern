using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_Pizza_Fac.SimpleFactories;
using Simple_Pizza_Fac.Pizzas;
namespace Simple_Pizza_Fac
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
        }
    }
}
