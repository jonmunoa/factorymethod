using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IPizza
    {
        double getPrice();
    }

    public class Margarita : IPizza
    {
        public double getPrice()
        {
            return 9.90;
        }
    }

    public class Barbacoa : IPizza
    {
        public double getPrice()
        {
            return 12.90;
        }
    }
}