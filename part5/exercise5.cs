using System;
using System.Collections.Generic;

namespace part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            int n = laby.GetLength(0);
            int m = laby.GetLength(1);
            int startY = 0;
            int startX = 0;
            int endY = 0;
            int endX = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (laby[i, j] == 'x')
                    {
                        startY = i;
                        startX = j;
                    }
                    if (laby[i, j] == 'y')
                    {
                        endY = i;
                        endX = j;
                    }
                }
            }

            int[,] distance = new int[n, m];
            bool[,] visited = new bool[n, m];

            // use 2 queues which are doing the operations simultaneously
            // 1 for x-coordinate, 1 for y-coordinate

            Queue<int> queueX = new Queue<int>();
            Queue<int> queueY = new Queue<int>();

            // save the x and y of previous, each into own array in place of current node

            int[,] previousX = new int[n, m];
            int[,] previousY = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    distance[i, j] = int.MaxValue;
                }
            }
            previousX[startY, startX] = -1;
            // only need x to tell ther eis no previous 
            visited[startY, startX] = true;
            distance[startY, startX] = 0;

            // coordinates of root to queue
            queueX.Enqueue(startX);
            queueY.Enqueue(startY);

            while (queueX.Count != 0)
            {
                int currentY = queueY.Dequeue();
                int currentX = queueX.Dequeue();

                // below the idea of going through adjecency list, going through neighbors
                // and check where we can go

                int neighborY = currentY - 1;  // can we go up?
                int neighborX = currentX;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    distance[neighborY, neighborX] = distance[currentY, currentX] + 1;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                neighborY = currentY + 1; // can we go down?
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    distance[neighborY, neighborX] = distance[currentY, currentX] + 1;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                neighborY = currentY;
                neighborX = currentX - 1; // can we go left?
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    distance[neighborY, neighborX] = distance[currentY, currentX] + 1;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }

                neighborX = currentX + 1;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    visited[neighborY, neighborX] = true;
                    distance[neighborY, neighborX] = distance[currentY, currentX] + 1;
                    previousY[neighborY, neighborX] = currentY;
                    previousX[neighborY, neighborX] = currentX;
                    queueX.Enqueue(neighborX);
                    queueY.Enqueue(neighborY);
                }
            }

            if (!visited[endY, endX])
            {
                return null; // did not reach the final node
            }

            string description = "";
            int y = endY;
            int x = endX;

            // follow path from end to start, save based on coordinates of previous from the current.
            // one coordinate of previous is always same as corresponding coordinate of current one.

            while (previousX[y, x] != - 1)
            {
                if (previousY[y, x] == y - 1)
                {
                    description = 'D' + description;
                }
                else if (previousY[y, x] == y + 1)
                {
                    description = 'U' + description;
                }
                else if (previousX[y, x] == x - 1)
                {
                    description = 'R' + description;
                }
                else
                {
                    description = 'L' + description;
                }
                int help = y; // to keep track on old y, before updating x
                y = previousY[y, x];
                x = previousX[help, x];
            }
            return description;

            
        }
    }
}