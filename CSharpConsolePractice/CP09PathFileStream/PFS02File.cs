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

        #region CP09_03：File练习
        /*
         *  例程编号：CP09_03
         *  摘要：
         *      File练习
         *  说明：
         *      1）随便写着玩
         *      2）如果绝对路径不是一个完整的路径，将会在程序所在文件夹创建文件。
         *  步骤：
         *      1）
         */
        public static void CP09_03()
        {
            int iOption;
            while (true)
            {
                ShowMenu();
                try
                {
                    iOption = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("输入错误...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (iOption < 1 || iOption > 7)
                {
                    Console.Write("输入错误...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    switch (iOption)
                    {
                        case 1:
                            Console.Clear();
                            Create_03();
                            Clean();
                            break;
                        case 2:
                            Console.Clear();
                            Delete_03();
                            Clean();
                            break;
                        case 3:
                            Console.Clear();
                            Copy_03();
                            Clean();
                            break;
                        case 4:
                            Console.Clear();
                            Move_03();
                            Clean();
                            break;
                        case 5:
                            Console.Clear();
                            Write_03();
                            Clean();
                            break;
                        case 6:
                            Console.Clear();
                            Read_03();
                            Clean();
                            break;
                        case 7:
                            Console.Clear();
                            Finish_03();
                            Clean();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 结束程序
        /// </summary>
        private static void Finish_03()
        {
            Console.WriteLine("按任意键退出程序...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        private static void Read_03()
        {
            Console.Write("请输入需要读取数据的文件绝对路径：");
            string strFileName = Console.ReadLine();
            string strData = Read_03(strFileName);
            Console.WriteLine("开始显示该文件的数据...");
            Console.WriteLine(strData);
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="strFileName">源文件绝对路径</param>
        /// <param name="strData">要写入的数据</param>
        private static string Read_03(string strFileName)
        {
            string strData = null;
            Console.WriteLine("检查要读取数据的文件是否存在...");
            if (File.Exists(strFileName))
            {
                Console.WriteLine("文件已存在，执行数据读取...");
                //读取数据
                //先把数据读出为字节数组
                byte[] bytBuff = File.ReadAllBytes(strFileName);
                //再把字节数组转换成字符串
                strData = Encoding.Default.GetString(bytBuff);
                Console.WriteLine("读取成功。");
            }
            else
            {
                Console.WriteLine("输入有误，或文件不存在。");
            }
            return strData;
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        private static void Write_03()
        {
            Console.Write("请输入需要写入数据的文件绝对路径：");
            string strFileName = Console.ReadLine();
            Console.WriteLine("输入写入的数据...");
            string strData = Console.ReadLine();
            Write_03(strFileName, strData);
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="strFileName">源文件绝对路径</param>
        /// <param name="strData">要写入的数据</param>
        private static void Write_03(string strFileName, string strData)
        {
            Console.WriteLine("检查要写入数据的文件是否存在...");
            if (File.Exists(strFileName))
            {
                Console.WriteLine("文件已存在，执行数据写入...");
                //写入数据
                //先把字符串转换成字节数组
                byte[] bytBuff = Encoding.Default.GetBytes(strData);
                //再把字节数组写入文件
                File.WriteAllBytes(strFileName, bytBuff);
                Console.WriteLine("写入成功。");
            }
            else
            {
                Console.WriteLine("输入有误，或文件不存在。");
            }
        }

        /// <summary>
        /// 剪切文件
        /// </summary>
        private static void Move_03()
        {
            //剪切文件
            string strOldFileName, strNewFileName;
            Console.Write("请输入需要剪切的文件绝对路径：");
            strOldFileName = Console.ReadLine();
            Console.Write("请输入目文件绝对路径：");
            strNewFileName = Console.ReadLine();
            Move_03(strOldFileName, strNewFileName);
        }

        /// <summary>
        /// 剪切文件
        /// </summary>
        /// <param name="strOldFileName">源文件绝对路径</param>
        /// <param name="strNewFileName">目标文件绝对路径</param>
        private static void Move_03(string strOldFileName, string strNewFileName)
        {
            Console.WriteLine("检查要剪切的文件是否存在...");
            if (File.Exists(strOldFileName))
            {
                Console.WriteLine("文件已存在，执行剪切...");
                File.Move(strOldFileName, strNewFileName);
                Console.WriteLine("剪切成功。");
            }
            else
            {
                Console.WriteLine("输入有误，或文件不存在。");
            }
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        private static void Copy_03()
        {
            //复制文件
            string strOldFileName, strNewFileName;
            Console.Write("请输入需要复制的文件绝对路径：");
            strOldFileName = Console.ReadLine();
            Console.Write("请输入目标文件绝对路径：");
            strNewFileName = Console.ReadLine();
            Copy_03(strOldFileName, strNewFileName);
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="strOldFileName">源文件绝对路径</param>
        /// <param name="strNewFileName">目标文件绝对路径</param>
        private static void Copy_03(string strOldFileName, string strNewFileName)
        {
            Console.WriteLine("检查要复制的文件是否存在...");
            if (File.Exists(strOldFileName))
            {
                Console.WriteLine("文件已存在，执行复制...");
                File.Copy(strOldFileName, strNewFileName);
                Console.WriteLine("复制成功。");
            }
            else
            {
                Console.WriteLine("输入有误，或文件不存在。");
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        private static void Delete_03()
        {
            //删除文件
            Console.Write("请输入需要删除的文件绝对路径：");
            Delete_03(Console.ReadLine());

        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="strFileName">被删除文件的绝对路径</param>
        private static void Delete_03(string strFileName)
        {
            Console.WriteLine("检查要删除的文件是否存在...");
            if (File.Exists(strFileName))
            {
                Console.WriteLine("文件存在，执行删除...");
                File.Delete(strFileName);
                Console.WriteLine("删除成功。");
            }
            else
            {
                Console.WriteLine("输入有误，或文件不存在。");
            }
        }

        /// <summary>
        /// 新建文件
        /// </summary>
        private static void Create_03()
        {
            //新建文件
            bool bCreat = true;
            Console.Write("请输入需要创建文件的绝对路径：");
            while (bCreat)
            {
                string strFileName = Console.ReadLine();
                bCreat = Create_03(strFileName);
            }
        }

        /// <summary>
        /// 新建文件
        /// </summary>
        /// <param name="strFileName">文件的绝对路径或在程序的文件夹新建文件</param>
        /// <returns>是否新建成功，成功返回false，不成功返回true</returns>
        private static bool Create_03(string strFileName)
        {
            bool bCreat = true;
            int iChoose = 0;
            Console.WriteLine("检查所创建的文件是否存在...");
            if (File.Exists(strFileName))
            {
                Console.WriteLine("需要创建的文件已存在，请选择是否覆盖，覆盖选择1，不覆盖选择2");
                while (true)
                {
                    try
                    {
                        iChoose = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        //
                        Console.Write("输入的不是一个整形数字，请重新输入：");
                        continue;
                    }
                    if (iChoose == 1 || iChoose == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("输入错误，请输入1或2：");
                    }
                }
                switch (iChoose)
                {
                    case 1:
                        Console.WriteLine("选择了覆盖文件，开始重新创建文件...");
                        try
                        {
                            File.Create(strFileName).Close();
                            Console.WriteLine("创建文件成功。");
                            bCreat = false;
                        }
                        catch
                        {
                            Console.Write("创建文件失败，请重新输入需要创建的文件的绝对路径...");
                        }
                        break;
                    case 2:
                        Console.WriteLine("选择了不覆盖文件，跳出创建流程...");
                        bCreat = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("需要创建的文件不存在，开始创建文件...");
                try
                {
                    File.Create(strFileName).Close();
                    Console.WriteLine("创建文件成功。");
                    bCreat = false;
                }
                catch
                {
                    Console.Write("创建文件失败，请重新输入需要创建的文件的绝对路径...");
                }
            }
            return bCreat;
        }

        /// <summary>
        /// 显示功能目录
        /// </summary>
        private static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***2020-03-24 文件处理程序 ***");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****请选择执行以下功能：*****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.新建文件");
            Console.WriteLine("2.删除文件");
            Console.WriteLine("3.复制文件");
            Console.WriteLine("4.剪切文件");
            Console.WriteLine("5.写入文件");
            Console.WriteLine("6.读取文件");
            Console.WriteLine("7.退出程序");
            Console.WriteLine("请选择1-7：");
        }

        /// <summary>
        /// 清屏
        /// </summary>
        private static void Clean()
        {
            Console.WriteLine("按任意键返回主目录...");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion


    }
}