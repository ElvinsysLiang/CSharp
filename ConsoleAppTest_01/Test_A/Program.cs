using System;
using TestLibrary_1;

namespace Test_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 1;
            int var2 = 2;
            ClassAdd a = new ClassAdd();
            Console.WriteLine("var1 + var2 = {0}", a.Add(var1,var2));
        }
    }
}
