using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adjacency
{
    internal class Program
    {
        enum color
        {
            turquoise,
            orange,
            yellow,
            grey,
            lBlue,
            dBlue,
            green,
            pink
        }

        static bool[,] mGraph = new bool[,]
        {
            //              turquoise  orange   yellow   grey     lBlue    dBlue    green    pink   
            /* turqoise */{  false,   false,    true,    true,   false,   false,   false,   false},
            /* orange   */{  false,   false,    true,    true,   false,   false,   false,   false},
            /* yellow   */{  false,    true,   false,   false,   false,    true,   false,   false},
            /* grey     */{  false,    true,   false,   false,    true,   false,   false,   false},
            /* lBlue    */{  false,   false,   false,   false,   false,   false,    true,   false},
            /* dBlue    */{  false,   false,   false,   false,   false,   false,   false,    true},
            /* green    */{  false,   false,   false,   false,   false,    true,   false,   false},
            /* pink     */{  false,   false,   false,   false,   false,   false,   false,   false}
        };

        static int[][] lGraph = new int[][]
        {
            /* turquise */ new int[] { (int)color.grey,  (int)color.yellow},       
            /* orange   */ new int[] { (int)color.yellow,  (int)color.grey},       
            /* yellow   */ new int[] { (int)color.orange,  (int)color.dBlue},    
            /* grey     */ new int[] { (int)color.orange,  (int)color.lBlue},    
            /* lBlue    */ new int[] { (int)color.green},       
            /* dBlue    */ new int[] { (int)color.pink},          
            /* green    */ new int[] { (int)color.dBlue},          
            /* pink     */ new int[] {}
        };

        static bool[] visited; // To keep track of visited nodes during DFS
        static List<color> dfsResult; // To store the DFS traversal result

        static void Main(string[] args)
        {
            // Depth First Search (DFS)
            Console.WriteLine("DFS traversal starting from turquoise:");
            DFS((int)color.turquoise);
            foreach (color c in dfsResult)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            // Dijkstra's Shortest Path Algorithm
            Console.WriteLine("Shortest path from orange to pink:");
            List<color> shortestPath = Dijkstra((int)color.orange, (int)color.pink);
            foreach (color c in shortestPath)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }

        static void DFS(int start)
        {
            visited = new bool[mGraph.GetLength(0)];
            dfsResult = new List<color>();
            DFSUtil(start);
        }
        static void DFSUtil(int v)
        {
            visited[v] = true;
            dfsResult.Add((color)v);

            foreach (int neighbor in lGraph[v])
            {
                if (!visited[neighbor])
                {
                    DFSUtil(neighbor);
                }
            }
        }
        static List<color> Dijkstra(int start, int end)
        {
            int numVertices = lGraph.Length;
            int[] distance = new int[numVertices];
            bool[] shortestPathTreeSet = new bool[numVertices];
            int[] parent = new int[numVertices];

            // Initialize distance array
            for (int i = 0; i < numVertices; i++)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[start] = 0; // Distance from start vertex to itself is 0

            for (int count = 0; count < numVertices - 1; count++)
            {
                int u = MinDistance(distance, shortestPathTreeSet);

                shortestPathTreeSet[u] = true;

                for (int v = 0; v < numVertices; v++)
                {
                    if (!shortestPathTreeSet[v] && lGraph[u].Contains(v) && distance[u] != int.MaxValue && distance[u] + GetCost((color)u, (color)v) < distance[v])
                    {
                        distance[v] = distance[u] + GetCost((color)u, (color)v);
                        parent[v] = u;
                    }
                }
            }

            return GetShortestPath(parent, start, end);
        }
        static int MinDistance(int[] distance, bool[] shortestPathTreeSet)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < distance.Length; v++)
            {
                if (!shortestPathTreeSet[v] && distance[v] <= minDistance)
                {
                    minDistance = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        static int GetCost(color source, color destination)
        {
            // Define the cost of each color transition
            if (source == color.turquoise && destination == color.yellow)
                return 1;
            if (source == color.turquoise && destination == color.grey)
                return 5;
            if (source == color.orange && destination == color.yellow)
                return 1;
            if (source == color.orange && destination == color.grey)
                return 0;
            if (source == color.yellow && destination == color.orange)
                return 1;
            if (source == color.yellow && destination == color.dBlue)
                return 8;
            if (source == color.grey && destination == color.orange)
                return 0;
            if (source == color.grey && destination == color.lBlue)
                return 1;
            if (source == color.lBlue && destination == color.green)
                return 1;
            if (source == color.green && destination == color.dBlue)
                return 1;
            if (source == color.dBlue && destination == color.pink)
                return 6;

            return int.MaxValue; // Return a high value for colors without defined costs
        }
        static List<color> GetShortestPath(int[] parent, int start, int end)
        {
            List<color> shortestPath = new List<color>();
            int current = end;

            while (current != start)
            {
                shortestPath.Add((color)current);
                current = parent[current];
            }

            shortestPath.Add((color)start);
            shortestPath.Reverse();

            return shortestPath;
        }
    }
}