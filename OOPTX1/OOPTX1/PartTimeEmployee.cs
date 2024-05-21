using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTX1
{
    public class PartTimeEmployee : Employee
    {
        public int workingHours { get; set; }

        public PartTimeEmployee(string name, int workingPerHour, int workingHours) : base(name, workingPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary() => workingHours * paymentPerHour;
        public override string ToString()
        {
            return $"Name: {name} , Salary: {calculateSalary()}";
        }

    }
}
