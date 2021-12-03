#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter04
 * 项目描述 ：
 * 类 名 称 ：Program.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter04
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-3 18:07
 * 更新时间 ：2021-12-3 18:07
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
using DA00Forms;

namespace Charpter04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  例程编号：DA04_01
             *  摘要：分而治之思想，快速排序
             */
            Forms.Line("DA04_01");
            Chap04QuickSort.DA04_01();
            Console.ReadKey();
        }
    }
}
