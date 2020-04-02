using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        // initlize a new empty list in the class itself, instead of the constructor
        // set as readonly so the empty list doesn't accidentally get re-initilized.
        public readonly List<Order> Orders = new List<Order>();

        // blue name = constructor
        // orange name = method
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
            // ... 
        }



    }






    //public int Id;
    //public string Name;
    //public List<Order> Orders;

    //public Customer()
    //{
    //    Orders = new List<Order>();
    //}

    //public Customer(int id)
    //    : this()
    //{
    //    this.Id = id;
    //}

    //public Customer(int id, string name)
    //    : this(id) // calls the constructor above that takes an Id parameter. 
    //{
    //    this.Name = name;
    //}

}
