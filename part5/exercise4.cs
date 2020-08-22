using System;
using System.Collections.Generic;

namespace part5
{
    public class Communication
    {
        public List<int> visited;
        public List<int>[] graph;

        public Communication(int n)
        {
            
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
        /*
        // own solution of a helper method below found from the Internet

        // Used the same helper method as in exercise 3 
        // Used it in the Examine method 
        public void DFS(int x, bool[] visited)
        {
            visited[x-1] = true;
            foreach (int i in graph[x])
            {
                if(!visited[i-1])
                {
                    DFS(i, visited);
                }
            }
        }
        */
        public bool Examine(int x, int y)
        {
            this.visited = new List<int>();

            Calculate(x);

            return this.visited.Contains(y);
        }

        public void Calculate(int x)
        {
            if (this.visited.Contains(x))
            {
                return;
            }
            this.visited.Add(x);
            foreach (int neighbor in this.graph[x])
            {
                Calculate(neighbor);
            }
        }
        



        
    }
}