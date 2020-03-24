#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP09PathFileStream
 * 项目描述 ：
 * 类 名 称 ：PFS01Path
 * 类 描 述 ：Path，文件路径的例程
 * 命名空间 ：CP09PathFileStream
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-23 18:25:17
 * 更新时间 ：2020-03-23 18:25:17
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace CP09PathFileStream
{
    public class PFS01Path
    {
        #region CP09_01：Path的例程
        /*
         *  例程编号：CP09_02
         *  摘要：
         *      Path的例程
         *  说明：
         *      1）使用Path类的方法，不需要实例化
         *      2）Path主要是对文件名和路径的处理
         *      3）使用Path，需在文件头加上：using System.IO;
         *  步骤：
         *      1）获取文件名（含扩展名）
         *      2）获取文件名（不含扩展名）
         *      3）获取扩展名
         *      4）获取文件所在文件夹的名称
         *      5）获取文件的绝对路径
         *      6）合并两个字符串作为文件路径
         */
        /// <summary>
        /// Path的例程
        /// </summary>
        public static void CP09_01()
        {
            string strFileName = @"c:\a\b\c\av.mp3";
            //1）获取文件名（含扩展名）
            Console.WriteLine("文件名（含扩展名）：" + Path.GetFileName(strFileName));
            //2）获取文件名（不含扩展名）
            Console.WriteLine("文件名（不含扩展名）：" + Path.GetFileNameWithoutExtension(strFileName));
            //3）获取扩展名
            Console.WriteLine("文件名扩展名：" + Path.GetExtension(strFileName));
            //4）获取文件所在文件夹路径
            Console.WriteLine("文件夹路径：" + Path.GetDirectoryName(strFileName));
            //5）获取文件的绝对路径
            Console.WriteLine("文件绝对路径：" + Path.GetFullPath(strFileName));
            //6）合并两个字符串作为文件路径
            Console.WriteLine("字符串合成方式——文件绝对路径：" + Path.Combine(Path.GetDirectoryName(strFileName), Path.GetFileName(strFileName)));
        }
        #endregion


    }
}