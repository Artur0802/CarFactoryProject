using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactoryProject
{
    public class Car : IAssembly, IPrice
    {
        private BodyFactory body;
        private WheelFactory wheel;
        private EngineFactory engine;

        public Car(BodyFactory body, WheelFactory wheel, EngineFactory engine)
        {
            this.body = body;
            this.wheel = wheel;
            this.engine = engine;
        }

        public float Price { get { return this.body.Price + 4 * this.wheel.Price + this.engine.Price; } }

        public void Assembly()
        {
            Console.WriteLine("Your car is assembled. It contains:");
            this.body.Assembly();
            this.wheel.Assembly();
            this.engine.Assembly();
            Console.WriteLine("Car price - {0}", this.Price);
        }
    }
}
