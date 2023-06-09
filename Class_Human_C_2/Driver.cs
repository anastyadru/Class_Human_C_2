﻿using System;

namespace Class_Human_C_2
{
    internal sealed class Driver : Employee // запретила наследование от этого класса
    {
        private string Brand { get; set; }
        
        private string Model { get; set; }
        
        public Driver() // создала конструктор без параметров
        {
        }
        
        public Driver(Driver previousDriver) // создала конструктор копирования
        {
            Brand = previousDriver.Brand;
            Model = previousDriver.Model;
        }
        
        public Driver(string surname, string name, string patronymic, DateTime  birth, string company, int salary, int experience, string brand, string model)
            : base(surname, name, patronymic, birth, company, salary, experience) // создала конструктор с параметрами
        {
            Brand = brand;
            Model = model;
        }
        
        ~Driver() // создала деструктор
        { 
            Console.WriteLine("Объект {0} уничтожен", Brand);
        }
        
        public new string Print()
        {
            return $"{base.Print()}, Бренд: {Brand}, Модель: {Model}";
        }
        
        public override void Edit()
        {
            base.Edit();
            var fieldToEdit = int.Parse(Console.ReadLine());
            
            switch (fieldToEdit)
            {
                case 1:
                    Console.WriteLine("Введите новый бренд: ");
                    Brand = Console.ReadLine();
                    break;
                
                case 2:
                    Console.WriteLine("Введите новую модель: ");
                    Model = Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
        }

        protected override void Display()
        {
            base.Display();
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
        }
        
    }
}