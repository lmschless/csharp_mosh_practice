using System;

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
            var p = Person.Parse("John");
            p.Introduce("Mosh");
        }
    }
}
