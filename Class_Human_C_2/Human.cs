using System;

namespace Class_Human_C_2
{
    public abstract class Human // запретила возможность создавать класс, только наследников
    {
        public string Surname { get; set; }
        
        protected string Name { get; set; }
        
        protected string Patronymic { get; set; }
        
        protected DateTime BirthDate { get; set; }
        
        protected Human() // создала конструктор без параметров
        {
        }
        
        protected Human(Human previousHuman) // создала конструктор копирования
        {
            Surname = previousHuman.Surname;
            Name = previousHuman.Name;
            Patronymic = previousHuman.Patronymic;
            BirthDate = previousHuman.BirthDate;
        }
        
        protected Human(string surname, string name, string patronymic, DateTime birth) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birth;
        }

        ~Human() // создала деструктор
        {
            Console.WriteLine("Объект {0} уничтожен", Surname);
        }

        protected int CalculateAge() // высчитала возраст на данный момент
        {
            var age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
                age--;
            return age;
        }

        protected string Print()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}, Дата рождения: {BirthDate}, Возраст: {CalculateAge()}";
        }
        
        public virtual void Edit()
        {
            var fieldToEdit = int.Parse(Console.ReadLine());
            
            switch (fieldToEdit)
            {
                case 1:
                    Console.WriteLine("Введите новую фамилию: ");
                    Surname = Console.ReadLine();
                    break;
                
                case 2:
                    Console.WriteLine("Введите новое имя: ");
                    Name = Console.ReadLine();
                    break;
                
                case 3:
                    Console.WriteLine("Введите новое отчество: ");
                    Patronymic = Console.ReadLine();
                    break;
                
                case 4:
                    Console.WriteLine("Введите новую дату рождения: ");
                    BirthDate = DateTime.Parse(Console.ReadLine());
                    break;
                
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
        }
        
        public virtual void Display()
        {
            Console.WriteLine($"ФИО: {Surname} {Name} {Patronymic}");
            Console.WriteLine($"Возраст: {CalculateAge()}");
        }
        
    }
}