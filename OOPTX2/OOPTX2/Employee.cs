using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTX2
{
    public class Employee : Person
    {
        public int salary { get; set; }
        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }

        public override void Display()
        {
            Console.WriteLine($"Customer: {name}, Address: {address}, Balance: {salary}");
        }
    }
}
