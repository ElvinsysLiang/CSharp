#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter03
 * 项目描述 ：
 * 类 名 称 ：Chap03Recursion.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter03
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-3 17:44
 * 更新时间 ：2021-12-3 17:44
 * 版 本 号 ：V0.0.0.1
 * ======================================
 * 历史更新记录
 * 版 本 号：V         
 * 修改时间：         
 * 修改人：
 * 修改内容：
 * ======================================
 *******************************************************************
 * Copyright @ NEETJIN 2021-2022. All rights reserved.
 *******************************************************************
 //----------------------------------------------------------------*/
 #endregion << 版 本 注 释 >>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter03
{
    class Chap03Recursion
    {
        /*
         *  例程编号：DA03_01
         *  摘要：递归，阶乘
         *  说明：
         *      1）
         *  步骤：
         *      1）
         */
        public static void DA03_01()
        {
            int var = 5;
            Console.WriteLine($"Factorial of {var} is {Factorial(var)}.");
        }
        /// <summary>
        /// 运用递归求阶乘
        /// </summary>
        /// <param name="n">求阶乘的值</param>
        /// <returns>阶乘的结果</returns>
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
