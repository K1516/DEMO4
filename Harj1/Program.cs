using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 1232;
            Console.WriteLine(" Car speed is " + car.Speed);
            Console.ReadLine();
        }
    }
}
