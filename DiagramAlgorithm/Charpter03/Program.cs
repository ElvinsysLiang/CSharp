#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter03
 * 项目描述 ：
 * 类 名 称 ：Program.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter03
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-3 17:39
 * 更新时间 ：2021-12-3 17:39
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

namespace Charpter03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  例程编号：DA03_01
             *  摘要：递归，阶乘
             */
            Forms.Line("DA03_01");
            Chap03Recursion.DA03_01();
            Console.ReadKey();
        }
    }
}
