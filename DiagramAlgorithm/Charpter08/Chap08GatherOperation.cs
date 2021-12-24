#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter08
* 项目描述 ：
* 类 名 称 ：Chap08GatherOperation.cs
* 类 描 述 ：
* 命名空间 ：Charpter08
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-23 17:12
* 更新时间 ：2021-12-23 17:12
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
using DA00Forms;

namespace Charpter08
{
    class Chap08GatherOperation
    {
        /*
         *  例程编号：DA08_01
         *  摘要：集合操作
         *  说明：
         *      1）交集
         *      2）差集
         *      3）并集
         *  步骤：
         *      1）
         */
        public static void DA08_01()
        {
            #region 泛型集合
            //Console.WriteLine("Create two List of Int...");
            //List<int> list_01 = new List<int> { 1, 2, 3, 5, 7, 9 };
            //List<int> list_02 = new List<int> { 2, 4, 6, 8, 9, 10 };
            //Forms.PrintList(list_01);
            //Forms.PrintList(list_02);
            //Forms.Line();

            //Console.WriteLine("Test: List, Intersect, ToArray...");
            //int[] arrIntersect = list_01.Intersect<int>(list_02).ToArray();
            //Forms.PrintArr(arrIntersect);
            //Forms.Line();

            //Console.WriteLine("Test: List, Except, ToArray...");
            //int[] arrExcept = list_01.Except<int>(list_02).ToArray();
            //Forms.PrintArr(arrExcept);
            //Forms.Line();

            //Console.WriteLine("Test: List, Union, ToArray...");
            //int[] arrUnion = list_01.Union<int>(list_02).ToArray();
            //Forms.PrintArr(arrUnion);
            //Forms.Line();
            #endregion

            #region 数组
            //Console.WriteLine("Create two array of int...");
            //int[] arr_01 = { 1, 2, 3, 5, 7, 9 };
            //int[] arr_02 = { 2, 4, 6, 8, 9, 10 };
            //Forms.PrintArr(arr_01);
            //Forms.PrintArr(arr_02);
            //Forms.Line();

            //Console.WriteLine("Test: Array, Intersect, ToList...");
            //List<int> listIntersect = arr_01.Intersect<int>(arr_02).ToList();
            //Forms.PrintList(listIntersect);
            //Forms.Line();

            //Console.WriteLine("Test: Array, Except, ToList...");
            //List<int> listExcept = arr_01.Except<int>(arr_02).ToList();
            //Forms.PrintList(listExcept);
            //Forms.Line();

            //Console.WriteLine("Test: Array, Union, ToList...");
            //List<int> listUnion = arr_01.Union<int>(arr_02).ToList();
            //Forms.PrintList(listUnion);
            //Forms.Line();
            #endregion

            #region List & 数组
            Console.WriteLine("Create two array of int...");
            int[] arr_01 = { 1, 2, 3, 5, 7, 9 };
            int[] arr_02 = { 2, 4, 6, 8, 9, 10 };
            Console.WriteLine("Create two list of int...");
            List<int> list_01 = new List<int>() { 1, 2, 3, 5, 7, 9 };
            List<int> list_02 = new List<int>() { 2, 4, 6, 8, 9, 10 };
            Forms.PrintArr(arr_01);
            Forms.PrintArr(arr_02);
            Forms.Line();

            Console.WriteLine("Test: Intersect...");
            int[] arrIntersect = arr_01.Intersect<int>(arr_02).ToArray();
            Console.WriteLine("array to array...");
            Forms.PrintArr(arrIntersect);
            List<int> listIntersect = list_01.Intersect<int>(list_02).ToList();
            Console.WriteLine("list to list...");
            Forms.PrintList(listIntersect);
            Forms.Line();

            Console.WriteLine("Test: Except...");
            int[] arrExcept = arr_01.Except<int>(arr_02).ToArray();
            Console.WriteLine("array to array...");
            Forms.PrintArr(arrExcept);
            List<int> listExcept = list_01.Except<int>(list_02).ToList();
            Console.WriteLine("list to list...");
            Forms.PrintList(listExcept);
            Forms.Line();

            Console.WriteLine("Test: Union...");
            int[] arrUnion = arr_01.Union<int>(arr_02).ToArray();
            Console.WriteLine("array to array...");
            Forms.PrintArr(arrUnion);
            List<int> listUnion = list_01.Union<int>(list_02).ToList();
            Console.WriteLine("list to list...");
            Forms.PrintList(listUnion);

            Forms.End();
            #endregion
        }
    }
}
