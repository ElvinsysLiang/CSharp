#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP01PlatformIntroduce
 * 项目描述 ：
 * 类 名 称 ：PI06TryCatch
 * 类 描 述 ：异常捕获的用法
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-10 16:06:41
 * 更新时间 ：2020-03-10 16:06:41
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
    public class PI06TryCatch
    {
        #region CP01_05：简单的异常捕获程序
        /*
         *  例程编号：CP01_05
         *  摘要：
         *      简单的异常捕获程序
         *  说明：
         *      1）在需要输入一个整形数据的时候，输入了其他的内容，例如字符串
         *      2）在用户输入错误数据的时候，系统会抛出异常，导致程序无法继续进行下去
         *      3）在代码编写的时候，需要对异常进行捕获，以使得程序能够继续运行下去
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iNumber
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
         /// <summary>
         /// 简单的异常捕获程序
         /// </summary>
         public static void CP01_05()
        {
            int iNumber;
            bool bFlag = false;
            Console.Write("请输入一个整形数据，如果不是整形数据，看看会不会抛异常：");
            try
            {
                iNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                iNumber = 100;
                bFlag = true;
            }
            if (bFlag == false)
            {
                Console.WriteLine("您输入了一个整形数据，数据值为：" + iNumber);
            }
            else
            {
                Console.WriteLine("您输入的数据不是一个整形数据，因此，系统默认给iNumber赋值为:" + iNumber);
            }
        }
        #endregion
    }
}