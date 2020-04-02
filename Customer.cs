using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // calls the constructor above that takes an Id parameter. 
        {
            this.Name = name;
        }
    }
}
