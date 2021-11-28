using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace EmployeeProject
{
    // IEnumerable for foreach
    class Employees : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }


        // list of objects
        List<Employee> employees = new List<Employee>();

        // constructor with randomize ID and tel of employees
        public Employees(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Employee employee = new Employee();
                Random rand = new Random();
                employee.ID = 1000 + i;
                employee.tel = 100 + i;

                employees.Add(employee);
            }
        }

        // a method for sorting a table by column number
        public List<Employee> SortByN(int number)
        {
            var employeesSorted = employees.OrderBy(t => t);

            switch (number)
            {
                case 0:
                    employeesSorted = employees.OrderBy(t => t.ID);
                    break;
                case 1:
                    employeesSorted = employees.OrderBy(t => t.surname);
                    break;
                case 2:
                    employeesSorted = employees.OrderBy(t => t.name);
                    break;
                case 3:
                    employeesSorted = employees.OrderBy(t => t.name_of_father);
                    break;
                case 4:
                    employeesSorted = employees.OrderBy(t => t.department);
                    break;
                case 5:
                    employeesSorted = employees.OrderBy(t => t.tel);
                    break;
                default:
                    throw new ArgumentException();
            }
            employees = new List<Employee>() { };
            foreach (Employee figure in employeesSorted)
                employees.Add(figure);
            return employees;
        }

        // method for getting info about
        // ONE employee by his id
        public Employee OutputById(int id)
        {
            IEnumerable<Employee> employeesSorted = employees.Where(t => t.ID == id);

            Employee employee = employeesSorted.FirstOrDefault();

            return employee;
        }

        // method for getting info about
        // department and count of employees
        // and outputing
        public void CountEmployeesByDepartment()
        {
            var info = employees.GroupBy(t => t.department)
                            .Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var info_obj in info)
            {
                Console.WriteLine($"{info_obj.Name} : {info_obj.Count}");
            }
        }
    }
}
