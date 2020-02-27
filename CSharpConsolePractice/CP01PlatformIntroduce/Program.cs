#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP01PlatformIntroduce
 * 项目描述 ：
 * 类 名 称 ：Program
 * 类 描 述 ：关于C#入门的一些知识要点
 * 所在的域 ：LAPTOP-O6ENK577
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：LAPTOP-O6ENK577 
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-02-03 14:14:05
 * 更新时间 ：2020-02-27 13:33:33
 * 版 本 号 ：v1.0.0.0
 *******************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 *******************************************************************
 ----------------------------------------------------------------*/
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
            #region CS001：简单的Hello World程序
            /*
             *  例程编号：CS001
             *  摘要：
             *      简单的Hello World程序
             *  说明：
             *      1）在控制台上输出字符串，并换行
             *          Console.WriteLine("...");
             *      2）只是输出字符串，不换行
             *          Console.Write("...");
             *      3）在以前得visual studio中需要加上Console.ReadKey()方法，用来等待
             *      用户的输入，以防止终端一闪而过，在visual studio2019中并不需要。
             *  步骤：
             *      1）在控制台打印Hello World，演示简单的Hello World程序的写法
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             *      public static   void        ShowHelloWorld    null
             */
            #endregion
            Forms.Line("CS001");
            PI01HelloWorld.CS001();

            #region CS002：C#中常用到的快捷键
            /*
             *  例程编号：CS002
             *  摘要：
             *      C#中常用到的快捷键
             *  说明：
             *      F6：生成解决方案
             *      F5：编译并运行程序
             *      F12：查看某个方法定义的地方
             *      Ctrl+Z：撤销
             *      Ctrl+S：保存(一定要经常保存！)
             *      Ctrl+J：快速弹出智能提示
             *      Ctrl+K+D：快速对齐代码
             *      Ctrl+K+C：注释所选代码
             *      Ctrl+K+U：取消对所选代码的注释
             *      Ctrl+L：删除一行
             *      Shift+End 、Shift+Home
             *      F1：转到帮助文档（需要安装Help Viewer）
             *      折叠冗余代码：#region 和 #endregion
             *      当一个解决方案里面有多个项目的时候，需要设置解决方案属性，把“启动项目”设为“当前选定内容”。
             *      微软输入法试用\来作为顿号
             *  步骤：
             *      
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名    参数类型    备注
             */
            #endregion
            Forms.Line("CS002");
            PI02ShortcutKey.CS002();

            #region CS003：注释的用法，变量方法命名方式，两数相加
            /*
             *  例程编号：CS003
             *  摘要：
             *      注释的用法，变量方法命名方式，两数相加
             *  说明：
             *      1）注释的用法
             *          单行注释：//
             *          多行注释：/米...米/
             *          文档注释：///
             *      2）命名方式
             *          Pascal：
             *              类名：Person
             *              成员名：Number
             *              方法名：Add（）
             *          Camel：
             *              局部变量：userName
             *      3）定义变量和创建方法的方法
             *      4）键盘输入数据的方法
             *          通过Console.ReadLine()方法捕获用户从键盘输入的数据，但
             *          捕获的是字符串数据，需要通过Convert.ToInt32()转换格式。
             *  步骤：
             *      1）用户输入两个整形数据，计算两个整形数据相加的结果，返回一个整形数据
             *      2）在控制台上输出计算的结果
             *  变量：
             *      修饰符     变量类型     变量名     备注
             *                  int         var1
             *                  int         var2
             *                  int         result
             *      
             *  方法：
             *      修饰符         返回值类型    方法名     参数1类型  参数2类型   备注
             *      public static   int         MyAdd         int      int
             *      public static   void        ShowResult  int
             */
            #endregion
            Forms.Line("CS003");
            PI03Comments.CS003();
        }
    }
}
