using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public abstract class EngineFactory : IAssembly, IPrice
    {
        protected string type = "";
        protected int volume = 0;
        protected float price = 0;
        protected Tuning turbo = null;
        
        public abstract float Price { get; }

        public abstract void Assembly();

        protected int Vol_Valid(int v)
        {
            if (v <= 0)
            {
                Console.WriteLine("Engine's volume can't be 0");
                return 1300;
            }
            else return v;
        }

        protected float PriceValid
        {
            get
            {
                if (this.type == "gas")
                {
                    if (this.volume >= 2000)
                        return 2000;
                    else return 1500;
                }
                else
                {
                    if (this.volume >= 2000)
                        return 3000;
                    else return 2500;
                }
            }
        }
    }
}
