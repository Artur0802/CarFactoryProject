using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public abstract class Tuning : IPrice
    {
        public abstract string Name { get; }
        
        public abstract float Price{ get; }
    }
}
