using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        

        

        interface IMovable
        {
            void Move();
        }
        class Person : IMovable
        {
            public void Move() => Console.WriteLine("Человек идет");
        }
        public struct Car : IMovable
        {
            public void Move() => Console.WriteLine("Машина едет");
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            person.Move();
            car.Move();

            void Print(IMovable pp) => pp.Move();
            Print(person);
            Print(car);
        }
    }
}
