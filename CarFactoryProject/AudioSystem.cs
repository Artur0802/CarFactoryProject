using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class AudioSystem : Tuning
    {
        public AudioSystem() { }
        
        public override string Name { get { return "audiosystem"; } }

        public override float Price { get { return 1000; } }
    }
}
