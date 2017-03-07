using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PizzaFactory
    {
        public abstract IPizza GetPizza(string pizza);
    }

    public class ConcretePizzaFactory : PizzaFactory
    {
        public override IPizza GetPizza(string pizza)
        {
            switch (pizza.ToLower())
            {
                case "margarita":
                    return new Margarita();

                case "barbacoa":
                    return new Barbacoa();

                default:
                    throw new Exception($"No se ha podido elaborar ninguna pizza con el nombre {0}");
            }
        }
    }
}