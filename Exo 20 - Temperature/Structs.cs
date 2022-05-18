using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_20___Temperature
{
    public struct Celsius
    {
        public double temperature;

        public Fahrenheit Convert()
        {
            Fahrenheit f;
            f.temperature = (this.temperature * (9 / 5D)) + 32;
            return f;

            //return new Fahrenheit() { temperature = (this.temperature * (9 / 5D)) + 32 };
        }
    }

    public struct Fahrenheit
    {
        public double temperature;

        public Celsius Convert()
        {
            Celsius c;
            c.temperature = (this.temperature - 32) * (5 / 9D);
            return c;

            //return new Celsius() { temperature = (this.temperature - 32) * (5 / 9D) };
        }
    }
}
