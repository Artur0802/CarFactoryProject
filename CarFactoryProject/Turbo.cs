using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class Turbo : Tuning
    {
        public Turbo() { }
        
        public override string Name{ get { return "turbo"; } }

        public override float Price { get { return 2000; } }
    }
}
