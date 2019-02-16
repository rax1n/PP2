using System;

namespace Task2
{
    //я создал класс Student и ввел туда имя, ID и год обучения
    class Student
    {
        public string name;
        public string ID;
        public int year;

        //метод для принятия имени студента и айди в программу
        public Student(string name, string ID)
        {
            this.name = name;
            this.ID = ID;
        }

        //Метод для вывода Имени + Айди студента
        public void Print()
        {
            Console.WriteLine("Student's name is : " + this.name + Environment.NewLine + "Student's ID is: " + this.ID);
        }

        //Создаю инкреминтированный год обучения и вывожу на консоль
        public void IncrementYear()
        {
            year++;
            Console.WriteLine("Student's year of study is: " + year); //Вывод года обучения
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создаю переменную типа Student и передаю в неё имя и айди студента
            Student a = new Student(Console.ReadLine(), Console.ReadLine())
            {
                year = 1
            };
            a.Print();  
            a.IncrementYear();
        }
    }
}
