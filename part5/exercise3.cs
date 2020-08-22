using System;
using System.Collections.Generic;

namespace part5
{
    public class Components
    {
        public int n;
        public List<int>[] graph;



        public Components(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];


            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        // Found this way of having a helper method on the internet
        // on the site geeksforgeeks.org/connected-components-in-an-undirected-graph/
        // used this method to get the Calculate method to work!
        /*
        // some helper method from Internet below, works as an alternative solution
        public void DFS(int v, bool[] visited)
        {
            visited[v-1] = true;
            foreach (int i in graph[v])
            {
                if(!visited[i-1])
                {
                    DFS(i, visited);
                }
            }
        }
        */
        void ConnectedComponents(int v, bool[] visited)
        {
            visited[v] = true;

            foreach (int x in this.graph[v])
            {
                if (!visited[x])
                {
                    ConnectedComponents(x, visited);
                }
            }
        }


        public int Calculate()
        {
            int sum = 0;
            bool[] visited = new bool[this.n + 1];
            for (int v = 1; v <= this.n; v++)
            {
                if (!visited[v])
                {
                    ConnectedComponents(v, visited);
                    sum++;
                }
            }
            return sum;

        }


    }
}