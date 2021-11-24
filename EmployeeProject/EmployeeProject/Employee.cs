using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProject
{
    public class Employee
    {
        //class
        public int ID { get; set; }
        public string surname;
        public string name;
        public string name_of_father;
        public string department;
        public int tel;

        //starting data
        private string[] surnames = new string[] { "Bradu", "Makalich", "Mansur", "Moiseenko", "Yretya", "Ptahin" };
        private string[] names = new string[] { "Alexey", "Denis", "Issa", "Vitaliy", "Vadim", "Sasha" };
        private string[] names_of_father = new string[] { "Alexeevich", "Denisovich", "Alexandrovich", "Vitalievich", "Vadimovich" };
        private string[] departments = new string[] { "Бухгалтерия", "Отдел кадров", "Справочная"};

        public Employee()
        {
            Random rand = new Random();

            surname = surnames[new Random().Next(0, surnames.Length)];
            name = names[new Random().Next(0, names.Length)];
            name_of_father = names_of_father[new Random().Next(0, names_of_father.Length)];
            department = departments[new Random().Next(0, departments.Length)];
        }

        public void GetInfo()
        {
            Console.WriteLine("{0,4} | {1,10} | {2,10} | {3,15} | {4,15} | {5}",
                ID, surname, name, name_of_father, department, tel);
        }
    }
}
