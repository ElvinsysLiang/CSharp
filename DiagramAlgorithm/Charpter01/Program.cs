#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter01
 * 项目描述 ：二分查找算法（C#实现）
 * 类 名 称 ：Program.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter01
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-3 12:30
 * 更新时间 ：2021-12-3 12:30
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

namespace Charpter01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  例程编号：DA01_01
             *  摘要：二分查找算法,要求查找的序列必须为已排序
             */
            Forms.Line("DA01_01");
            Chap01BinarySearch.DA01_01();

            Console.ReadKey();
        }
    }
}
