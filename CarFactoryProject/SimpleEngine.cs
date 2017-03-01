using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class SimpleEngine : EngineFactory
    {
        public SimpleEngine(string type, int volume)
        {
            base.type = type;
            base.volume = base.Vol_Valid(volume);
            base.price = base.PriceValid;
        }

        public override float Price { get { return base.price; } }

        public override void Assembly()
        {
            Console.WriteLine("{0} engine ({1} cm3)", base.type, base.volume);
            Console.WriteLine("Engine price: {0}", this.Price);
        }
    }
}
