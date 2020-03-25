#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty12Dictionary
 * 类 描 述 ：Dictionary的例程
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-25 15:14:34
 * 更新时间 ：2020-03-25 15:14:34
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
    public class Ty12Dictionary
    {
        #region CP02_27：Dictionary的例程
        /*
         *  例程编号：CP02_27
         *  摘要：
         *      Dictionary的例程
         *  说明：
         *      1）与Hashtable的区别：
         *          Dictionary：泛型键值对，键和值的数据类型都分别固定
         *          Hashtable：非泛型键值对，键和值任意数据类型
         *      2）新建Dictionary    Dictionary<int,string> = new Dictionary<int, string>();
         *          因为继承自Object，因此不需要额外加文件头
         *      3）添加数据 Dictionary.Add(Key, Value);
         *      4）循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
         *          因为键值的类型固定，因此打印的顺序与添加数据顺序一样
         *      5）根据键值删除数据 Dictionary.Remove(Key);
         *      6）查询键值存在 Dictionary.ContainsKey(Key);
         *      7）Dictionary的键值的集合 Dictionary.Keys
         *      8）Dictionary的元素值的集合 Dictionary.Values
         *      9）Dictionary的大小 Dictionary.Count
         *      10）清空Dictionary的所有元素 Dictionary.Clear()
         *      11）键值类型是Int，而且从0开始按顺序，for循环打印
         *          如果是for循环，必须根据Key的升序或降序打印，对Key有严格要求
         *  步骤：
         *      1）
         */
        /// <summary>
        /// Dictionary的例程
        /// </summary>
        public static void CP02_27()
        {
            //2）新建Dictionary    Dictionary<int,string> = new Dictionary<int, string>();
            //因为继承自Object，因此不需要额外加文件头
            Console.WriteLine("新建Dictionary<int,string>...");
            Dictionary<int, string> istrDict = new Dictionary<int, string>();
            CP00Forms.Forms.Cut();

            //3）添加数据 Dictionary.Add(Key, Value);
            Console.WriteLine("添加三对键值对到Dictionary<int,string>中...");
            istrDict.Add(0, "Apple");
            istrDict.Add(1, "Orange");
            istrDict.Add(2, "Banana");
            istrDict.Add('c', "Cake");//Char自动转变为Int数据
            //istrDict.Add(3.14, "dd");//错误，Key不能是Double
            //istrDict.Add(4, 'e');//错误，Value只能是String
            CP00Forms.Forms.Cut();

            //4）循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
            //因为键值的类型固定，因此打印的顺序与添加数据顺序一样
            PrintDictionary(istrDict);
            CP00Forms.Forms.Cut();

            //5）根据键值删除数据 Dictionary.Remove(Key);
            Console.WriteLine("删除Key=1的数据...");
            istrDict.Remove(1);
            PrintDictionary(istrDict);
            CP00Forms.Forms.Cut();

            //6）查询键值存在 Dictionary.ContainsKey(Key);
            Console.WriteLine("查询键值=2的数据是否存在...");
            if (istrDict.ContainsKey(2))
            {
                Console.WriteLine("Dictionary中存在Key=2的数据，Value={0}", istrDict[2]);
            }
            else
            {
                Console.WriteLine("Dictionary中不存在Key为2的数据。");
            }
            CP00Forms.Forms.Cut();

            //7）Dictionary的键值的集合 Dictionary.Keys
            Console.WriteLine("打印Dictionary中所有Key...");
            foreach(var key in istrDict.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("打印完毕。");
            CP00Forms.Forms.Cut();

            //8）Dictionary的元素值的集合 Dictionary.Values
            Console.WriteLine("打印Dictionary中所有Value...");
            foreach (var value in istrDict.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("打印完毕。");
            CP00Forms.Forms.Cut();

            //9）Dictionary的大小 Dictionary.Count
            Console.WriteLine("查询Dictionary的大小...");
            Console.WriteLine("大小为：" + istrDict.Count); 
            CP00Forms.Forms.Cut();

            //10）清空Dictionary的所有元素 Dictionary.Clear()
            Console.WriteLine("清空Dictionary中的所有数据...");
            istrDict.Clear();
            Console.WriteLine("清空完毕。");
            CP00Forms.Forms.Cut();

            //11）键值类型是Int，而且从0开始按顺序，for循环打印
            //如果是for循环，必须根据Key的升序或降序打印，对Key有严格要求
            Console.WriteLine("重新添加3个数据到Dictionary中");
            istrDict.Add(1, "Apple");
            istrDict.Add(2, "Orange");
            istrDict.Add(3, "Banana");
            Console.WriteLine("添加完成，通过for循环输出...");
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Key：{0}————Value：{1}", i, istrDict[i]);
            }
            Console.WriteLine("打印完毕。");
        }
        public static void PrintDictionary(Dictionary<int,string> istrDict)
        {
            if (istrDict.Count == 0)
            {
                Console.WriteLine("Dictionary中没有任何元素，无法进行打印操作。");
            }
            else
            {
                Console.WriteLine("开始打印Dictionary<int,string>...");
                foreach (var dict in istrDict)
                {
                    Console.WriteLine("Key：{0}————Value：{1}", dict.Key, dict.Value);
                }
                Console.WriteLine("打印完毕。");
            }
        }
        #endregion
    }
}