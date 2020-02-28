#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP01PlatformIntroduce
 * 项目描述 ：
 * 类 名 称 ：PI04ConsoleFormat
 * 类 描 述 ：控制台格式化输出
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-02-28 17:26:58
 * 更新时间 ：2020-02-28 17:26:58
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP01PlatformIntroduce
{
    public class PI04ConsoleFormat
    {
        #region CP01_04：控制台格式化输出
        /*
         *  例程编号：CP01_04
         *  摘要：
         *      控制台格式化输出
         *  说明：
         *      1）格式：Console.WriteLine("我叫{0}，今年{1}岁了",string,string);
         *      2）调换占位符的位置的影响("num1 = {1}, num2 = {0}, num3 = {2}", num1, num2)
         *          //多少个占位符就要给多少个数据，否则虽然能过编译，但执行的时候会抛异常
         *  步骤：
         *      1）简单的格式化输出代码
         *      2）调换占位符的位置
         *  变量：
         *      修饰符     变量类型         变量名     备注
         *                  string          name
         *                  int             age
         *  方法：
         *      修饰符         返回值类型     方法名            参数类型1   参数类型2    备注
         *                      void        ShowInfo         string     int
         *                      void        PositionChange      int     int   
         */
        /// <summary>
        /// 控制台格式化输出
        /// </summary>
        public static void CP01_04()
        {
            ShowInfo("兔子", 3);
            PositionChange(1, 2);
        }

        /// <summary>
        /// 简单的格式输出代码
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="age">岁数</param>
        public static void ShowInfo(string name, int age)
        {
            Console.WriteLine("我叫{0}，今年{1}岁了。", name, age);
        }

        /// <summary>
        /// 调换占位符的位置
        /// </summary>
        /// <param name="num1">0号位置的数据</param>
        /// <param name="num2">1号位置的数据</param>
        public static void PositionChange(int num1, int num2)
        {
            //Console.WriteLine("num1 = {1}, num2 = {0}, num3 = {2}", num1, num2);
            Console.WriteLine("num1 = {1}, num2 = {0}", num1, num2);
        }
        #endregion
    }
}