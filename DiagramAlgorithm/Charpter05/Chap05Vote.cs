#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：Charpter05
 * 项目描述 ：
 * 类 名 称 ：Chap05Vote.cs
 * 类 描 述 ：
 * 命名空间 ：Charpter05
 * 作    者 ：NEETJIN
 * 创建时间 ：2021-12-14 17:10
 * 更新时间 ：2021-12-14 17:10
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
    class Chap05Vote
    {   
        /*
         *  例程编号：DA05_03
         *  摘要：散列表，投票
         *  说明：
         *      1）
         *  步骤：
         *      1）
         */
        public static void DA05_03()
        {
            //创建散列表（投票记录表）
            Console.WriteLine("Create a notebook use of vote...");
            Dictionary<string,int> vote = new Dictionary<string,int>();
            Console.WriteLine("Create succeed!");

            //运行名字检查方法
            Console.WriteLine("Run VoteCheck...");
            VoteCheck("Mike");
            VoteCheck("Tom");
            VoteCheck("Lucy");
            VoteCheck("Mike");

            
            void VoteCheck(string name)
            {
                if (vote.ContainsKey(name))
                {
                    Console.WriteLine($"Sorry, {name} had Voted!");
                }
                else
                {
                    vote.Add(name, 0);
                    Console.WriteLine($"{name} vote succeed!");
                }
            }
        }
    }
}
