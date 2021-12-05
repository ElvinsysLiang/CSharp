#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：DA00Forms
* 项目描述 ：
* 类 名 称 ：Forms.cs
* 类 描 述 ：
* 命名空间 ：DA00Forms
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-3 12:46
* 更新时间 ：2021-12-3 12:46
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

/*
 *  例程编号：DA01_01
 *  摘要：简单的HelloWorld程序
 *  说明：
 *      1）
 *  步骤：
 *      1）
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA00Forms
{
    public class Forms
    {
        /// <summary>
        /// 例程分割线
        /// </summary>
        /// <param name="str">例程编号</param>
        public static void Line(string str)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*-------------------------开始测试  " + str + "-------------------------*");
            Console.WriteLine("**************************************************************************");
        }

        public static void End()
        {
            Console.WriteLine("*------------------------------------------------------------------------*");
            Console.WriteLine();
        }
        /// <summary>
        /// 例程分割线
        /// </summary>
        /// <param name="str">例程编号</param>
        public static void Cut()
        {
            Console.WriteLine("*********************************************************************");
        }
    }
}
