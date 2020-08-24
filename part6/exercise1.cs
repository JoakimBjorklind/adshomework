using System;
using System.Collections.Generic;

namespace part6
{

    // Pesudocode for BellmanFord
    /*
    while true
       change = false
       for edge in edges
         current = distance[edge.end]
         new = distance[edge.source]+edge.weight
         if new < current
           distance[edge.end] = new
           change = true
       if not change
         break
    */
    public class Edge
    {
        public int beginning, end, weight;

        public Edge(int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }
    public class BellmanFord
    {
        public int n;


        // below the 2 different ways of writing the constructor, 
        List<Edge> edges = new List<Edge>();
        // public List<Edge> edges;

        public BellmanFord(int n)
        {
            this.n = n;
            //this.edges = new List<Edge>();
        }



        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edge(a, b, d));
            this.edges.Add(new Edge(b, a, d));

        }

        public int Calculate(int x, int y)
        {
            int INF = 9999;
            int[] distance = new int[this.n + 1];
            for (int i = 1; i <= this.n; i++)
            {
                distance[i] = INF;

            }
            // give starting point 'x' a distance of 0
            distance[x] = 0;

            while (true)
            {
                bool change = false;

                foreach (Edge i in edges)
                {
                    int current = distance[i.end];
                    int newCurrent = distance[i.beginning] + i.weight;

                    if (newCurrent < current)
                    {
                        distance[i.end] = newCurrent;
                        change = true;
                    }

                }
                if (!change)  // or change == false inside if-statement
                {
                    break;
                }

            }
            //return distance[y];
            // did not first get this to work, it gave the maxvalue 2147483647 instead of -1

            if (distance[y] == INF)
            {
                return -1;
            }
            else
            {
                return distance[y];
            }

            //changed the maxValue to 9999 and it started working!!

        }
    }
}