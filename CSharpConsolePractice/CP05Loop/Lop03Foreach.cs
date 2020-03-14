#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP05Loop
 * 项目描述 ：
 * 类 名 称 ：Lop03Foreach
 * 类 描 述 ：foreach的例程
 * 命名空间 ：CP05Loop
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-12 15:17:13
 * 更新时间 ：2020-03-12 15:17:13
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP05Loop
{
    public class Lop03Foreach
    {
        #region CP05_27：foreach的简单例程
        /*
         *  例程编号：CP05_27
         *  摘要：
         *      foreach的简单例程
         *  说明：
         *      1）定义一个整形一维数组，里面放1-5
         *      2）用foreach打印到控制台
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// foreach的简单例程
        /// </summary>
        public static void CP05_27()
        {
            //定义一个整形一维数组
            int[] iArray = { 1, 2, 3, 4, 5 };
            foreach(int i in iArray)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}