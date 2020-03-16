#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：
 * 类 名 称 ：Mt04Params
 * 类 描 述 ：params可变参数的用法
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-16 13:01:15
 * 更新时间 ：2020-03-16 13:01:15
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP06Method
{
    public class Mt04Params
    {
        #region CP06_08：psrams参数的例程
        /*
         *  例程编号：CP06_08
         *  摘要：
         *      params参数的例程
         *  说明：
         *      1）params可变参数，其实就是把参数放到数组中进行处理
         *      2）在方法定义的时候，要把params写到方法声明中
         *      3）在使用是无需在实参前加入params
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         *                  int         GetSum          params int[]
         */
        /// <summary>
        /// params参数的例程
        /// </summary>
        public static void CP06_08()
        {
            Console.WriteLine("计算“1，4，7，9的和，sum = " + GetSum(1, 4, 7, 9));
        }

        /// <summary>
        /// 可变参数的例程
        /// </summary>
        /// <param name="iArray">可变参数数组</param>
        /// <returns>数组元素值之和</returns>
        public static int GetSum(params int[] iArray)
        {
            int sum = 0;
            for(int i = 0; i < iArray.Length; i++)
            {
                sum += iArray[i];
            }
            return sum;
        }
        #endregion


    }
}