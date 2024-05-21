using DemoOOP;
using System;

namespace OOPTX1
{



    public class Program
    {
        public static void addEmployee(List<Employee> employees)
        {
            Console.Write("Enter type of employee(1: Fulltime    2: PartTime): ");
            int employeeType = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter salary per hours: ");
            int salary = int.Parse(Console.ReadLine());

            try
            {
                if (employeeType == 1)
                {
                    employees.Add(new FullTimeEmployee(name, salary));
                }
                else if (employeeType == 2)
                {
                    Console.WriteLine("Enter number of hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    employees.Add(new PartTimeEmployee(name, salary, hours));
                }
                else
                {
                    Console.WriteLine("Please enter true type of employee");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void highestSalaryEmployee(List<Employee> employees)
        {
            if (employees.Count != 0)
            {
                var e = employees.OrderByDescending(emp => emp.calculateSalary()).FirstOrDefault();
                Console.WriteLine(e);
            }
            else { Console.WriteLine("List employee is empty!"); }

        }

        public static void getEmployeeByName(List<Employee> employees)
        {

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            var e = employees.FirstOrDefault(e => e.name.Contains(name, StringComparison.OrdinalIgnoreCase));
            if (e != null)
            {
                Console.WriteLine($"The employee has name is {name} was found");

            }
            else
            {
                Console.WriteLine($"Cannot find employee has name id {e}");

            }


        }

        public static void getListEmployee(List<Employee> employees)
        {
            Console.WriteLine("List employee: ");

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i].name}");
            }
        }


        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("1. Display List Employee");
                Console.WriteLine("2. Add New Employee");
                Console.WriteLine("3. Display Employee Has Best Salary In Fulltime And Parttime");
                Console.WriteLine("4. Search Employee");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        getListEmployee(employees);
                        break;
                    case 2:
                        addEmployee(employees);
                        break;
                    case 3:
                        highestSalaryEmployee(employees);
                        break;
                    case 4:
                        getEmployeeByName(employees);
                        break;
                    case 5:
                        break;
                }
            }


        }


    }
}
