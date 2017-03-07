using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PizzaFactory factory = new ConcretePizzaFactory();

            IPizza margarita = factory.GetPizza("Margarita");
            Console.WriteLine($"La margarita cuesta {margarita.getPrice()} euros");

            IPizza barbacoa = factory.GetPizza("Barbacoa");
            Console.WriteLine($"La barbacoa cuesta {barbacoa.getPrice()} euros");

            Console.ReadKey();
        }
    }
}