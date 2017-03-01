using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public abstract class WheelFactory : IAssembly, IPrice
    {
        protected string gumtype = "";
        protected int diameter = 0;
        protected float price = 0;
        
        public abstract float Price { get; }

        public abstract void Assembly();

        protected int Diam_Valid(int d)
        {
            if (d <= 10)
            {
                Console.WriteLine("Disk diameter can't be smaller than 11" + '"');
                return 11;
            }
            else return d;
        }

        protected float PriceValid
        {
            get
            {
                if (this.diameter <= 15)
                {
                    if (this.gumtype == "universal")
                        return 300;
                    else return 400;
                }
                else
                {
                    if (this.gumtype == "universal")
                        return 500;
                    else return 600;
                }
            }
        }
    }
}
