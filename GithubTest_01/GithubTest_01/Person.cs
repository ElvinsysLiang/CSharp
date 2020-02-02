using System;
using System.Collections.Generic;
using System.Text;

namespace GithubTest_01
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public void showInfo()
        {
            Console.WriteLine("这个人的名字叫" + Name + ",他已经" + Age + "岁了！");
        }
    }
}
