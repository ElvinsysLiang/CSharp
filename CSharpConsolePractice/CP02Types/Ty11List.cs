#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty11List
 * 类 描 述 ：List的例程
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-25 11:37:34
 * 更新时间 ：2020-03-25 11:37:34
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
    public class Ty11List
    {
        #region CP02_26：List的例程
        /*
         *  例程编号：CP02_26
         *  摘要：
         *      List的例程
         *  说明：
         *      1）List和ArrayList的区别
         *          List：泛型集合，数据类型固定的可变数组，数据类型不需要强转
         *          ArrayList：能在同一集合中放不同的数据，对数据的处理一般需要强转
         *          而数据的类型转换，一般伴随着拆箱和装箱的过程，影响程序执行效率
         *      2）创建List List<int> intList = new List<int>();
         *      3）添加数据 List.Add(Int / Char / String / Int[] / Class...);
         *      4）添加数组 List.AddRange(new int[] { Int...});
         *      5）删除指定内容数据 List.Remove(Int);
         *          删除在List中不存在的数据，并不会抛异常
         *      6）删除指定下标数据 List.RemoveAt(Index);
         *      7）删除下标范围数据 List.RemoveRange(startIndex,endIndex);
         *          超出范围，会抛异常
         *      8）清空List List.Clear();
         *          执行List.Clear()后，Count=0，而Capacity不变
         *          List.RemoveAll();的用法？？？
         *      9）升序排列 List.sort();
         *          可对非引用数据类型（数组，类）的List进行升序排序（包括string）
         *      10）顺序逆转 List.Reverse();
         *      11）指定下标插入数据 List.Insert(Index, Int);
         *          插入后，原数据及后面数据的位置往后推一位
         *      12）指定下标插入数组 List.InsertRange(0, new int[] { Int...});
         *          与ArrayList的区别：
         *          因为List是泛型集合，不存在像ArrayList需要考虑添加数组地址还是数组各元素的问题
         *      13）List的大小和容量 List.Count;  List.Capacity;
         *          Count为List中元素的个数，Capacity为List的容量
         *          Capacity随着个数的增加而双倍递增
         *          执行List.Clear()后，Count=0，而Capacity不变
         *      14）判断List中是否包含一个指定内容的元素 List.Contains(Int);
         *  步骤：
         *      1）
         */
        /// <summary>
        /// List的例程
        /// </summary>
        public static void CP02_26()
        {
            //2）创建List List<int> intList = new List<int>();
            Console.WriteLine("创建int泛型集合...");
            List<int> iList = new List<int>();
            CP00Forms.Forms.Cut();

            //3）添加数据 List.Add(Int / Char / String / Int[] / Class...);
            Console.WriteLine("添加Int数据0,1,2到List中...");
            iList.Add(0);
            iList.Add(1);
            iList.Add(2);
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //4）添加数组 List.AddRange(new int[] { Int...});
            Console.WriteLine("添加数组int[]{3,4,5}到List中...");
            iList.AddRange(new int[] { 3, 4, 5 });
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //5）删除指定内容数据 List.Remove(Int);
            //删除在List中不存在的数据，并不会抛异常
            Console.WriteLine("删除内容为2的数据...");
            iList.Remove(2);
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //6）删除指定下标数据 List.RemoveAt(Index);
            Console.WriteLine("删除下标为1的数据...");
            iList.RemoveAt(1);
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //7）删除下标范围数据 List.RemoveRange(startIndex,endIndex);
            //超出范围，会抛异常
            Console.WriteLine("删除下标为1开始的2个数据...");
            iList.RemoveRange(1, 2);
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //8）清空List List.Clear();
            //执行List.Clear()后，Count=0，而Capacity不变
            //List.RemoveAll();的用法？？？
            Console.WriteLine("清空List...");
            iList.Clear();
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //9）升序排列 List.sort();
            //可对非引用数据类型（数组，类）的List进行升序排序（包括string）
            Console.WriteLine("重新对List<int>加入新的数据2，1，0");
            iList.Add(2);
            iList.Add(1);
            iList.Add(0);
            PrintList(iList);
            Console.WriteLine("对List<int>进行升序排列");
            iList.Sort();
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //Console.WriteLine("再对引用类型List进行测试...");
            //Console.WriteLine("创建List<Person>...");
            //List<Person> personList = new List<Person>();
            //Console.WriteLine("对List<Person>添加3个数据数据...");
            //personList.Add(new Person());
            //personList.Add(new Person());
            //personList.Add(new Person());
            //PrintList(personList);
            //Console.WriteLine("对List<Person>进行升序排列");
            //personList.Sort();
            //PrintList(personList);
            //CP00Forms.Forms.Cut();

            Console.WriteLine("再对字符串List进行测试...");
            Console.WriteLine("创建List<string>...");
            List<string> strList = new List<string>();
            Console.WriteLine("对List<string>添加3个数据数据...");
            strList.Add("cc");
            strList.Add("bb");
            strList.Add("aa");
            PrintList(strList);
            Console.WriteLine("对List<string>进行升序排列");
            strList.Sort();
            PrintList(strList);
            CP00Forms.Forms.Cut();

            //10）顺序逆转 List.Reverse();
            Console.WriteLine("对List<int>进行顺序逆转...");
            iList.Reverse();
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //11）指定下标插入数据 List.Insert(Index, Int);
            //插入后，原数据及后面数据的位置往后推一位
            Console.WriteLine("在下标为1的地方插入数据5...");
            iList.Insert(1, 5);
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //12）指定下标插入数组 List.InsertRange(0, new int[] { Int...});
            //与ArrayList的区别：
            //因为List是泛型集合，不存在像ArrayList需要考虑添加数组地址还是数组各元素的问题
            Console.WriteLine("在下标为2的地方插入数组int[]{7,8,9}...");
            iList.InsertRange(2, new int[] { 7, 8, 9 });
            PrintList(iList);
            CP00Forms.Forms.Cut();

            //13）List的大小和容量 List.Count;  List.Capacity;
            //Count为List中元素的个数，Capacity为List的容量
            //Capacity随着个数的增加而双倍递增
            //执行List.Clear()后，Count=0，而Capacity不变
            Console.WriteLine("List<int>的大小为：" + iList.Count);
            Console.WriteLine("List<int>的容量为：" + iList.Capacity);
            CP00Forms.Forms.Cut();

            //14）判断List中是否包含一个指定内容的元素 List.Contains(Int);
            Console.WriteLine("判断List中是否包含一个元素8...");
            if (iList.Contains(8))
            {
                Console.WriteLine("List<int>中存在数据为8的元素。");
            }
            else
            {
                Console.WriteLine("List<int>中不存在数据为8的元素。");
            }
            CP00Forms.Forms.Cut();
        }
        public static void PrintList(List<int> iList)
        {
            if (iList.Count == 0)
            {
                Console.WriteLine("List中没有任何数据，无法打印。");
            }
            else
            {
                Console.WriteLine("开始打印List<int>中的数据...");
                for (int i = 0; i < iList.Count; i++)
                {
                    Console.WriteLine("List<int>[{0}] = {1}", i, iList[i]);
                }
                Console.WriteLine("打印完毕。");
            }
        }
        public static void PrintList(List<Person> personList)
        {
            if (personList.Count == 0)
            {
                Console.WriteLine("List中没有任何数据，无法打印。");
            }
            else
            {
                Console.WriteLine("开始打印List<Person>中的数据...");
                for (int i = 0; i < personList.Count; i++)
                {
                    Console.WriteLine("List<Person>>[{0}] = {1}", i, personList[i]);
                }
                Console.WriteLine("打印完毕。");
            }
        }
        public static void PrintList(List<string> strList)
        {
            if (strList.Count == 0)
            {
                Console.WriteLine("List中没有任何数据，无法打印。");
            }
            else
            {
                Console.WriteLine("开始打印List<string>中的数据...");
                for (int i = 0; i < strList.Count; i++)
                {
                    Console.WriteLine("List<string>>[{0}] = {1}", i, strList[i]);
                }
                Console.WriteLine("打印完毕。");
            }
        }
        public class Person
        {

        }
        #endregion
    }
}