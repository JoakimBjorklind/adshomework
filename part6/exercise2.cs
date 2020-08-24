using System;
using System.Collections.Generic;

namespace part6
{
    public class Dijkstra
    {
        /*
        // own solution below
        
        public int n;
        public int[,] adjMatrix;
        public Dijkstra(int n)
        {
            this.n = n;
            this.adjMatrix = new int[n + 1, n + 1];
        }

        public void AddRoad(int a, int b, int d)
        {
            adjMatrix[a, b] = d;
            adjMatrix[b, a] = d;

        }

        public int Calculate(int x, int y)
        {
            int INF = 9999;
            int[] distance = new int[n + 1];
            bool[] shortestPTS = new bool[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                distance[i] = INF;
                shortestPTS[i] = false;

            }
            distance[x] = 0;

            for (int i = 0; i < n; i++)
            {
                int min = INF;
                int minIndex = 0;

                for (int j = 0; j < n + 1; j++)
                {
                    if (shortestPTS[j] == false && distance[j] <= min)
                    {
                        min = distance[j];
                        minIndex = j;
                    }

                }
                shortestPTS[minIndex] = true;

                for (int v = 0; v < n + 1; v++)
                {
                    if (!shortestPTS[v] && adjMatrix[minIndex, v] != 0 && distance[minIndex] != INF && distance[minIndex] + adjMatrix[minIndex, v] < distance[v])
                    {
                        distance[v] = distance[minIndex] + adjMatrix[minIndex, v];
                    }
                }
            }
            if (distance[y] == INF)
            {
                return -1;
            }
            else
            {
                return distance[y];
            }

        }
        */

        private int n;
        private int[,] graph;
        private int INF = 999999;
        private int undefined = -1;

        public Dijkstra(int n)
        {
            this.n = n;
            // initiate the graph for all to be INF in the beginning
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

        public int Calculate(int x, int y)
        {
            int[] answer = Algorithm(this.graph, x);

            if (answer[y] == this.INF)
            {
                return -1;
            }
            else
            {
                return answer[y];
            }
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
            return distance;
        }


    }
}