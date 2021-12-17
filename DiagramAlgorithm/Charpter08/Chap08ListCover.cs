#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter08
* 项目描述 ：贪婪算法，集合覆盖问题
* 类 名 称 ：Chap08ListCover.cs
* 类 描 述 ：
* 命名空间 ：Charpter08
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-17 23:43
* 更新时间 ：2021-12-17 23:43
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter08
{
    class Chap08ListCover
    {
        public static void DA08_01()
        {
            //初始化区域
            List<string> states_needed = new List<string>()
            { "mt","wa","or","id","nv","ut","ca","az"};
            foreach (string s in states_needed)
            {
                Console.WriteLine(s);
            }
            //states_needed.Add("mt");
            //states_needed.Add("wa");
            //states_needed.Add("or");
            //states_needed.Add("id");
            //states_needed.Add("nv");
            //states_needed.Add("ut");
            //states_needed.Add("ca");
            //states_needed.Add("az");
            List<string> kone = new List<string>()
            { "id","nv","ut"};
            List<string> ktwo = new List<string>()
            { "wa","id","mt"};
            List<string> kthree = new List<string>()
            { "or","nv","ca"};
            List<string> kfour = new List<string>()
            { "nv","ut"};
            List<string> kfive = new List<string>()
            { "ca","az"};
            ArrayList stationsList = new ArrayList()
            { kone,ktwo,kthree,kfour,kfive};

            //用类来表示station，属性是泛型集合？


        }
    }
}
