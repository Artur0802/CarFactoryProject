using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class SimpleWheel : WheelFactory
    {
        public SimpleWheel(string gumtype, int diameter)
        {
            base.gumtype = gumtype;
            base.diameter = base.Diam_Valid(diameter);
            base.price = base.PriceValid;
        }

        public override float Price { get { return base.price; } }

        public override void Assembly()
        {
            Console.WriteLine("4 wheels with {0} disks and {1} gum type", base.diameter, base.gumtype);
            Console.WriteLine("Wheels price: {0}", 4*this.Price);
        }
    }
}
