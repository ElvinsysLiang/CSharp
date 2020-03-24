#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty09Hashtable
 * 类 描 述 ：Hashtable的例程
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-23 13:57:35
 * 更新时间 ：2020-03-23 13:57:35
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

namespace CP02Types
{
    public class Ty09Hashtable
    {
        #region CP02_24：Hashtable的例程
        /*
         *  例程编号：CP02_24
         *  摘要：
         *      Hashtable的例程
         *  说明：
         *      1）Hashtable：非泛型，可放入任意类型数据作为键值对
         *      2）创建Hashtable，需在文件头加入：using System.Collections;
         *      3）添加数据  Hashtable.Add(Key,Value);
         *      4）循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
         *          打印顺序不一定按照添加数据的顺序进行打印
         *      5）根据键值删除数据  Hashtable.Remove(Key);
         *      6）查询键值存在    Hahtable.Contains;
         *      7）Hashtable的键值的集合   Hashtable.Keys
         *      8）Hashtable的元素值的集合   Hashtable.Keys
         *      9）Hashtable的大小   Hashtable.Count
         *      10）清空Hashtable的所有元素  Hashtable.Clear()
         *      11）键值类型是Int，而且从0开始按顺序，for循环打印
         *  步骤：
         *      1）
         */
        /// <summary>
        /// Hashtable的例程
        /// </summary>
        public static void CP02_24()
        {
            //创建Hashtable，需在文件头加入：using System.Collections;
            Console.WriteLine("创建Hashtable...");
            Hashtable hashtable = new Hashtable();
            CP00Forms.Forms.Cut();
            //添加数据  Hashtable.Add(Key,Value);
            Console.WriteLine("添加数据...");
            hashtable.Add("0号数据", "Nice");
            hashtable.Add('1', "to");
            hashtable.Add(2, "meet");
            hashtable.Add(true, "you");
            //循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
            //打印顺序不一定按照添加数据的顺序进行打印
            PrintHashtable(hashtable);
            CP00Forms.Forms.Cut();
            //根据键值删除数据  Hashtable.Remove(Key);
            Console.WriteLine("删除键值为2的数据...");
            hashtable.Remove(2);
            PrintHashtable(hashtable);
            //查询键值存在    Hahtable.Contains;
            if (hashtable.Contains(2))
            {
                Console.WriteLine("删除失败...");
            }
            else
            {
                Console.WriteLine("删除成功...");
            }
            CP00Forms.Forms.Cut();
            //Hashtable的键值的集合   Hashtable.Keys
            PrintHashtableKeys(hashtable);
            CP00Forms.Forms.Cut();
            //Hashtable的元素值的集合   Hashtable.Keys
            PrintHashtableValues(hashtable);
            CP00Forms.Forms.Cut();
            //Hashtable的大小   Hashtable.Count
            PrintHashtableCount(hashtable);
            CP00Forms.Forms.Cut();
            //清空Hashtable的所有元素  Hashtable.Clear()
            Console.WriteLine("清空Hashtable的数据...");
            hashtable.Clear();
            PrintHashtable(hashtable);
            CP00Forms.Forms.Cut();
            //键值类型是Int，而且从0开始按顺序，for循环打印
            hashtable.Add(0, "Nice");
            hashtable.Add(1, "to");
            hashtable.Add(2, "meet");
            hashtable.Add(3, "you");
            hashtable.Add(4, "！");
            PrintHashtable_1(hashtable);
            CP00Forms.Forms.Cut();


        }
        public static void PrintHashtable(Hashtable hashtable)
        {
            //可以把Hashtable按照DictionaryEntry键值对的方式，通过foreach打印
            Console.WriteLine("打印Hashtable中的数据...");
            if (hashtable.Count == 0)
            {
                Console.WriteLine("Hashtable中没有任何内容，无法执行打印操作。");
            }
            foreach (DictionaryEntry dictionary in hashtable)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", dictionary.Key, dictionary.Value);
            }
        }
        public static void PrintHashtableKeys(Hashtable hashtable)
        {
            //打印Hashtable的键值
            Console.WriteLine("打印Hashtable中的键值...");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("Key:{0}", key);
            }
        }
        public static void PrintHashtableValues(Hashtable hashtable)
        {
            //打印Hashtable的元素值
            Console.WriteLine("打印Hashtable中的元素...");
            foreach (var value in hashtable.Values)
            {
                Console.WriteLine("Value:{0}", value);
            }
        }
        public static void PrintHashtableCount(Hashtable hashtable)
        {
            //打印Hashtable的大小
            Console.WriteLine("打印Hashtable的大小...");
            Console.WriteLine("大小为：" + hashtable.Count);
        }
        public static void PrintHashtable_1(Hashtable hashtable)
        {
            //循环打印的第二种实现形式，利用Hashtable.Count找键值，通过键值打印元素值
            Console.WriteLine("如果键值为Int，通过第二种打印Hashtable中的数据...");
            if (hashtable.Count == 0)
            {
                Console.WriteLine("Hashtable中没有任何内容，无法执行打印操作。");
            }
            else
            {
                for (int i = 0; i < hashtable.Count; i++)
            {
                    Console.WriteLine("Key:{0}\tValue:{1}", i, hashtable[i]);
                }
            }
        }
        #endregion


    }
}