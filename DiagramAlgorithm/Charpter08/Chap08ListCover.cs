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
using DA00Forms;

namespace Charpter08
{
    class Chap08ListCover
    {
        public static void DA08_02()
        {
            //初始化区域
            string[] statesNeeded = { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            Forms.PrintArr(statesNeeded);
            #region oldCode
            //初始化区域
            //List<string> states_needed = new List<string>()
            //{ "mt","wa","or","id","nv","ut","ca","az"};
            //foreach (string s in states_needed)
            //{
            //    Console.WriteLine(s);
            //}
            //List<string> kone = new List<string>()
            //{ "id","nv","ut"};
            //List<string> ktwo = new List<string>()
            //{ "wa","id","mt"};
            //List<string> kthree = new List<string>()
            //{ "or","nv","ca"};
            //List<string> kfour = new List<string>()
            //{ "nv","ut"};
            //List<string> kfive = new List<string>()
            //{ "ca","az"};
            //ArrayList stationList = new ArrayList()
            //{ kone,ktwo,kthree,kfour,kfive};

            //ArrayList bestStationList = GetBestStationList(stationList, states_needed);

            //Console.WriteLine("The bestStation have:");
            //foreach(var bs in bestStationList)
            //{
            //    Console.Write(bs.ToString() + " ");
            #endregion
            //初始化站点
            Station kone = new Station("kone");
            Station ktwo = new Station("ktwo");
            Station kthree = new Station("kthree");
            Station kfour = new Station("kfour");
            Station kfive = new Station("kfive");
            //创建站点数组
            Station[] stationList = { kone, ktwo, kthree, kfour, kfive };
            //初始化各站点的覆盖范围
            kone.CoverArea = new string[] { "id", "nv", "ut" };
            ktwo.CoverArea = new string[] { "wa", "id", "mt" };
            kthree.CoverArea = new string[] { "or", "nv", "ca" };
            kfour.CoverArea = new string[] { "nv", "ut" };
            kfive.CoverArea = new string[] { "ca", "az" };

            //利用贪心算法，求覆盖所有洲的电台
            List<Station> BestStationList = GetBestStationList(stationList, statesNeeded);
            Console.WriteLine("The best station is:");
            foreach (Station s in BestStationList)
            {
                Console.Write(s.Name + " ");
            }
            Console.WriteLine();

        }

        private static List<Station> GetBestStationList(Station[] stationList, string[] statesNeeded)
        {
            List<Station> BestStationList = new List<Station>();
            int covered;
            Station bestStation;
            string[] statesUnCovered = new string[statesNeeded.Length];
            for (int i = 0; i < statesNeeded.Length; i++)
            {
                statesUnCovered[i] = statesNeeded[i];
            }
            while (statesUnCovered.Length != 0)
            {
                covered = 0;
                bestStation = null;
                foreach (Station s in stationList)
                {
                    //foreach(string ss in (s.CoverArea.Intersect<string>(statesUnCovered)).ToArray())
                    //{
                    //    Console.Write(ss + " ");
                    //}
                    //Console.WriteLine();
                    if (s.CoverArea.Intersect<string>(statesUnCovered).Count() > covered)
                    {
                        covered = s.CoverArea.Intersect<string>(statesUnCovered).Count();
                        bestStation = s;
                    }
                }
                BestStationList.Add(bestStation);
                statesUnCovered = statesUnCovered.Except<string>(bestStation.CoverArea).ToArray();
            }
            return BestStationList;
        }

        private static ArrayList GetBestStationList_bak(ArrayList stationList, List<string> states)
        {
            ArrayList bestStationList = new ArrayList();
            List<string> states_needed = new List<string>();
            List<string> bestStation;
            int covered;
            foreach (string s in states)
            {
                states_needed.Add(s);
            }
            while (states_needed.Count != 0)
            {
                bestStation = null;
                covered = 0;
                foreach (List<string> ls in stationList)
                {
                    if (ls.Intersect<string>(states_needed).Count() > covered)
                    {
                        covered = ls.Intersect<string>(states_needed).Count();
                        bestStation = ls;
                    }
                }
                bestStationList.Add(bestStation);
                states_needed = states_needed.Except<string>(bestStation).ToList();
            }
            return bestStationList;
        }
    }
    //创建站点类
    class Station
    {
        private string _name;
        private string[] _coverArea;
        public Station(string name)
        {
            _name = name;
            _coverArea = null;
        }
        public string Name { get => _name; set => _name = value; }
        public string[] CoverArea { get => _coverArea; set => _coverArea = value; }
    }
}
