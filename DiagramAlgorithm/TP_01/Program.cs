#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：TP_01
* 项目描述 ：
* 类 名 称 ：Program.cs
* 类 描 述 ：
* 命名空间 ：TP_01
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-4 10:30
* 更新时间 ：2021-12-4 10:30
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

namespace TP_01//用于测试或日常练手，建立的测试实例
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrQS = { 0, 48, 24, 12, 13, 85 };
            int[] arrBS = { 0, 12, 13, 24, 48, 85 };

            //测试用例：散列表
            //创建散列表（键值对）
            Console.WriteLine("Create KeyValuePairs list...");
            Dictionary<string, string> birthdayList =
                new Dictionary<string, string>();
            Console.WriteLine("Create KeyValuePairs list succeed! Named " +
                "birthdayList.");
            Forms.End();
            //给散列表添加数据
            Console.WriteLine("Updata to KeyValuePairs...");
            birthdayList.Add("Jaco", "1985-01");
            birthdayList.Add("Lucy", "1986-02");
            birthdayList.Add("Big guy", "1980-05");
            birthdayList.Add("Mico", "1990-08");
            Console.WriteLine("Updata succeed!");
            Forms.End();

            //查询单个数据（先检查这个数据是否存在）
            Console.WriteLine("Search a data from KeyValuePairs...");
            if (birthdayList.ContainsKey("Jaco"))
            {
                Console.WriteLine("Search Jaco's data succeed!");
                Console.WriteLine("Jaco's birthday is " + birthdayList["Jaco"]);
            }
            else
            {
                Console.WriteLine("Search Jaco's data failed!");
                Console.WriteLine("Jaco's data is not exist.");
            }
            Forms.End();

            //删除单个数据
            Console.WriteLine("Remove a data from KeyValuePairs...");
            if (birthdayList.ContainsKey("Jaco"))
            {
                birthdayList.Remove("Jaco");
                if (birthdayList.ContainsKey("Jaco") == false)
                {
                    Console.WriteLine("Remove Jaco's data succeed!");
                }
                else
                {
                    Console.WriteLine("Remove failed!");
                }
            }
            else
            {
                Console.WriteLine("Remove Jaco's data failed!");
                Console.WriteLine("Jaco's is not exist!");
            }
            Forms.End();

            //遍历散列表
            Console.WriteLine("Traversal KeyValuePair...");
            foreach (KeyValuePair<string, string> kvp in birthdayList)
            {
                Console.WriteLine($"{kvp.Key}'s birthday is {kvp.Value}.");
            }
            Forms.End();

            //遍历散列表的键
            Console.WriteLine("Traversal KeyValuePairs Keys...");
            //方法1
            Console.WriteLine("Method_1");
            foreach (string s in birthdayList.Keys)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            //方法2
            Console.WriteLine("Method_2");
            Dictionary<string, string>.KeyCollection kc = birthdayList.Keys;
            foreach (string s in kc)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Forms.End();

            //遍历散列表的值
            Console.WriteLine("Traversal KeyValuePairs Values...");
            //方法1
            Console.WriteLine("Method_1");
            foreach (string s in birthdayList.Values)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            //方法2
            Console.WriteLine("Method_2");
            Dictionary<string, string>.ValueCollection vc = birthdayList.Values;
            foreach (string s in vc)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Forms.End();

            //修改Lucy的数据
            Console.WriteLine("updata a data ...");
            Console.WriteLine("before updata:");
            Console.WriteLine($"Lucy's birthday is {birthdayList["Lucy"]}");
            Console.WriteLine("after updata:");
            birthdayList["Lucy"] = "1988-06";
            Console.WriteLine($"Lucy's birthday is {birthdayList["Lucy"]}");
            Forms.End();

            Console.ReadKey();
        }



    }
}
