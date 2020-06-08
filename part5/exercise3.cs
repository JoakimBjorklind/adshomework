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

        public int Calculate()
        {
            int sum = 0;
            bool[] visited = new bool[n];
            for(int v = 1; v<=n; v++)
            {
                if(!visited[v-1])
                {
                    DFS(v,visited);
                    sum++;
                }
            }
            return sum;

        }
        // Some pseudo that Heikki gave, unfortunately no help!
        /*public int Calculate()
        {
            int sum = 0;
            bool[] visited = new bool[n];
            foreach (int i in graph[n])
            {
                if (!visited[n])
                {
                    sum++;
                }
            }
            return sum;
        }*/

        
    }
}