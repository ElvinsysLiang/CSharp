#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP09PathFileStream
 * 项目描述 ：
 * 类 名 称 ：PFS03FileStream
 * 类 描 述 ：FileStream的例程
 * 命名空间 ：CP09PathFileStream
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-26 14:11:46
 * 更新时间 ：2020-03-26 14:11:46
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
    public class PFS03FileStream
    {
        #region CP09_06：FileStream的例程
        /*
         *  例程编号：CP09_06
         *  摘要：
         *      FileStream的例程
         *  说明：
         *      1）使用FileStream，需要在文件头加入：using System.IO;
         *      2）最好先定义作为缓存，用于读写的字节数组
         *      3）写入数据
         *          FileStream fsWrite = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Write);
         *          把字符串转换成字节数组 byte[] bytArr = Encoding.Default.GetBytes(strFs);
         *          进行写入操作  fsWrite.Write(bytArr, 0, bytArr.Length);
         *          关闭FileStream   fsWrite.Close();
         *          释放FileStream所占用的系统资源 fsWrite.Dispose();
         *          所谓的系统资源，是指在使用异步读写的情况下，对系统其他资源发出请求而占用的资源，如管道，句柄使用等
         *      2）读取数据
         *          FileStream fsRead = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Read)
         *          运用using语句，可以自动释放文件流占用的资源
         *          读取文件的数据，放入字节数组中，并计算读取字节数    int iCount = fsRead.Read(bytBuff, 0, bytBuff.Length);
         *          按照字节数，把以读取的字节数据转换成字符串   string strRead = Encoding.Default.GetString(bytBuff, 0, iCount);
         *          重点：转换的个数是以读取的字节数计算
         *                当一个文件大于字节数组是，可以用while循环进行读取
         *      3）using语句的用法：
         *          引入命名空间
         *          对命名空间改名，使得多个功能类似的命名空间名称上更清晰
         *          定义一个范围，使得范围内代码结束时，通知系统自动回收资源
         *      4）using(){}/FileStream.Close()/FileStream.Dispose()三者区别
         *          1.using(){}除了能用与FileStream以外，还能用于其他对象，但该对象必须继承IDisposable接口
         *          因为FileStream.Dispose()继承了IDisposable接口，因此，无需要在显示进行FileStream.Close()进行资源释放
         *          2.FileStream.Close()是暂时关闭了FileStream，一定时间没有操作，系统做资源回收，短时间内允许重新打开FileStream对象进行操作
         *          3.FileStream.Dispose()是彻底释放FileStream对象占用的资源
         *  步骤：
         *      1）
         */
        /// <summary>
        /// FileStream的例程
        /// </summary>
        public static void CP09_06()
        {
            //使用FileStream，需要在文件头加入：using System.IO;
            //最好先定义作为缓存，用于读写的字节数组
            //定义一个容量为5Mb的字节数组
            byte[] bytBuff = new byte[5 * 1024 * 1024];
            //写入数据
            Console.WriteLine("开始对文件进行写操作...");
            //运用using语句，可以自动释放文件流占用的资源
            FileStream fsWrite = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine("输入写入的字符串...");
            string strFs = Console.ReadLine();
            //把字符串转换成字节数组
            byte[] bytArr = Encoding.Default.GetBytes(strFs);
            //进行写入操作
            fsWrite.Write(bytArr, 0, bytArr.Length);
            //关闭文件流
            fsWrite.Close();
            //释放文件流占用的资源
            fsWrite.Dispose();

            //读取数据
            Console.WriteLine("开始对文件进行读操作...");
            using (FileStream fsRead = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                //读取文件的数据，放入字节数组中，并计算读取字节数
                int iCount = fsRead.Read(bytBuff, 0, bytBuff.Length);
                //按照字节数，把以读取的字节数据转换成字符串
                //重点：转换的个数是以读取的字节数计算
                //      当一个文件大于字节数组是，可以用while循环进行读取
                string strRead = Encoding.Default.GetString(bytBuff, 0, iCount);
                //打印字符串到控制台
                Console.WriteLine("文件读取完毕，正在打印到控制台...");
                Console.WriteLine(strRead);
                Console.WriteLine("打印完毕。");
            }
        }
        #endregion

        #region CP09_07：FileStream复制多媒体文件
        /*
         *  例程编号：CP09_07
         *  摘要：
         *      FileStream复制多媒体文件
         *  说明：
         *      1）用户输入源文件路径和目标文件路径
         *      2）判断源文件是否存在
         *      3）若存在，进行文件复制操作
         *  步骤：
         *      1）
         */
        /// <summary>
        /// FileStream复制多媒体文件
        /// </summary>
        public static void CP09_07()
        {
            string strSource, strTarget;
            Console.Write("请输入需要复制的源文件路径：");
            strSource = Console.ReadLine();
            Console.WriteLine("检测文件书否存在...");
            if (File.Exists(strSource))
            {
                Console.Write("源文件存在...\n请输入目标文件路径：");
                strTarget = Console.ReadLine();
                Console.WriteLine("开始执行复制操作...");
                Copy(strSource, strTarget);
            }
            else
            {
                Console.WriteLine("源文件不存在，无法复制，程序结束。");
            }
        }
        /// <summary>
        /// 文件复制
        /// </summary>
        /// <param name="strSource">源文件路径</param>
        /// <param name="strTarget">目标文件路径</param>
        public static void Copy(string strSource,string strTarget)
        {
            //创建文件流读取源文件
            using(FileStream fsRead=new FileStream(strSource, FileMode.Open, FileAccess.Read))
            {
                //创建文件流写入目标文件
                using(FileStream fsWrite = new FileStream(strTarget, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //创建一个5Mb的字节数组管道用于读取文件
                    byte[] bytBuff = new byte[5 * 1024 * 1024];
                    while (true)
                    {
                        int iCount = fsRead.Read(bytBuff, 0, bytBuff.Length);
                        if (iCount == 0)
                        {
                            break;
                        }
                        fsWrite.Write(bytBuff, 0, iCount);
                    }
                }
            }
            Console.WriteLine("复制完毕。");
        }
        #endregion


    }
}