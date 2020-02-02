using System;

namespace GithubTest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("现在测试一下刚刚写的Person类");
            Console.WriteLine("首先，用无参构造，实例化一个Person类p1，名字叫Jacob，43岁");
            Person p1 = new Person();
            p1.Name = "Jacob";
            p1.Age = 43;
            p1.showInfo();
            Console.WriteLine("然后，用有参构造，实例化一个Person类p2，名字叫Liy，16岁");
            Person p2 = new Person("Liy", 16);
            p2.showInfo();

            Console.ReadKey();
        }
    }
}
