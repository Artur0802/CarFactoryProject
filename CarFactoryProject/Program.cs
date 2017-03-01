using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BodyFactory body = new BodyWithSpoilerAndAudioSystem("gray", "sedan");
            WheelFactory wheel = new SimpleWheel("universal", 15);
            EngineFactory engine = new EngineWithTurbo("gas", 2000);

            Car car = new Car(body, wheel, engine);
            car.Assembly();

            Console.ReadKey();
        }
    }
}
