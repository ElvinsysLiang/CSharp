#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP09PathFileStream
 * 项目描述 ：
 * 类 名 称 ：PFS04StreamWriterReader
 * 类 描 述 ：StreamWriter/StreamReader的例程
 * 命名空间 ：CP09PathFileStream
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-26 14:15:27
 * 更新时间 ：2020-03-26 14:15:27
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
    public class PFS04StreamWriterReader
    {
        #region CP09_08：StreamWrite/StreamReader
        /*
         *  例程编号：CP09_08
         *  摘要：
         *      StreamWriter/StreamReader
         *  说明：
         *      1）StreamWriter/StreamReader可用于进行文本的读写
         *      2）使用前须在文件头加入：using System.IO;
         *      2）可用using语句让系统自动回收资源
         *      3）写入文本文件    StreamWriter sw = new StreamWriter(@"d:\sw.txt", true)
         *          1.若文件不存在，则创建，若已存在，则不再创建
         *          2.写入内容不会覆盖文档原有的内容
         *          3.在写入内容时，把文件设置为只读形式
         *      4）读取文本文件    StreamReader sr = new StreamReader(@"d:\sw.txt", true)
         *          1.当行读取  sr.ReadLine()
         *          2.多行读取  sr.ReadToEnd()  /   while(!sr.EndOfStream)sr.ReadToEnd();
         *          3.sr.EndOfStream为只读属性，因此，每次对文本文件的读取最好重新创建StreamReader对象
         *  步骤：
         *      1）
         */
        /// <summary>
        /// StreamWriter/StreamReader
        /// </summary>
        public static void CP09_08()
        {
            //创建并写入文本文件
            using (StreamWriter sw = new StreamWriter(@"d:\sw.txt", true))
            {
                Console.WriteLine("开始写入字符串...");
                sw.Write("用StreamWriter写的字符串。\n");
                Console.WriteLine("写入结束。");
            }
            CP00Forms.Forms.Cut();

            //测试证明，多次调用StreamWriter写入文件并不会覆盖文件原来的内容
            using (StreamWriter sw = new StreamWriter(@"d:\sw.txt", true))
            {
                Console.WriteLine("会不会覆盖呢...");
                sw.Write("第二次添加的字符串。\n");
                Console.WriteLine("写入结束。");
            }
            CP00Forms.Forms.Cut();

            //读取文本文件
            using (StreamReader sr = new StreamReader(@"d:\sw.txt", true))
            {
                Console.WriteLine("开始打印文本文件的内容...");
                Console.WriteLine("只打一行...");
                Console.WriteLine(sr.ReadLine());
                CP00Forms.Forms.Cut();

                Console.WriteLine("多行打印...");
                //因为已经打了第一行，所以从第二行开始打印
                Console.WriteLine(sr.ReadToEnd());
                CP00Forms.Forms.Cut();
                Console.WriteLine("打印完毕。");
            }
            CP00Forms.Forms.Cut();

            //第二种多行打印
            //StreamReader.EndOfStream是一个属性，只读。若指针在文件末尾，则true
            using (StreamReader sr = new StreamReader(@"d:\sw.txt", true))
            {
                Console.WriteLine("第二种多行打印...");
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                Console.WriteLine("打印完毕。");
            }
        }
        #endregion
    }
}