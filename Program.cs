using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Classes
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("HI {0}, I am {1}", to, Name);
        }

        // declare as static so we don't need to create a person obj
        // first before parsing

        // a static method is ONLY accessible from the CLASS and not the OBJECT.
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // don't need to create a new Person because the Parse method is static.
            //var person = new Person();
            //var p = Person.Parse("John");
            //p.Introduce("Mosh");

            // old syntax
            //var customer = new Customer(1, "John");
            // new syntax (object initialization syntax)
            var customer = new Customer
            {
                Id = 1,
                Name = "John"
            };

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured");
            }



        }
    }
}
