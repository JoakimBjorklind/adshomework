using System;
using System.Collections.Generic;

namespace part6
{
    public class ShortestPath
    {
        public int n;
        public int[,] graph;
        private int INF = 999999;
        private int undefined = -1;
        public ShortestPath(int n)
        {
            this.n = n;
            // same as in previous exercises 
            this.graph = new int[n + 1, n + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    this.graph[i, j] = INF;
                }
            }
        }

        public void AddRoad(int a, int b, int d)
        {
            this.graph[a, b] = d;
            this.graph[b, a] = d;
        }

        public List<int> Create(int x, int y)
        {
            List<int> result = new List<int>();
            int[] answer = Algorithm(this.graph, x);
            FindPath(result, answer, y);
            return result;
        }

        private void FindPath(List<int> result, int[] path, int y)
        {
            if (y == this.undefined)
            {
                return;
            }
            FindPath(result, path, path[y]);
            result.Add(y);
        }

        private int[] Algorithm(int[,] graph, int sourceNode)
        {
            int[] distance = new int[this.n + 1];
            bool[] Q = new bool[this.n + 1];
            int[] previous = new int[this.n + 1];

            for (int i = 1; i <= this.n; i++)
            {
                distance[i] = this.INF;
                previous[i] = this.undefined;
                Q[i] = true;

            }

            distance[sourceNode] = 0;

            for (int i = 1; i <= this.n; i++)
            {
                int nearestNode = -1;
                int shortestDistance = this.INF;
                for (int j = 1; j <= this.n; j++)
                {
                    if (Q[j] && distance[j] <= shortestDistance)
                    {
                        nearestNode = j;
                        shortestDistance = distance[j];
                    }
                }
                Q[nearestNode] = false;

                for (int j = 1; j <= this.n; j++)
                {
                    int edgeDistance = graph[nearestNode, j];
                    if (edgeDistance > 0 && ((shortestDistance + edgeDistance) < distance[j]))
                    {
                        previous[j] = nearestNode;
                        distance[j] = shortestDistance + edgeDistance;
                    }

                }
            }
            return previous;
        }

        
    }
}