using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public abstract class BodyFactory : IAssembly, IPrice
    {
        protected string color = "";
        protected string type = "";
        protected float price = 0;
        protected Tuning audiosystem = null;
        protected Tuning spoiler = null;

        public abstract float Price { get; }

        public abstract void Assembly();
    }
}
