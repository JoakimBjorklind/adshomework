using System;
using System.Collections.Generic;

namespace part6
{
    public class Dijkstra
    {
        
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


    }
}