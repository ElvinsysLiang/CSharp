#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter05
* 项目描述 ：
* 类 名 称 ：Chap05Notebook.cs
* 类 描 述 ：
* 命名空间 ：Charpter05
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-14 16:30
* 更新时间 ：2021-12-14 16:30
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

namespace Charpter05
{
    class Chap05Notebook
    {
        /*
         *  例程编号：DA05_02
         *  摘要：散列表，商品列表与价格
         *  说明：
         *      1）
         *  步骤：
         *      1）
         */
        public static void DA05_02()
        {
            //创建散列表（记事本）
            Console.WriteLine("Create a KeyValuePair...");
            Dictionary<string, double> notebook = new Dictionary<string, double>();
            Console.WriteLine("Create succeed!");
            Forms.End();

            //添加数据
            Console.WriteLine("Add some data...");
            notebook.Add("apple", 0.67);
            notebook.Add("milk", 1.49);
            notebook.Add("avocado", 1.37);
            Console.WriteLine("Add data succeed!");
            Forms.End();

            //遍历记事本
            Console.WriteLine("Traversal the KeyValuePair...");
            foreach (KeyValuePair<string, double> kvp in notebook)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
            Forms.End();

            //修改苹果的价格
            Console.WriteLine("updata apple's data...");
            Console.WriteLine($"before updata:{notebook["apple"]}");
            notebook["apple"] = 1.29;
            Console.WriteLine($"after updata:{notebook["apple"]}");
            Forms.End();

            //如果存在苹果的数据，则删除
            Console.WriteLine("apple's data exits isn't it?");
            if (notebook.ContainsKey("apple"))
            {
                Console.WriteLine("Yes, exist, now begin remove...");
                notebook.Remove("apple");
                if (notebook.ContainsKey("apple") == false)
                {
                    Console.WriteLine("Remove succeed!");
                }
                else
                {
                    Console.WriteLine("Remove failed!");
                }
            }
            else
            {
                Console.WriteLine("apple's data is not exist!");
            }
            Forms.End();

        }
    }
}
