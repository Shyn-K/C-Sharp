using OOPTX1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoOOP
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return paymentPerHour * 8;
        }
        public override string ToString()
        {
            return $"Employee {name}, Salary {calculateSalary()}";
        }


    }
}
