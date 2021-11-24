using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees(15);

            foreach (Employee x in employees)
                x.GetInfo();

            Console.WriteLine("Введите столбец:");
            int number = int.Parse(Console.ReadLine());

            List<Employee> employeesSorted = employees.SortByN(number);
            foreach (Employee x in employees)
                x.GetInfo();
        }
    }
}
