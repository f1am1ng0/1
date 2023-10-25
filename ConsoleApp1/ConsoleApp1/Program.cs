using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        /* 1
        static void Main(string[] args)
        {
            int age = 21;
            string name = "robi";

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{name} i={i}.");
            }
        } */


        /* 2
        static void Main(string[] args)
        {
            Person person = new Person("Robi", 21);
            Console.WriteLine(person.Introduction());
        } */


        /* 3
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine($"Rectangle Area (5x6): {rect.CalculateArea(5, 6)}");

            Circle circle = new Circle();
            Console.WriteLine($"Circle Area (radius 5): {circle.CalculateArea(5)}");
        } */


        /* 4
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.StartEngine());

            Bicycle bicycle = new Bicycle();
            Console.WriteLine(bicycle.StartEngine());
        } */

        /* 5
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();

            intList.Add(5);
            intList.Add(10);
            intList.Add(15);

            Console.WriteLine(intList.Get(1)); 
        } */
    }
}
