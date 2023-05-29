using System;

namespace Class_Human_C_2
{
    public abstract class Human // запретила возможность создавать класс, только наследников
    {
        public string Surname { get; set; }
        
        public string Name { get; set; }
        
        public string Patronymic { get; set; }
        
        public DateTime BirthDate { get; set; }
        
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

        private int CalculateAge() // высчитала возраст на данный момент
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        protected string Print()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}, Дата рождения: {BirthDate}, Возраст: {CalculateAge()}";
        }

    }
}