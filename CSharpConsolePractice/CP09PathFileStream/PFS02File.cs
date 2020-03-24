#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP09PathFileStream
 * 项目描述 ：
 * 类 名 称 ：PFS02File
 * 类 描 述 ：File的使用例程
 * 命名空间 ：CP09PathFileStream
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-23 19:10:13
 * 更新时间 ：2020-03-24 10:48:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace CP09PathFileStream
{
    public class PFS02File
    {
        #region CP09_02：File的例程
        /*
         *  例程编号：CP09_02
         *  摘要：
         *      File的例程
         *  说明：
         *      1）创建文件  File.Create(String).Close()
         *          使用File类，需要在文件头加入：using System.IO;
         *          在C盘创建文件失败，可能权限不够高
         *          无法在不存在的子目录创建，会抛异常
         *          必须以File.Create().Close()创建，否则有可能影响之后的操作（重要！！！
         *      2）复制文件  File.Copy(String,String,Bool)
         *          无法复制到不存在的子目录，会抛异常
         *          若文件创建后，没有执行Close()方法，有可能因文件被其他进程打开而导致复制失败
         *      3）剪切文件  File.Move(String,String,Bool)
         *          无法剪切到不存在的子目录，会抛异常
         *          若文件创建后，没有执行Close()方法，有可能因文件被其他进程打开而导致剪切失败
         *      4）删除文件  File.Delete(String)
         *      5）写入数据
         *          使用Encoding类，需要再文件头加入：using System.Text;
         *          把字符串转换成字节数组：byte[] bArrBuff = Encoding.Default.GetBytes(strData);
         *          以字节数组方式写入文件：File.WriteAllBytes(strFileName, bytBuff);
         *      6）读取数据
         *          以字节数组方式读取文件：bytBuff = File.ReadAllBytes(strFileName);
         *          把字节数组转换成字符串：strData = Encoding.Default.GetString(bytBuff);
         *          
         *          
         *  步骤：
         *      1）
         */
        /// <summary>
        /// File的例程
        /// </summary>
        public static void CP09_02()
        {
            //创建文件
            Create(@"d:\test.txt");
            Console.WriteLine("按任意键继续文件操作...");
            Console.ReadKey();
            //复制文件
            Copy(@"d:\test.txt", @"d:\test_1.txt");
            Console.WriteLine("按任意键继续文件操作...");
            Console.ReadKey();
            //剪切文件
            Move(@"d:\test_1.txt", @"d:\test_2.txt");
            Console.WriteLine("按任意键继续文件操作...");
            Console.ReadKey();
            //删除文件
            Delete(@"d:\test_2.txt");
            Console.WriteLine("按任意键继续文件操作...");
            Console.ReadKey();
            //写入数据
            Write("Nice to meet you.", @"d:\test.txt");
            Console.WriteLine("按任意键继续文件操作...");
            Console.ReadKey();
            //读取数据
            Console.WriteLine(Read(@"d:\test.txt"));
        }
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="strFileName">需要读取的文件绝对路径</param>
        /// <returns></returns>
        public static string Read(string strFileName)
        {
            byte[] bytBuff = null;
            //以字节数组方式读取文件，并返回
            try
            {
                Console.WriteLine("以字节数组方式读取文件...");
                bytBuff = File.ReadAllBytes(strFileName);
                Console.WriteLine("读取成功，并返回一个字节数组...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //把字节数组转换为字符串
            Console.WriteLine("把字节数组转换为字符串输出...");
            return Encoding.Default.GetString(bytBuff);
        }
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="strData">需要写入的数据</param>
        /// <param name="strFileName">需要写入的文件绝对路径</param>
        public static void Write(string strData, string strFileName)
        {
            //将字符串转换成字节数组
            //使用Encoding类，需要再文件头加入：using System.Text;
            byte[] bytBuff = Encoding.Default.GetBytes(strData);
            //以字节形式写入到文件当中
            try
            {
                Console.WriteLine("开始往{0}写入数据...", Path.GetFileName(strFileName));
                File.WriteAllBytes(strFileName, bytBuff);
                Console.WriteLine("写入数据成功。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="strFileFullName">需要删除的文件绝对路径</param>
        public static void Delete(string strFileFullName)
        {
            try
            {
                Console.WriteLine("删除在{0}中的文件{1}...", Path.GetDirectoryName(strFileFullName),
                    Path.GetFileName(strFileFullName));
                File.Delete(strFileFullName);
                Console.WriteLine("删除文件成功。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// 剪切文件
        /// </summary>
        /// <param name="strFileFullName">源文件绝对路径</param>
        /// <param name="strFileFullName_1">目标文件绝对路径</param>
        public static void Move(string strFileFullName, string strFileFullName_1)
        {
            try
            {
                Console.WriteLine("在{0}中的文件{1}剪切到同目录下的{2}...", Path.GetDirectoryName(strFileFullName),
                    Path.GetFileName(strFileFullName), Path.GetFileName(strFileFullName_1));
                File.Move(strFileFullName, strFileFullName_1, true);
                Console.WriteLine("剪切文件成功。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="strFileFullName">源文件绝对路径</param>
        /// <param name="strFileFullName_1">目标文件绝对路径</param>
        public static void Copy(string strFileFullName, string strFileFullName_1)
        {
            try
            {
                Console.WriteLine("在{0}中的文件{1}复制到同目录下的{2}...", Path.GetDirectoryName(strFileFullName),
                    Path.GetFileName(strFileFullName), Path.GetFileName(strFileFullName_1));
                File.Copy(strFileFullName, strFileFullName_1);
                Console.WriteLine("复制文件成功。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="strFileFullName">文件绝对路径</param>
        public static void Create(string strFileFullName)
        {
            try
            {
                Console.WriteLine("在{0}中创建文件{1}...", Path.GetDirectoryName(strFileFullName), Path.GetFileName(strFileFullName));
                File.Create(strFileFullName).Close();
                Console.WriteLine("创建文件成功。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        #endregion


    }
}