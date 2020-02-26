#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP01PlatformIntroduce
* 项目描述 ：
* 类 名 称 ：Program
* 类 描 述 ：
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP01PlatformIntroduce
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-03 14:14:05
* 更新时间 ：2020-02-03 14:14:05
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion



//引用命名空间。注意，后面要带分号
using System;
using CP00Forms;

//项目名称（命名空间）
namespace CP01PlatformIntroduce
{
    //Program类，里面一般是程序入口处
    class Program
    {
        //Main函数，程序入口
        static void Main(string[] args)
        {
            /*
             *  例程编号：CS001
             *  摘要：
             *      简单的Hello World程序
             *  要点：
             *      1)在控制台上输出字符串，并换行
             *          Console.WriteLine("...");
             *      2)只是输出字符串，不换行
             *          Console.Write("...");
             *      3)在以前得visual studio中需要加上Console.ReadKey()方法，用来等待
             *      用户的输入，以防止终端一闪而过，在visual studio2019中并不需要。
             *  步骤：
             *      1)在控制台打印Hello World，演示简单的Hello World程序的写法
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             *      public static   void        ShowHelloWorld    null
             */
            Forms.Line("CS001");
            PI01HelloWorld.CS001();

            /*
             *  例程编号：CS002（实现用例）
             *  说明：
             *      （设计用例————PI03Comments）
             *      用于理解文档注释的使用方法
             *  摘要：
             *      在控制台上输出两个整形变量相加的结果
             */
            Forms.Rule("CS002");
            PI03Comments.Show(PI03Comments.MyAdd(1, 2));

        }
    }
}
