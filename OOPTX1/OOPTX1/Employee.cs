using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTX1
{
    public abstract class Employee : IEmployee
    {
        public string name { get; set; }
        public int paymentPerHour { get; set; }


        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }
        public abstract int calculateSalary();

        public string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return $"name = {name}, paymentPerHour = {paymentPerHour}";
        }
    }
}
