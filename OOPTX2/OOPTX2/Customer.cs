using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTX2
{
    public class Customer : Person
    {
        public int balance { get; set; }
        public Customer(string name, string address, int balance) : base(name, address)
        {
            this.balance = balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Customer: {name}, Address: {address}, Balance: {balance}");
        }
    }
}

