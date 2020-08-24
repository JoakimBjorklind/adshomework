using System;

namespace part6
{
    class Program
    {
        static void Main(string[] args)
        {
            BellmanFord s = new BellmanFord(6);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            //s.AddRoad(6, 7, 3);

            
            
            Console.WriteLine(s.Calculate(1, 5)); // 12

            Console.WriteLine();

            
            Dijkstra ss = new Dijkstra(6);
            ss.AddRoad(1, 2, 7);
            ss.AddRoad(2, 4, 2);
            ss.AddRoad(1, 3, 6);
            ss.AddRoad(3, 4, 5);
            ss.AddRoad(4, 5, 3);
            //ss.Addroad(4, 5, 3);
            Console.WriteLine(ss.Calculate(1, 5)); // 12

            Console.WriteLine();

            FloydWarshall f = new FloydWarshall(5);
            f.AddRoad(1, 2, 7);
            f.AddRoad(2, 4, 2);
            f.AddRoad(1, 3, 6);
            f.AddRoad(3, 4, 5);
            f.AddRoad(4, 5, 3);
            //s.AddRoad(6, 7, 3);
            Console.WriteLine(f.Calculate(1, 5)); // 12

            Console.WriteLine();

            ShortestPath sh = new ShortestPath(5);
            sh.AddRoad(1, 2, 7);
            sh.AddRoad(2, 4, 2);
            sh.AddRoad(1, 3, 6);
            sh.AddRoad(3, 4, 5);
            sh.AddRoad(4, 5, 3);
            sh.Create(1, 5).ForEach(Console.Write); // 1245
            Console.WriteLine();
            sh.Create(1, 2).ForEach(Console.Write); // 12
            Console.WriteLine();
            sh.Create(1, 4).ForEach(Console.Write); // 124
            Console.WriteLine();
            sh.Create(4, 1).ForEach(Console.Write); // 421
            Console.WriteLine();

        }
    }
}