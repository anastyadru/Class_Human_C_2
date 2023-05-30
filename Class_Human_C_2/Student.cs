using System;

namespace Class_Human_C_2
{
    public class Student : Human
    {
        public string Faculty { get; set; }
        
        public int Course { get; set; }
        
        public int Group { get; set; }
        
        public Student() // создала конструктор без параметров
        {
        }
        
        public Student(Student previousStudent) // создала конструктор копирования
        {
            Faculty = previousStudent.Faculty;
            Course = previousStudent.Course;
            Group = previousStudent.Group;
        }
        
        public Student(string surname, string name, string patronymic, DateTime birth, string faculty, int course, int group)
            : base(surname, name, patronymic, birth) // создала конструктор с параметрами
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        ~Student() // создала деструктор
        {
            Console.WriteLine("Объект {0} уничтожен", Faculty);
        }

        public new string Print()
        {
            return $"{base.Print()}, Факультет: {Faculty}, Курс: {Course}, Группа: {Group}";
        }

        public override void Edit()
        {
            base.Edit();
            var fieldToEdit = int.Parse(Console.ReadLine());
            
            switch (fieldToEdit)
            {
                case 1:
                    Console.WriteLine("Введите новую фамилию:");
                    Surname = Console.ReadLine();
                    break;
                
                case 2:
                    Console.WriteLine("Введите новое имя:");
                    Name = Console.ReadLine();
                    break;
                
                case 3:
                    Console.WriteLine("Введите новое отчество:");
                    Patronymic = Console.ReadLine();
                    break;
                
                case 4:
                    Console.WriteLine("Введите новую дату рождения:");
                    BirthDate = DateTime.Parse(Console.ReadLine());
                    break;
                
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
        }
        
        public void Display()
        {
            Console.WriteLine($"ФИО: {Surname} {Name} {Patronymic}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Группа: {Group}");
        }

    }
}