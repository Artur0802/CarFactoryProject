using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class Spoiler : Tuning
    {
        public Spoiler() { }
        
        public override string Name { get { return "spoiler"; } }

        public override float Price { get { return 500; } }
    }
}
