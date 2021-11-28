using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating table
            Employees employees = new Employees(15);

            // outputing table
            foreach (Employee x in employees)
                x.GetInfo();

            Console.WriteLine();

            // getting column number
            Console.WriteLine("Введите столбец:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // sorting by column number and outputing
            List<Employee> employeesSorted = employees.SortByN(number);
            foreach (Employee x in employees)
                x.GetInfo();

            Console.WriteLine();

            // getting ID of employee
            Console.WriteLine("Введите ID работника:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // getting info about ONE employee
            // by his id and outputing
            Employee employee = employees.OutputById(id);
            employee.GetInfo();

            Console.WriteLine();

            // getting info about
            // department and count of employees
            // and outputing
            employees.CountEmployeesByDepartment();
        }
    }
}
