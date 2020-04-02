using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Classes
{
    class Program
    {
        /// <summary>
        /// Two differnet ways to handle a conversion from string to int.
        /// One using a try/catch block with an exception
        /// The other uses the out method which is NOT recommended.
        /// </summary>
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
            // best way
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion failed");

            }

            // this way is not recommended
            var result = int.TryParse("abc", out int number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }

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

        // don't need to create a new Person because the Parse method is static.
        //var person = new Person();
        //var p = Person.Parse("John");
        //p.Introduce("Mosh");

        // old syntax
        //var customer = new Customer(1, "John");
        // new syntax (object initialization syntax)
        //var customer = new Customer
        //{
        //    Id = 1,
        //    Name = "John"
        //};

        //var order = new Order();
        //customer.Orders.Add(order);

        //Console.WriteLine(customer.Id);
        //Console.WriteLine(customer.Name);




        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
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