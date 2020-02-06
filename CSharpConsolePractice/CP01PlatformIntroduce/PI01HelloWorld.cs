#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP01PlatformIntroduce
* 项目描述 ：
* 类 名 称 ：PI01HelloWorld
* 类 描 述 ：一个Hello World程序
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP01PlatformIntroduce
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-05 14:09:34
* 更新时间 ：2020-02-05 14:09:34
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace CP01PlatformIntroduce
{
    class PI01HelloWorld
    {
        /*
         *  例程编号：CS001（设计用例）
         *  说明：
         *      简单的Hello World程序
         *      以前如果不加ReadKey会因为控制台一闪而过，现在没必要加
         *  方法：
         *      修饰符          返回值类型     方法名            参数1
         *      public static   void          ShowHelloWorld    void
         */
        /// <summary>
        /// 在控制台打印Hello World字符串
        /// </summary>
        public static void ShowHelloWorld()
        {
            Console.WriteLine("Hello World.");
            //Console.ReadKey();
        }
    }
}
