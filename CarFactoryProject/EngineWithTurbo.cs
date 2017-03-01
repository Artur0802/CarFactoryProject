using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class EngineWithTurbo : EngineFactory
    {
        public EngineWithTurbo(string type, int volume)
        {
            base.type = type;
            base.volume = base.Vol_Valid(volume);
            base.price = base.PriceValid;
            base.turbo = new Turbo();
        }

        public override float Price { get { return base.price + base.turbo.Price; } }

        public override void Assembly()
        {
            Console.WriteLine("{0} engine ({1} cm3) tuned by {2}", base.type, base.volume, base.turbo.Name);
            Console.WriteLine("Engine price: {0}", this.Price);
        }
    }
}
