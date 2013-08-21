﻿using System;
using System.Collections.Generic;

namespace Salaries
{
    public class Node
    {
        public int ID { get; set; }
        public int Salary { get; set; }
        public List<Node> Children { get; set; }

        public Node(int value)
        {
            this.ID = value;
            this.Salary = 0;
            this.Children = new List<Node>();
        }
    }

    public class SalariesMain
    {
        private static Node[] nodes;
        private static bool[] visited;

        public static int CalculateSalary(Node node)
        {
            if (node.Children.Count == 0)
            {
                node.Salary = 1;
            }
            else
            {
                foreach (var child in node.Children)
                {
                    if (!visited[child.ID])
                    {
                        node.Salary += CalculateSalary(child);
                    }
                    else
                    {
                        node.Salary += child.Salary;
                    }
                }
            }

            visited[node.ID] = true;
            return node.Salary;
        }

        public static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            nodes = new Node[nodesCount];
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Node(i);
            }

            for (int i = 0; i < nodesCount; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'Y')
                    {
                        nodes[i].Children.Add(nodes[j]);
                    }
                }
            }

            visited = new bool[nodesCount];
            for (int i = 0; i < nodes.Length; i++)
            {
                if (!visited[i])
                {
                    CalculateSalary(nodes[i]);
                }
            }

            int sumOfAllSalaries = 0;
            for (int i = 0; i < nodes.Length; i++)
            {
                sumOfAllSalaries += nodes[i].Salary;
            }

            Console.WriteLine(sumOfAllSalaries);
        }
    }
}

