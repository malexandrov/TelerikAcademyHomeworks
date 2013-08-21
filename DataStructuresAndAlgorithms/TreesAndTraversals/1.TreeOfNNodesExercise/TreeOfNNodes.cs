using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeOfNNodesExercise
{
    class TreeOfNNodes
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[N];
            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 0; i < N-1; i++)
            {
                string connection = Console.ReadLine();
                string[] tokens = connection.Split(' ');
                int parent = int.Parse(tokens[0]);
                int child = int.Parse(tokens[1]);

                nodes[parent].Children.Add(nodes[child]);
                nodes[child].Parent = nodes[parent];
            }

            // 1. Find the root node
            var root = FindRoot(nodes);
            Console.WriteLine("The root is: " + root.Value);

            // 2. Find the leaf nodes
            var leaves = FindLeaves(nodes);

            Console.Write("The leaves are: ");
            foreach (var leaf in leaves)
            {
                Console.Write(leaf.Value + " ");
            }
            Console.WriteLine();

            // 3. Find the middle nodes
            var middleNodes = FindMiddleNodes(nodes);

            Console.Write("The middle nodes are: ");
            foreach (var node in middleNodes)
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            // 4. Find the longest path in the tree
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Longest path from root is: " + longestPath);

            // 5. Find all paths in the tree with given sum S
            int sumS = 9;
            var treePaths = new List<List<int>>();
            var currentPath = new List<int>();
            currentPath.Add(root.Value);
            FindPathsWithSum(sumS, root, root.Value, currentPath, treePaths);

            Console.WriteLine("All paths with sum {0}: ", sumS);
            foreach (var path in treePaths)
            {
                foreach (var value in path)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

        }

        private static void FindPathsWithSum(int sum, Node<int> node, int valueSum, 
            List<int> currentPath, List<List<int>> treePaths)
        {
            foreach (var child in node.Children)
            {
                currentPath.Add(child.Value);
                valueSum += child.Value;
                if (valueSum == sum)
                {
                    treePaths.Add(currentPath.GetRange(0, currentPath.Count));
                }

                FindPathsWithSum(sum, child, valueSum, currentPath, treePaths);

                currentPath.RemoveAt(currentPath.Count - 1);
                valueSum -= child.Value;
            }
        }



        private static int FindLongestPath(Node<int> node)
        {
            if (node.Children.Count <= 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var child in node.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(child));
            }
            return maxPath + 1;
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Parent == null)
                {
                    return node;
                }
            }

            throw new ArgumentException("nodes", "The tree has no root.");
        }

        private static List<Node<int>> FindLeaves(Node<int>[] nodes)
        {
            if (nodes == null)
            {
                throw new ArgumentNullException("nodes", "Nodes cannot be null");
            }

            List<Node<int>> leaves = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leaves.Add(node);
                }
            }
            return leaves;
        }

        private static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
        {
            if (nodes == null)
            {
                throw new ArgumentNullException("nodes", "Nodes cannot be null");
            }

            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Parent != null && node.Children.Count > 0 )
                {
                    middleNodes.Add(node);
                }
            }
            return middleNodes;
        }
    }
}


