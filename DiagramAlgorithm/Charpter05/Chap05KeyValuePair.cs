#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter05
 * 项目描述 ：
 * 类 名 称 ：Chap05KeyValuePair.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter05
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-10 12:27
 * 更新时间 ：2021-12-10 12:27
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

namespace Charpter05
{
    class Chap05KeyValuePair
    {
        /*
         *  例程编号：DA05_01
         *  摘要：散列表，键值对，字典
         *  说明：
         *      1）
         *  步骤：
         *      1）
         */
        public static void DA05_01()
        {
            //定义散列表
            Console.WriteLine("Define KeyValusPair...");
            Dictionary<string, string> NameBirthday = new Dictionary<string, string>();
            //添加数据
            Console.WriteLine("Add data in KeyValusPair...");
            NameBirthday.Add("Tom", "1991-01");
            NameBirthday.Add("Lucy", "1988-12");
            NameBirthday.Add("Jaco", "1985-11");
            NameBirthday.Add("Kite", "1994-04");
            //取一条数据
            Console.WriteLine("read a date, about Lucy's birthday...");
            Console.WriteLine($"Lucy's birthday is {NameBirthday["Lucy"]}");
            //遍历散列表
            Console.WriteLine("Traversal the KeyValuePair...");
            foreach (KeyValuePair<string, string> kvp in NameBirthday)
            {
                Console.WriteLine($"{kvp.Key}'s birthday is {kvp.Value}");
            }
            //遍历散列表键，方法1
            Console.WriteLine("Traversal the Keys...");
            Console.WriteLine("Method1:");
            Dictionary<string, string>.KeyCollection kc = NameBirthday.Keys;
            foreach (string s in kc)
            {
                Console.WriteLine(s);
            }
            //遍历散列表键，方法2
            Console.WriteLine("Method2:");
            foreach (string s in NameBirthday.Keys)
            {
                Console.WriteLine(s);
            }
            //遍历散列表值，方法1
            Console.WriteLine("Traversal the Values...");
            Console.WriteLine("Method1:");
            Dictionary<string, string>.ValueCollection vc = NameBirthday.Values;
            foreach (string v in vc)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Method2:");
            foreach (string s in NameBirthday.Values)
            {
                Console.WriteLine(s);
            }
            //删除数据
            Console.WriteLine("Remove data of Lucy's birthday...");
            NameBirthday.Remove("Lucy");
            foreach (KeyValuePair<string, string> kvp in NameBirthday)
            {
                Console.WriteLine($"{kvp.Key}'s birthday is {kvp.Value}");
            }
            //修改数据
            Console.WriteLine("updata Tom's birthday...");
            NameBirthday["Tom"] = "1993-03";
            Console.WriteLine($"Tom's birthday is {NameBirthday["Tom"]} now.");
            //判断键存在
            Console.WriteLine("Check the Lucy data exist or not...");
            if (!NameBirthday.ContainsKey("Lucy"))
            {
                Console.WriteLine("Lucy's data not exist.");
            }
            else
            {
                Console.WriteLine("Lucy's data exist.");
            }
        }
    }
}
