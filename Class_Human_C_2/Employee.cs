using System;

namespace Class_Human_C_2
{
    public class Employee : Human
    {
        public string Company { get; set; }
        
        public int Salary { get; set; }
        
        public int Experience { get; set; }
        
        protected Employee() // создала конструктор без параметров
        {
        }

        public Employee(Employee previousEmployee) // создала конструктор копирования
        {
            Company = previousEmployee.Company;
            Salary = previousEmployee.Salary;
            Experience = previousEmployee.Experience;
        }
        
        public Employee(string surname, string name, string patronymic, DateTime  birth, string company, int salary, int experience)
            : base(surname, name, patronymic, birth) // создала конструктор с параметрами
        {
            Company = company;
            Salary = salary;
            Experience = experience;
        }
       
        ~Employee() // создала деструктор
        {
            Console.WriteLine("Объект {0} уничтожен", Company);
        }

        public new string Print()
        {
            return $"{base.Print()}, Компания: {Company}, ЗП: {Salary}, Опыт работы: {Experience}";
        }
        
    }
}