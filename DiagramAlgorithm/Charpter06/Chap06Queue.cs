#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter06
* 项目描述 ：
* 类 名 称 ：Chap06Queue.cs
* 类 描 述 ：
* 命名空间 ：Charpter06
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-15 11:36
* 更新时间 ：2021-12-15 11:36
* 版 本 号 ：V0.0.0.1
* ======================================
* 历史更新记录
* 版 本 号：V         
* 修改时间：         
* 修改人：
* 修改内容：
* ======================================
*******************************************************************
* Copyright @ NEETJIN 2021-2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion << 版 本 注 释 >>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DA00Forms;

namespace Charpter06
{
    class Chap06Queue
    {
        /*
         *  例程编号：DA06_01
         *  摘要：非泛型队列的操作
         *  说明：
         *      1）Queue q1 = new Queue();
         *          必须using System.Collections
         *      2）接收弹出的元素，要进行强制类型转换
         *  步骤：
         *      1）Queue:创建非泛型队列
         *      2）Enqueue():添加元素
         *      3）Dequeue():读取并弹出元素
         *      4）Peek();只读取元素，不弹出
         *      5）Count:返回元素数量
         *      6）TrimExcess():设置容量为queue中元素的实际个数（有什么用咧？）
         *      7）Contains:某个元素是否存在
         *      8）CopyTo():复制到一个已有的数组
         *      9）ToArray():返回一个数组
         */
        public static void DA06_01()
        {
            //1）Queue: 创建非泛型队列
            Console.WriteLine("Create two queue:qChar and qString...");
            Queue qChar = new Queue();
            Queue qString = new Queue();
            Console.WriteLine("Create succees!");
            Forms.End();

            //2）Enqueue():添加元素
            Console.WriteLine("Add some data into the queue...");
            qChar.Enqueue('a');
            qChar.Enqueue('b');
            qChar.Enqueue('c');

            qString.Enqueue("good");
            qString.Enqueue("normal");
            qString.Enqueue("notBad");

            Console.WriteLine("In qChar data is:");
            foreach (char c in qChar)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("In qString data is:");
            foreach (string s in qString)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Forms.End();

            //3）Dequeue():读取并弹出元素
            Console.WriteLine("Pop a data from qChar...");
            //必须进行强制类型转换
            char tempChar = (char)qChar.Dequeue();
            Console.WriteLine($"Poped data is: {tempChar}");
            Console.WriteLine("now, qChar become:");
            foreach (char c in qChar)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Forms.End();

            //4）Peek(); 只读取元素，不弹出
            Console.WriteLine("Read the first data from qChar...");
            Console.WriteLine($"The first data is: {qChar.Peek()}");
            Forms.End();

            //5）Count: 返回元素数量
            Console.WriteLine("Add a data to qChar...");
            qChar.Enqueue('d');
            Console.WriteLine("qChar become:");
            foreach (char c in qChar)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"qChar const is: {qChar.Count}");
            Forms.End();

            //6）TrimExcess():设置容量为queue中元素的实际个数（有什么用咧？）
            Console.WriteLine("pop a data");
            qChar.Dequeue();
            Console.WriteLine("qChar is:");
            foreach (char c in qChar)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"qChar const is: {qChar.Count}");
            qChar.TrimToSize();
            Forms.End();

            //7）Contains: 某个元素是否存在
            Console.WriteLine("Search item of 'd' in qChar...");
            if (qChar.Contains('d'))
            {
                Console.WriteLine("Search succeed!");
            }
            else
            {
                Console.WriteLine("Search fail. 'd' is not in qChar.");
            }
            Forms.End();

            //8）CopyTo():复制到一个已有的数组
            Console.WriteLine("Copy to array...");
            char[] arr = new char[qChar.Count];
            qChar.CopyTo(arr, 0);
            Console.WriteLine("Copy succeed. Print the array:");
            Forms.PrintArr(arr);
            Console.WriteLine("arr type is: " + arr.GetType());
            Forms.End();

            //9）ToArray():返回一个数组
            Console.WriteLine("To array...");
            object[] arr_2 = qChar.ToArray();
            Console.WriteLine("arr_2 type is: " + arr_2.GetType());
            Console.WriteLine("print arr_2...");
            Forms.PrintArr(arr_2);

        }

    }
}
