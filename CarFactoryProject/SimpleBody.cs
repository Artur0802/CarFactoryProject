using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class SimpleBody : BodyFactory
    {
        public SimpleBody(string color, string type)
        {
            base.color = color;
            base.type = type;
            base.price = 3000;
        }

        public override float Price
        {
            get
            {
                return base.price;
            }
        }

        public override void Assembly()
        {
            Console.WriteLine("{0} {1} body", base.color, base.type);
            Console.WriteLine("Body price: {0}", this.Price);
        }
    }
}
