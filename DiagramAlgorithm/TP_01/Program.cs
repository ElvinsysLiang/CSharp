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
using System.Collections;

namespace TP_01//用于测试或日常练手，建立的测试实例
{
    //class Program
    //{

    //    public static List<Node> NodeList { get; set; }
    //    public static Dictionary<string, int> CostDictionary { get; set; }
    //    public static Dictionary<string, string> ParentDictionary { get; set; }
    //    public static List<string> CheckedNodeName { get; set; }

    //    public Program()
    //    {
    //        NodeList = new List<Node>
    //        {
    //            new Node
    //            {
    //                NodeName = "start",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"A", 6},
    //                    {"B", 2}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "A",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"end", 1}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "B",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"A", 3},
    //                    {"end", 5}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "end",
    //                RelatedNode = new Dictionary<string, int>()
    //            }
    //        };
    //        CostDictionary = new Dictionary<string, int>()
    //        {
    //            {"A",6},
    //            {"B",2},
    //            {"end",int.MaxValue}
    //        };

    //        ParentDictionary = new Dictionary<string, string>()
    //        {
    //            {"A","start"},
    //            {"B","start"},
    //            {"end",""}
    //        };

    //        CheckedNodeName = new List<string>();

    //    }

    //    static void Main(string[] args)
    //    {
    //        var progra = new Program();
    //        Console.WriteLine($"{"parent",10}|{"node",10}|{"cost",10}");
    //        foreach (var item in NodeList.SelectMany(node => node.RelatedNode, (node, relatenode) => new { node.NodeName, relatenode }))
    //        {
    //            Console.WriteLine($"{item.NodeName,10}|{item.relatenode.Key,10}|{item.relatenode.Value,10}");
    //        }

    //        while (CheckedNodeName.Count != CostDictionary.Count)
    //        {
    //            //找到Cost最小的节点
    //            var currentNode = FindMinCostNode(CostDictionary);
    //            //取出relatednode，
    //            if (currentNode != null)
    //            {
    //                //循环如果subNode的Cost小于CostDictionary的Cost
    //                foreach (var subNode in currentNode.RelatedNode)
    //                {
    //                    if (subNode.Value < CostDictionary[subNode.Key])
    //                    {
    //                        //替换
    //                        CostDictionary[subNode.Key] = subNode.Value + CostDictionary[currentNode.NodeName];
    //                        ParentDictionary[subNode.Key] = currentNode.NodeName;
    //                    }
    //                }
    //                CheckedNodeName.Add(currentNode.NodeName);
    //            }
    //        }

    //        Console.WriteLine("最短路径:" + GetTheMinCostPath());

    //        Console.WriteLine("最短路径开销:" + CostDictionary["end"]);

    //        Console.ReadKey();
    //    }

    //    public static string GetTheMinCostPath()
    //    {
    //        bool isStart = false;
    //        string startKey = "end";
    //        string path = "end=>";
    //        while (!isStart)
    //        {

    //            path += ParentDictionary[startKey] + "=>";
    //            startKey = ParentDictionary[startKey];
    //            if (!ParentDictionary.ContainsKey(ParentDictionary[startKey]))
    //            {
    //                path += ParentDictionary[startKey];
    //                isStart = true;
    //            }
    //        }

    //        return path;
    //    }

    //    public static Node FindMinCostNode(Dictionary<string, int> costDictionary)
    //    {
    //        var costItems = costDictionary.Where(c => !CheckedNodeName.Contains(c.Key)).ToList();
    //        if (costItems.Any())
    //        {
    //            var minCostItem = costItems.OrderBy(c => c.Value).First().Key;
    //            return NodeList.FirstOrDefault(n => n.NodeName == minCostItem);
    //        }
    //        return null;
    //    }
    //}

    //public class Node
    //{
    //    public string NodeName { get; set; }
    //    public Dictionary<string, int> RelatedNode { get; set; }
    //}

    //public class CostItem
    //{
    //    public string ParentName { get; set; }
    //    public string NodeName { get; set; }
    //    public int Cost { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrQS = { 0, 48, 24, 12, 13, 85 };
            int[] arrBS = { 0, 12, 13, 24, 48, 85 };

            string[] s1 = { "1", "2", "3", "5", "7", "9", "10" };
            string[] s2 = { "2", "4", "6", "8", "9" };

            //测试实例：二分查找
            //测试实例：选择排序
            //测试实例：递归阶乘
            //测试实例：快速排序
            //测试实例：散列表用法
            //测试实例：广度优先算法
            //测试实例：Dijkstra算法
            //测试实例：集合操作，交集，差集，并集
            //测试实例：贪心算法，广播站例子（NP完全问题）

            Forms.Title("测试实例：something test...");

            Forms.End();

            Console.ReadKey();
        }
    }
}

