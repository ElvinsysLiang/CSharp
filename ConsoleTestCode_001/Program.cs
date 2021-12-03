using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestCode_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            //------------------------------
            //------------------------------
            //------------------------------
            //------------------------------
            Console.ReadKey();
        }



    }

    public class Student
    {
        private string _name;
        private int _age;
        public Student() { }
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
    }
}