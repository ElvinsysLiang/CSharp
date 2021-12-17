#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter07
* 项目描述 ：
* 类 名 称 ：Chap07Dijkstra.cs
* 类 描 述 ：
* 命名空间 ：Charpter06
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-16 18:40
* 更新时间 ：2021-12-16 18:40
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

namespace Charpter07
{
    class Node
    {
        //名称（好像不需要？
        //邻居键值对
        public Dictionary<Node, int> friends = new Dictionary<Node, int>();
        //是否被处理过
        public bool check;
        public Node()
        {
            check = false;
        }
    }

    class Chap07Dijkstra
    {
        public static void DA07_01()
        {
            //测试实例：Dijkstra算法
            //创建节点
            Node start = new Node();
            Node end = new Node();
            Node a = new Node();
            Node b = new Node();
            //加入各节点的邻居
            start.friends.Add(a, 6);
            start.friends.Add(b, 2);
            a.friends.Add(end, 1);
            b.friends.Add(a, 3);
            b.friends.Add(end, 5);
            //创建费用表
            Dictionary<Node, int> dCost = new Dictionary<Node, int>();
            dCost.Add(a, 6);
            dCost.Add(b, 2);
            dCost.Add(end, int.MaxValue);
            //父节点记录表（好像不需要？
            Node tNode = GetLowestCostNode(dCost);
            while (tNode != null)
            {
                tNode.check = true;
                foreach (KeyValuePair<Node, int> kvp in tNode.friends)
                {
                    if (kvp.Value + dCost[tNode] < dCost[kvp.Key])
                    {
                        dCost[kvp.Key] = kvp.Value + dCost[tNode];
                    }
                }
                tNode = GetLowestCostNode(dCost);
            }
            Console.WriteLine("cost is: " + dCost[end]);
        }


        public static Node GetLowestCostNode(Dictionary<Node, int> dCost)
        {
            Node tNode = null;
            int tCost = int.MaxValue;
            foreach (KeyValuePair<Node, int> kvp in dCost)
            {
                if (kvp.Value < tCost && kvp.Key.check == false)
                {
                    tCost = kvp.Value;
                    tNode = kvp.Key;
                }
            }
            return tNode;
        }
    }
}
