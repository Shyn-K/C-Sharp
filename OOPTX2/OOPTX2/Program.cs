using System;
using System.Collections.Generic;
using System.Linq;
using OOPTX2;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();

        // Add some sample employees and customers for testing
        employees.Add(new Employee("Nguyen Van A", "address1", 5000));
        employees.Add(new Employee("Nguyen Van B", "address2", 6000));
        customers.Add(new Customer("Nguyen Van C", "address3", 2000));
        customers.Add(new Customer("Nguyen Van D", "address4", 1500));

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Customer with Lowest Balance");
            Console.WriteLine("5. Find Employee by Name");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    AddCustomer(customers);
                    break;
                case 3:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 4:
                    FindLowestBalanceCustomer(customers);
                    break;
                case 5:
                    FindEmployeeByName(employees);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        try
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee address: ");
            string address = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            int salary = int.Parse(Console.ReadLine());

            employees.Add(new Employee(name, address, salary));
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input: " + e.Message);
        }
    }

    static void AddCustomer(List<Customer> customers)
    {
        try
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();

            Console.Write("Enter customer balance: ");
            int balance = int.Parse(Console.ReadLine());

            customers.Add(new Customer(name, address, balance));
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input: " + e.Message);
        }
    }

    static void FindHighestSalaryEmployee(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees in the list.");
            return;
        }

        var highestSalaryEmployee = employees.OrderByDescending(e => e.salary).FirstOrDefault();

        if (highestSalaryEmployee != null)
        {
            Console.WriteLine("Employee with the highest salary: ");
            highestSalaryEmployee.Display();
        }
        else
        {
            Console.WriteLine("No employee found.");
        }
    }

    static void FindLowestBalanceCustomer(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customers in the list.");
            return;
        }

        var lowestBalanceCustomer = customers.OrderBy(c => c.balance).FirstOrDefault();

        if (lowestBalanceCustomer != null)
        {
            Console.WriteLine("Customer with the lowest balance: ");
            lowestBalanceCustomer.Display();
        }
        else
        {
            Console.WriteLine("No customer found.");
        }
    }

    static void FindEmployeeByName(List<Employee> employees)
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        var employee = employees.FirstOrDefault(e => e.getName().Contains(name, StringComparison.OrdinalIgnoreCase));

        if (employee != null)
        {
            Console.WriteLine("Employee found: ");
            employee.Display();
        }
        else
        {
            Console.WriteLine($"No employee found with name {name}");
        }
    }
}
