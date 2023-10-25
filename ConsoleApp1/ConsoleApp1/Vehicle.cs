using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        public abstract string StartEngine();
    }

    public class Car : Vehicle
    {
        public override string StartEngine()
        {
            return "Car engine started";
        }
    }

    public class Bicycle : Vehicle
    {
        public override string StartEngine()
        {
            return "Pedaling the bicycle";
        }
    }
}
