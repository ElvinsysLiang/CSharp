#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty06String
 * 类 描 述 ：string的用法
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-19 14:07:56
 * 更新时间 ：2020-03-19 14:07:56
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP02Types
{
    public class Ty06String
    {
        #region CP02_19：string的用法
        /*
         *  例程编号：CP02_19
         *  摘要：
         *      string的用法
         *  说明：
         *      1）求长度       String.Length
         *      2）转大写       String.ToUpper()
         *      3）转小写       String.ToLower()
         *      4）比较相等     String.Equals（string，StringComparison）
         *      5）分割         String.Split(string,StringSplitOption)
         *      6）分割练习     用户输入xxxx-xx-xx，打印xxxx年xx月xx日
         *      7）替换         String.Replace(String,String)
         *      8）截取         String.SubString(int,int)
         *      9）匹配字符串结尾     String.EndsWith(String)
         *      10）索引值      String.IndexOf(String,int)
         *      11）索引值      String.LastIndexOf(String)
         *      12)索引值练习   文件绝对路径，提取文件名
         *      13）删除空格     String.Trim()
         *      14）空字符串     string.IsNullOrEmpty(String)
         *      15）连接字符串数组 string.Join('Char',String[])
         *      16）字符串变成字符数组   String.ToCharArray()  字符倒序
         *      17）字符串倒序 nice to meet u -> u meet to nice
         *      18）email提取用户名和域名  abc@163.com -> abc 163.com
         *      19）一个字符在字符串中出现的位置与次数
         *      20）字符串内容识别    String.Contains(String)
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// string的用法
        /// </summary>
        public static void CP02_19()
        {
            //1）求长度       String.Length
            //Length();

            //2）转大写       String.ToUpper()
            //ToUpper();

            //3）转小写       String.ToLower()
            //ToLower();

            //4）比较相等     String.Equals（string，StringComparison）
            //Equals();

            //5）分割         String.Split(string,StringSplitOption)
            //Split();

            //6）分割练习     用户输入xxxx-xx-xx，打印xxxx年xx月xx日
            //SplitPractice_1();

            //7）替换         String.Replace(String,String)
            //Replace();

            //8）截取         String.SubString(int,int)
            //Substring();

            //9）匹配字符串结尾     String.EndsWith(String)
            //EndsWith();

            //10）索引值      String.IndexOf(String,int)
            //IndexOf();

            //11）索引值      String.LastIndexOf(String)
            //LastIndexOf();

            //12)索引值练习   文件绝对路径，提取文件名
            //LastIndexPractice();

            //13）删除空格     String.Trim()
            //Trim();

            //14）空字符串     string.IsNullOrEmpty(String)
            //IsNullOrEmpty();

            //15）连接字符串数组 string.Join('Char',String[])
            //Join();

            //16）字符串变成字符数组   String.ToCharArray()  字符倒序
            //ChTurn();

            //17）字符串倒序 nice to meet u -> u meet to nice
            //StrTurn();

            //18）email提取用户名和域名  abc@163.com -> abc 163.com
            //GetEmailIdDomin();

            //19）一个字符在字符串中出现的位置与次数
            //CountChar();

            //20）字符串内容识别    String.Contains(String)
            //Contains();
        }
        /// <summary>
        /// 字符串内容识别    String.Contains(String)
        /// </summary>
        private static void Contains()
        {
            string str20;
            string str20_1 = "";
            bool bFlag = false;
            Console.WriteLine("输入一些敏感字yellow，测试屏蔽功能。");
            str20 = Console.ReadLine();
            if (str20.Contains("yellow"))
            {
                str20_1 = str20.Replace("yellow", "******");
                bFlag = true;
            }
            if (bFlag)
            {
                Console.WriteLine("屏蔽后的效果：" + str20_1);
            }
            else
            {
                Console.WriteLine("字符串里面没有需要被屏蔽的文字。");
            }
        }

        /// <summary>
        /// 一个字符在字符串中出现的位置与次数
        /// </summary>
        private static void CountChar()
        {
            string str19;
            char ch19;
            int iPos;
            int iInd = 0;
            int iCount = 0;
            Console.Write("请输入一个字符串：");
            str19 = Console.ReadLine();
            Console.Write("需要找到位置和次数的字符：");
            while (true)
            {
                try
                {
                    ch19 = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("输入的不是字符，请重新输入：");
                }
            }
            while (true)
            {
                iPos = str19.IndexOf(ch19, iInd);
                if (iPos == -1)
                {
                    Console.WriteLine("搜索完毕。");
                    break;
                }
                Console.WriteLine("第{0}个位置在：{1}", iCount + 1, iPos);
                iCount++;
                iInd = ++iPos;
                if (iInd == str19.Length)
                {
                    Console.WriteLine("搜索完毕。");
                    break;
                }
            }
            Console.WriteLine("符合条件的字符个数共有：" + iCount);
        }


        /// <summary>
        /// email提取用户名和域名  abc@163.com -> abc 163.com
        /// </summary>
        private static void GetEmailIdDomin()
        {
            string str18;
            string strId;
            string strDomain;
            Console.Write("请输入一个email地址：");
            str18 = Console.ReadLine();
            int iIndex = str18.IndexOf('@');
            strId = str18.Substring(0, iIndex);
            strDomain = str18.Substring(iIndex + 1, str18.Length - iIndex - 1);
            Console.WriteLine("用户名：{0}\n域名：{1}", strId, strDomain);
        }

        /// <summary>
        /// 字符串倒序 nice to meet u -> u meet to nice
        /// </summary>
        private static void StrTurn()
        {
            string str17 = "nice to meet u";
            Console.WriteLine("字符串倒序前：" + str17);
            string str17_1;
            string[] strarr = str17.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0, j = strarr.Length - 1; i < j; i++, j--)
            {
                string strTemp = strarr[i];
                strarr[i] = strarr[j];
                strarr[j] = strTemp;
            }
            str17_1 = string.Join(' ', strarr);
            Console.WriteLine("字符串倒序后：" + str17_1);
        }

        /// <summary>
        /// 字符串变成字符数组   String.ToCharArray()  字符倒序
        /// </summary>
        private static void ChTurn()
        {
            string str16 = "hello";
            Console.WriteLine("字符倒序前：" + str16);
            char[] ch16 = str16.ToCharArray();
            for (int i = 0, j = ch16.Length - 1; i < j; i++, j--)
            {
                char chTemp = ch16[i];
                ch16[i] = ch16[j];
                ch16[j] = chTemp;
            }
            string str16_1 = new string(ch16);
            Console.WriteLine("字符倒序后：" + str16_1);
        }

        /// <summary>
        /// 连接字符串数组 string.Join('Char',String[])
        /// </summary>
        private static void Join()
        {
            string[] sarr15 = { "nice", "to", "meet", "you" };
            string str15 = string.Join('|', sarr15);
            Console.WriteLine("字符串数组里面的元素分别是：");
            foreach (string str in sarr15)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("用‘|’连接后，变成了：\n" + str15);
        }

        /// <summary>
        /// 空字符串     string.IsNullOrEmpty(String)
        /// </summary>
        private static void IsNullOrEmpty()
        {
            string str14 = "Hello";
            string str14_1 = "";
            Console.WriteLine("str14\n字符串内容：{0}\n是否一个空字符串？{1}", str14, string.IsNullOrEmpty(str14));
            Console.WriteLine();
            Console.WriteLine("str14_1\n字符串内容：{0}\n是否一个空字符串？{1}", str14_1, string.IsNullOrEmpty(str14_1));
        }

        /// <summary>
        /// 删除空格     String.Trim()
        /// </summary>
        private static void Trim()
        {
            string str13 = "     hello     ";
            string str13_1 = str13.Trim();
            string str13_2 = str13.TrimStart();
            string str13_3 = str13.TrimEnd();
            Console.WriteLine("删除空格前的字符串：\t" + str13);
            Console.WriteLine("删除空格后：" + str13_1);
            Console.WriteLine("删除前面的空格：" + str13_2);
            Console.WriteLine("删除后面的空格：" + str13_3);
        }

        /// <summary>
        /// 索引值练习   文件绝对路径，提取文件名
        /// </summary>
        private static void LastIndexPractice()
        {
            string str12 = @"c:\a\b\c\d\galgame.exe";
            //提取最后一个“\”的索引值
            int i12 = str12.LastIndexOf('\\');
            //截取文件名
            string str12_1 = str12.Substring(i12 + 1);
            Console.WriteLine("文件的绝对路径是：" + str12);
            Console.WriteLine("截取到的文件名是：" + str12_1);
        }

        /// <summary>
        /// 索引值      String.LastIndexOf(String)
        /// </summary>
        private static void LastIndexOf()
        {
            string str11 = "12345345";
            int i11_1 = str11.LastIndexOf("3");//找索引，从第2位开始找，范围索引
            int i11_2 = str11.LastIndexOf("6");//没找到，返回-1
            Console.WriteLine("字符串为：" + str11);
            Console.WriteLine("从第2位开始找字符串“3”的索引，索引值为{0}，找不到返回-1", i11_1);
            Console.WriteLine("从第2位开始找字符串“45”的索引，索引值为{0}，找不到返回-1", i11_2);
        }

        /// <summary>
        /// 索引值      String.IndexOf(String,int)
        /// </summary>
        private static void IndexOf()
        {
            string str10 = "12345";
            int i10_1 = str10.IndexOf("3", 2);//找索引，从第2位开始找，范围索引
            int i10_2 = str10.IndexOf("45", 2);//找索引，从第2位开始找，范围索引
            int i10_3 = str10.IndexOf("3", 3);//没找到，返回-1
            Console.WriteLine("字符串为：" + str10);
            Console.WriteLine("从第2位开始找字符串“3”的索引，索引值为{0}，找不到返回-1", i10_1);
            Console.WriteLine("从第2位开始找字符串“45”的索引，索引值为{0}，找不到返回-1", i10_2);
            Console.WriteLine("从第3位开始找字符串“3”的索引，索引值为{0}，找不到返回-1", i10_3);
        }

        /// <summary>
        /// 匹配字符串结尾     String.EndsWith(String)
        /// </summary>
        private static void EndsWith()
        {
            string str09 = "Good morning";
            if (str09.EndsWith("ing"))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            if (str09.EndsWith("noon"))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        /// <summary>
        /// 截取         String.SubString(int,int)
        /// </summary>
        private static void Substring()
        {
            string str08 = "12345";
            Console.WriteLine("截取前：" + str08);
            //从第0位开始截取，截取长度为2位（
            str08 = str08.Substring(0, 2);
            Console.WriteLine("截取后：" + str08);
        }

        /// <summary>
        /// 替换         String.Replace(String,String)/String.Replace(Char,Char)
        /// 参数1是旧的字符（串），参数2是新的字符（串）
        /// </summary>
        private static void Replace()
        {
            string str07_1;
            char c07_old, c07_new;
            string str07_old, str07_new;
            Console.Write("输入一个字符串：");
            str07_1 = Console.ReadLine();
            Console.Write("需要替换的字符：");
            while (true)
            {
                try
                {
                    c07_old = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("输入的不是一个字符，请重新输入：");
                }
            }
            Console.Write("替换成的字符：");
            while (true)
            {
                try
                {
                    c07_new = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("输入的不是一个字符，请重新输入：");
                }
            }
            str07_1 = str07_1.Replace(c07_old, c07_new);
            Console.WriteLine("字符替换完成，替换后的字符是：" + str07_1);

            CP00Forms.Forms.Cut();

            Console.Write("需要替换的字符串：");
            str07_old = Console.ReadLine();
            Console.Write("替换成的字符串：");
            str07_new = Console.ReadLine();
            str07_1 = str07_1.Replace(str07_old, str07_new);
            Console.WriteLine("字符串替换完成，替换后的字符串是：" + str07_1);
        }

        /// <summary>
        /// 分割练习     用户输入xxxx-xx-xx，打印xxxx年xx月xx日
        /// </summary>
        private static void SplitPractice_1()
        {
            string str06;
            string[] sarr06;
            Console.WriteLine("请按照xxxx-xx-xx格式输入今天的日期");
            str06 = Console.ReadLine();
            char c06 = '-';
            sarr06 = str06.Split(c06, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("今天的日期是{0}年{1}月{2}日。", sarr06[0], sarr06[1], sarr06[2]);
        }

        /// <summary>
        /// 分割         String.Split(string,StringSplitOption)
        /// </summary>
        private static void Split()
        {
            string str05 = "a b   dfd _   +   =  ,,, fdf  ";
            char[] c05 = { ' ', '_', '+', '=', ',' };
            //String.Split  按照给定的条件分割字符串，并返回一个字符串数组
            //StringSplitOptions    排除返回数组中的空字符串
            string[] str05_2 = str05.Split(c05, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("分割前，字符串是：\n" + str05);
            Console.WriteLine("分割后，得到的字符串数组长度为：" + str05_2.Length);
            for (int i = 0; i < str05_2.Length; i++)
            {
                Console.WriteLine(str05_2[i]);
            }
        }

        /// <summary>
        /// 比较相等     String.Equals（string，StringComparison）
        /// </summary>
        private static void Equals()
        {
            Console.Write("输入第一个字符串：");
            string str04_1 = Console.ReadLine();
            Console.Write("输入第二个字符串：");
            string str04_2 = Console.ReadLine();
            //Equals比较相等，相等返回true
            //参数1是需要比较的字符串
            //OrdinalIgnoreCase，比较方式：按照区域性不考虑大小写
            if (str04_1.Equals(str04_2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("输入的两个字符串相同。");
            }
            else
            {
                Console.WriteLine("两个字符串并不相同。");
            }
        }

        /// <summary>
        /// 转小写       String.ToLower()
        /// </summary>
        private static void ToLower()
        {
            Console.Write("请输入一个字符串：");
            string str03 = Console.ReadLine();
            str03 = str03.ToLower();
            Console.WriteLine("转小写：{0}", str03);
        }

        /// <summary>
        /// 转大写       String.ToUpper()
        /// </summary>
        private static void ToUpper()
        {
            Console.Write("请输入一个字符串：");
            string str02 = Console.ReadLine();
            str02 = str02.ToUpper();
            Console.WriteLine("转大写：{0}", str02);
        }

        /// <summary>
        /// 求长度       String.Length
        /// </summary>
        private static void Length()
        {
            Console.Write("请输入一个字符串：");
            string str01 = Console.ReadLine();
            Console.WriteLine("您输入的字符串长度为：{0}", str01.Length);
            CP00Forms.Forms.Cut();
        }
        #endregion
    }
}