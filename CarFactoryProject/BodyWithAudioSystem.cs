using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class BodyWithAudioSystem : BodyFactory
    {
        public BodyWithAudioSystem(string color, string type)
        {
            base.color = color;
            base.type = type;
            base.price = 3000;
            base.audiosystem = new AudioSystem();
        }

        public override float Price{ get { return base.price + base.audiosystem.Price; } }

        public override void Assembly()
        {
            Console.WriteLine("{0} {1} body tuned by {2}", base.color, base.type, base.audiosystem.Name);
            Console.WriteLine("Body price: {0}", this.Price);
        }
    }
}
