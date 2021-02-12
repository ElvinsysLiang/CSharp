using CP00Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace CP00Forms
{
    class CP00TempPractice01
    {
        public static void Test01()
        {
            //三元运算符测试
            int var1 = 1;
            int var2 = 2;
            var1 = (var1 > var2 ? var1 = 3 : var2 = 4);
            Console.WriteLine(var1);
            Console.WriteLine(var2);
        }

    }
    
}
namespace One
{
    class OneClass
    {
        int var1 = 10;
    }
}
