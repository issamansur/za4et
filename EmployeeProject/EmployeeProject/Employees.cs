using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace EmployeeProject
{
    class Employees : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }


    //list of objects
    List<Employee> employees = new List<Employee>();

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


        public List<Employee> SortByN(int id)
        {
            var employeesSorted = employees.OrderBy(t => t);

            switch (id)
            {
                case 0:
                    employeesSorted = employees.OrderBy(t =>t.ID);
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
    }
}
