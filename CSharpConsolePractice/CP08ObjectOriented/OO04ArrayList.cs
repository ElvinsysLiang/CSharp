#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP08ObjectOriented
 * 项目描述 ：
 * 类 名 称 ：OO04ArrayList
 * 类 描 述 ：集合的用法
 * 命名空间 ：CP08ObjectOriented
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-21 19:24:58
 * 更新时间 ：2020-03-21 19:24:58
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace CP08ObjectOriented
{
    public class OO04ArrayList
    {
        #region CP08_10：集合的例程
        /*
         *  例程编号：CP08_10
         *  摘要：
         *      集合的例程
         *  说明：
         *      1）数组和集合的区别
         *          数组：只能放单一类型数据，长度固定
         *          集合：能放多种类型数据，长度可变
         *      2）创建集合  ArrayList arrList = new ArrayList();
         *      3）需要加入  using System.Collections;
         *      4）添加数据  ArrayList.Add(Int/Char/String/Int[]/Class...);
         *      5）删除指定内容数据  ArrayList.Remove(String);
         *      6）删除指定下标数据  ArrayList.RemoveAt(0);
         *      7）删除下标范围数据  ArrayList.RemoveRange(0,3);
         *      8）清空集合  ArrayList.Clear();
         *      9）升序排列  ArrayList.sort();
         *            无法对含有引用类型数据（包括Array和Classes）的集合进行排序
         *            无法对含有不同类型数据的集合进行排序
         *      10）顺序逆转  ArrayList.Reverse();
         *      11）指定下标插入数据 ArrayList.Inser(0,String);
         *            插入后，原数据及后面数据的位置往后推一位
         *      12）指定下标插入数组 ArrayList.InserRange(0, new int[] { Int...});
         *            ArrayList.Insert(2, iArr)ArrayList.InsertRange(3, iArr_1)的区别：
         *            Insert()是把数组地址插入到指定下标位置
         *            InsetRange()是把数组中的元素内容都按顺序插入到指定下标位置
         *      13）指定下标插入集合 ArrayList.InserRange(0, new new ArrayList[]);
         *            Insert()是把集合的地址插入到指定的下标位置
         *            InsetRange()是把集合中的元素内容都按顺序插入到指定下标位置
         *      14）判断指定下标是否包含一个元素   ArrayList.Contains(String);
         *      15）如果数据是引用类型，如数组名或对象名，可以用is判断后，再处理
         *  步骤：
         *      1）创建一个集合，插入各种数据
         *      2）int/double/decimal/string/char/bool/iArray/Person
         */
        /// <summary>
        /// 集合的例程
        /// </summary>
        public static void CP08_10()
        {
            //创建集合
            ArrayList arrList = new ArrayList();
            ArrayList arrList_1 = new ArrayList();
            //定义各种数据
            int iVar = 1;
            double dVar = 3.14;
            decimal dmlVar = 80000m;
            string strVar = "Hello";
            char chVar = 'r';
            bool bFlag = true;
            int[] iArr = { 1, 2, 3 };
            int[] iArr_1 = { 4, 5, 6 };
            int[] iArr_2 = { 7, 8, 9 };
            Person_10 clsP = new Person_10();
            //添加数据  ArrayList.Add()
            arrList.Add(iVar);
            arrList.Add(dVar);
            arrList.Add(dmlVar);
            arrList.Add(strVar);
            arrList.Add(chVar);
            arrList.Add(bFlag);
            arrList.Add(iArr);
            arrList.Add(clsP);
            //循环打印集合的值
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //删除指定内容数据  ArrayList.Remove(String);
            Console.WriteLine("删除3.14...");
            arrList.Remove(3.14);
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //删除指定下标数据 ArrayList.RemoveAt(0);
            Console.WriteLine("删除下标为1的元素...");
            arrList.RemoveAt(1);
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //删除下标范围数据 ArrayList.RemoveRange(0, 3);
            Console.WriteLine("删除范围为1-2的数据...");
            arrList.RemoveRange(1, 2);
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //清空集合  ArrayList.Clear();
            Console.WriteLine("清空集合的数据的数据...");
            arrList.Clear();
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //升序排列 ArrayList.sort();
            //如果集合中的数据不兼容，无法做升序排列
            //先在集合中添加Int数据：4，2，7，1，6
            //再进行升序排列
            Console.WriteLine("重新对集合添加新元素...");
            arrList.Add(4);
            arrList.Add(2);
            arrList.Add(7);
            arrList.Add(1);
            arrList.Add(6);
            PrintArrList(arrList);
            Console.WriteLine("开始执行升序排序...");
            arrList.Sort();
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //再清空，添加String数据
            arrList.Clear();
            Console.WriteLine("清空数据，并添加String数据...");
            arrList.Add("Nice");
            arrList.Add("to");
            arrList.Add("meet");
            arrList.Add("you");
            arrList.Add("baby");
            PrintArrList(arrList);
            Console.WriteLine("开始执行升序排序...");
            arrList.Sort();
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //再清空，添加Person数据
            //arrList.Clear();
            //Console.WriteLine("清空数据，并添加Person数据...");
            //arrList.Add(new Person_10());
            //arrList.Add(new Person_10_1());
            //arrList.Add(new Person_10_2());
            //PrintArrList(arrList);
            //Console.WriteLine("开始执行升序排序...");
            //arrList.Sort();
            //PrintArrList(arrList);
            //无法对Person数据进行升序排序

            //再清空，添加Array数据
            //arrList.Clear();
            //Console.WriteLine("清空数据，并添加Array数据...");
            //arrList.Add(iArr);
            //arrList.Add(iArr_1);
            //arrList.Add(iArr_2);
            //PrintArrList(arrList);
            //Console.WriteLine("开始执行升序排序...");
            //arrList.Sort();
            //PrintArrList(arrList);
            //无法对Array数据进行升序排序

            //再清空，添加各类型数据数据（除了引用类型数据）
            //arrList.Clear();
            //Console.WriteLine("清空数据，并添加各类型数据（除了引用类型数据）...");
            //arrList.Add(iVar);
            //arrList.Add(chVar);
            //arrList.Add(dmlVar);
            //PrintArrList(arrList);
            //Console.WriteLine("开始执行升序排序...");
            //arrList.Sort();
            //PrintArrList(arrList);
            //无法对不同类型的数据进行升序排序

            //顺序逆转 ArrayList.Reverse();
            Console.WriteLine("开始执行顺序逆转...");
            arrList.Reverse();
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //指定下标插入数据 ArrayList.Inser(0, String);
            //插入后，原数据及后面数据的位置往后推一位
            Console.WriteLine("在下标2插入一个字符串“good”...");
            arrList.Insert(2, "good");
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //指定下标插入数组 ArrayList.InserRange(0, new int[] { Int...});
            //ArrayList.Insert(2, iArr)ArrayList.InsertRange(3, iArr_1)的区别：
            //Insert()是把数组地址插入到指定下标位置
            //InsetRange()是把数组里面的元素内容都按顺序插入到指定下标位置
            Console.WriteLine("在下标2处，用ArrayList.Insert()插入一个数组...");
            arrList.Insert(3, iArr);
            PrintArrList(arrList);
            Console.WriteLine("在下标3处，用ArrayList.InsertRange()插入一个数组...");
            arrList.InsertRange(4, iArr_1);
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //指定下标插入集合 ArrayList.InserRange(0, new ArrayList[]);
            Console.WriteLine("给新的集合添加数据...");
            arrList_1.Add("x");
            arrList_1.Add("xx");
            arrList_1.Add("xxx");
            arrList_1.Add("xxxx");
            arrList_1.Add("xxxxx");
            Console.WriteLine("在下标1处，用ArrayList.Insert()插入一个集合...");
            arrList.Insert(1, arrList_1);
            PrintArrList(arrList);
            Console.WriteLine("在下标2处，用ArrayList.InsertRange()插入一个集合...");
            arrList.InsertRange(2, arrList_1);
            PrintArrList(arrList);

            CP00Forms.Forms.Cut();

            //判断指定下标是否包含一个元素 ArrayList.Contains(String);
            Console.WriteLine("判断集合中是否包含“good”的字符串...");
            if (arrList.Contains("good"))
            {
                Console.WriteLine("字符串“good”存在于集合中。");
            }
            else
            {
                Console.WriteLine("集合中未能找到“good”字符串，在末尾加入good字符串。");
            }
            PrintArrList(arrList);
        }

        private static void PrintArrList(ArrayList arrList)
        {
            //循环打印集合的值
            Console.WriteLine("开始打印集合里的元素内容...");
            for (int i = 0; i < arrList.Count; i++)
            {
                if (arrList[i] is int[])
                {
                    Console.WriteLine("arrList[" + i + "] 数组对象的地址是：" + arrList[i]);
                    for (int j = 0; j < ((int[])arrList[i]).Length; j++)
                    {
                        Console.WriteLine("\t" + ((int[])arrList[i])[j]);
                    }
                    continue;//这里不能用break，要用continue。
                }else if (arrList[i] is Person_10)
                {
                    Console.WriteLine("arrList[" + i + "] 类对象的地址是：" + arrList[i]);
                    ((Person_10)arrList[i]).SayHi();
                    continue;
                }else if(arrList[i] is ArrayList)
                {
                    Console.WriteLine("arrList[" + i + "]是一个集合。开始打印该集合的元素...");
                    PrintArrList((ArrayList)arrList[i]);
                }
                Console.WriteLine("arrList[" + i + "] = " + arrList[i]);
            }
        }

        public class Person_10
        {
            public void SayHi()
            {
                Console.WriteLine("Hi, I am Person_10");
            }
        }
        public class Person_10_1
        {
            public void SayHi()
            {
                Console.WriteLine("Hi, I am Person_10_1");
            }
        }
        public class Person_10_2
        {
            public void SayHi()
            {
                Console.WriteLine("Hi, I am Person_10_2");
            }
        }
        #endregion


    }
}