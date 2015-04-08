using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature=0;
            Console.WriteLine("Welcome To Temperature converter");
            string input;
            Console.WriteLine("Input Celsius");
            input= Console.ReadLine();
            Double.TryParse(input, out temperature);
            Console.WriteLine(temperature);
            
            Console.WriteLine("Celsius degres:"+temperature);
            Console.WriteLine("Kelvin degres:" + (temperature+273.15));
           // temperature=(temperature-32);
           // float temp = 5 / 9;
           // temperature = temperature * temp;
            //Console.WriteLine("Fahrenheit degres:" + ((temperature - 32) * (5 / 9)));
          //  Console.WriteLine("Fahrenheit degres:" + temperature+" "+temp);
            Console.ReadKey();
        }
    }
}
