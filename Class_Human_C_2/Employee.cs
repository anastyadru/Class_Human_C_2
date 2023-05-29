using System;

namespace Class_Human_C_2
{
    public class Employee : Human
    {
        public string Company { get; set; }
        
        public int Salary { get; set; }
        
        public int Experience { get; set; }
        
        public Employee() // создала конструктор без параметров
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

        public override string Surname { get; set; }
        public override string Name { get; set; }
        public override string Patronymic { get; set; }
        public override DateTime BirthDate { get; set; }
        
        public override int CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                age--;
            return age;
        }
        
        public new string Print()
        {
            return $"{base.Print()}, Возраст: {CalculateAge()}, Компания: {Company}, ЗП: {Salary}, Опыт работы: {Experience}";
        }
        
    }
}