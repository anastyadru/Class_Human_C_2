using System;
using System.Collections.Generic;

namespace Class_Human_C_2
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Human> people = new List<Human>();

            Console.Write("Выберите, какое действие хотите выполнить:\n1) Добавить \n2) Изменить \n3) Удалить \nВаше решение: ");
            var action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:

                    Console.WriteLine("Введите фамилию: ");
                    var surname = Console.ReadLine();

                    Console.WriteLine("Введите имя: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Введите отчество: ");
                    var patronymic = Console.ReadLine();

                    Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ: ");
                    var birth = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Выберите, кого хотите добавить:\n1) student \n2) employee \n3) driver \nВаше решение: ");
                    var person = int.Parse(Console.ReadLine());

                    switch (person)
                    {
                        case 1:

                            Console.Write("Введите факультет: ");
                            var faculty = Console.ReadLine();

                            Console.Write("Введите курс: ");
                            var course = int.Parse(Console.ReadLine());

                            Console.Write("Введите группу: ");
                            var group = int.Parse(Console.ReadLine());

                            Student student = new Student(surname, name, patronymic, birth, faculty, course, group);
                            people.Add(student);
                            
                            Console.WriteLine("Данные студента добавлены:\n" + student.Print()); 

                            break;

                        case 2:

                            Console.Write("Введите название компании: ");
                            var company = Console.ReadLine();

                            Console.Write("Введите заработную плату: ");
                            var salary = int.Parse(Console.ReadLine());

                            Console.Write("Введите опыт работы: ");
                            var experience = int.Parse(Console.ReadLine());

                            Employee employee = new Employee(surname, name, patronymic, birth, company, salary, experience);
                            people.Add(employee);
                            
                            Console.WriteLine("Данные работника добавлены:\n" + employee.Print());

                            break;

                        case 3:

                            Console.Write("Введите название компании: ");
                            var company3 = Console.ReadLine();

                            Console.Write("Введите заработную плату: ");
                            var salary3 = int.Parse(Console.ReadLine());

                            Console.Write("Введите опыт работы: ");
                            var experience3 = int.Parse(Console.ReadLine());

                            Console.Write("Введите бренд: ");
                            var brand = Console.ReadLine();

                            Console.Write("Введите модель: ");
                            var model = Console.ReadLine();

                            Driver driver = new Driver(surname, name, patronymic, birth, company3, salary3, experience3, brand, model);
                            people.Add(driver);
                            
                            Console.WriteLine("Данные водителя добавлены:\n" + driver.Print());
                            
                            break;
                    }
                    break;     

                case 2:
                    
                    Console.WriteLine("Введите фамилию человека, данные которого хотите изменить: ");
                    var surnameToEdit = Console.ReadLine();
                    
                    var personToEdit = people.Find(p => p.Surname == surnameToEdit);

                    if (personToEdit != null)
                    {
                        Console.WriteLine("Выберите, какую информацию хотите изменить:\n1) Фамилия \n2) Имя \n3) Отчество \n4) Дата рождения \n5) Дополнительные поля (для студента, сотрудника или водителя) \nВаше решение: ");
                        var fieldToEdit = int.Parse(Console.ReadLine());

                        switch (fieldToEdit)
                        {
                            case 1:
                                
                                Console.WriteLine("Введите новую фамилию: ");
                                personToEdit.Surname = Console.ReadLine();
                                break;
                            
                            case 2:
                                
                                Console.WriteLine("Введите новое имя: ");
                                personToEdit.Name = Console.ReadLine();
                                break;
                            
                            case 3:
                                
                                Console.WriteLine("Введите новое отчество: ");
                                personToEdit.Patronymic = Console.ReadLine();
                                break;
                            
                            case 4:
                                
                                Console.WriteLine("Введите новую дату рождения в формате ДД.ММ.ГГГГ: ");
                                personToEdit.BirthDate = Convert.ToDateTime(Console.ReadLine());
                                break;
                            
                            case 5:
                                
                                if (personToEdit is Student)
                                {
                                    Console.WriteLine("Введите новый факультет: ");
                                    ((Student)personToEdit).Faculty = Console.ReadLine();

                                    Console.WriteLine("Введите новый курс: ");
                                    ((Student)personToEdit).Course = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите новую группу: ");
                                    ((Student)personToEdit).Group = int.Parse(Console.ReadLine());
                                }
                                
                                else if (personToEdit is Employee)
                                {
                                    Console.WriteLine("Введите новое название компании: ");
                                    ((Employee)personToEdit).Company = Console.ReadLine();

                                    Console.WriteLine("Введите новую заработную плату: ");
                                    ((Employee)personToEdit).Salary = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите новый опыт работы: ");
                                    ((Employee)personToEdit).Experience = int.Parse(Console.ReadLine());
                                }
                                
                                else
                                {
                                    Console.WriteLine("Введите новое название компании: ");
                                    ((Driver)personToEdit).Company = Console.ReadLine();

                                    Console.WriteLine("Введите новую заработную плату: ");
                                    ((Driver)personToEdit).Salary = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите новый опыт работы: ");
                                    ((Driver)personToEdit).Experience = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите новый бренд: ");
                                    ((Driver)personToEdit).Brand = Console.ReadLine();

                                    Console.WriteLine("Введите новую модель: ");
                                    ((Driver)personToEdit).Model = Console.ReadLine();
                                }
                                break;
                        }

                        Console.WriteLine("Изменения сохранены");
                    }

                    else
                    {
                        Console.WriteLine("Человек с такой фамилией не найден");
                    }
                    break;
                
                case 3:

                    Console.WriteLine("Введите фамилию человека, данные которого хотите удалить: ");
                    var surnameToDelete = Console.ReadLine();
                    
                    var personToDelete = people.Find(p => p.Surname == surnameToDelete);

                    if (personToDelete != null)
                    {
                        people.Remove(personToDelete);
                        Console.WriteLine("Информация о человеке удалена");
                    }
                    
                    else
                    {
                        Console.WriteLine("Человек с такой фамилией не найден");
                    }
                    break;
            }
        }
        
    }
}