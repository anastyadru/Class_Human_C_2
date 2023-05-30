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
        
        public override void Edit()
        {
            base.Edit();
            var fieldToEdit = int.Parse(Console.ReadLine());
            switch (fieldToEdit)
            {
                case 1:
                    Console.WriteLine("Введите новую компанию:");
                    Company = Console.ReadLine();
                    break;
                
                case 2:
                    Console.WriteLine("Введите новую зарплату:");
                    Salary = int.Parse(Console.ReadLine());
                    break;
                
                case 3:
                    Console.WriteLine("Введите новый опыт работы:");
                    Experience = int.Parse(Console.ReadLine());
                    break;
                
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
        }

        public new void Display()
        {
            Console.WriteLine($"ФИО: {Surname} {Name} {Patronymic}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Компания: {Company}");
            Console.WriteLine($"Зарплата: {Salary}");
            Console.WriteLine($"Опыт работы: {Experience}");
        }
        
    }
}