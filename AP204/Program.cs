using System;

namespace AP204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;



            Student student = new Student("Fazil","Quliyev");
           
            student.Fullname();

            Student student1 = new Student("Fazil","Quliyev","Ap204",100);
            
            student1.AllInfo();

            student1.Enter();

            
            
        }

        
    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;
        

        public void Fullname()
        {
            
            Console.WriteLine($"Name: {Name}, Surname: {Surname}") ;
        }

        public void AllInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, IsGraduated: {isGraduated}");
        }
        
        public void Enter()
        {
            Console.WriteLine("Balinizi daxil edin");
            byte point = Convert.ToByte(Console.ReadLine());
            
            if(80 < point)
            {
                Console.WriteLine("ikinci imtahana gire biler");
            }
            else
            {
                Console.WriteLine("getdin esgere");
            }
        }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = false;
        }
    }
    
}
