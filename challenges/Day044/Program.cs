using System;
using System.Collections.Generic;

public class Node
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Node(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    public static double GetDistance(Node a, Node b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }
}

public class Edge
{
    public Node From { get; set; }
    public Node To { get; set; }
    public double Cost { get; set; }

    public Edge(Node from, Node to, double cost)
    {
        From = from;
        To = to;
        Cost = cost;
    }
}

public class AStar
{
    public static List<Node> AStarAlgorithm(Node start, Node goal, List<Edge> edges)
    {
        var openSet = new SortedSet<(double, Node)>(Comparer<(double, Node)>.Create((a, b) => a.Item1.CompareTo(b.Item1)));
        var cameFrom = new Dictionary<Node, Node>();
        var gScore = new Dictionary<Node, double>();
        var fScore = new Dictionary<Node, double>();

        openSet.Add((0, start));
        gScore[start] = 0;
        fScore[start] = Node.GetDistance(start, goal);

        while (openSet.Count > 0)
        {
            var current = openSet.Min.Item2;
            openSet.Remove(openSet.Min);

            if (current == goal)
                return ReconstructPath(cameFrom, current);

            foreach (var edge in edges)
            {
                if (edge.From == current)
                {
                    var neighbor = edge.To;
                    var tentative_gScore = gScore[current] + edge.Cost;

                    if (!gScore.ContainsKey(neighbor) || tentative_gScore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentative_gScore;
                        fScore[neighbor] = gScore[neighbor] + Node.GetDistance(neighbor, goal);

                        if (!openSet.Contains((fScore[neighbor], neighbor)))
                            openSet.Add((fScore[neighbor], neighbor));
                    }
                }
            }
        }

        return null;
    }

    private static List<Node> ReconstructPath(Dictionary<Node, Node> cameFrom, Node current)
    {
        var totalPath = new List<Node> { current };
        while (cameFrom.ContainsKey(current))
        {
            current = cameFrom[current];
            totalPath.Insert(0, current);
        }
        return totalPath;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var a = new Node("A", 0, 0);
        var b = new Node("B", 2, 1);
        var c = new Node("C", 4, 3);
        var d = new Node("D", 5, 5);
        var e = new Node("E", 6, 1);
        
        var edges = new List<Edge>
        {
            new Edge(a, b, 2.5),
            new Edge(a, c, 4),
            new Edge(b, c, 1.5),
            new Edge(b, e, 6),
            new Edge(c, d, 2.5),
            new Edge(d, e, 3)
        };

        var path = AStar.AStarAlgorithm(a, e, edges);

        if (path != null)
        {
            Console.WriteLine("Caminho mais curto encontrado:");
            foreach (var node in path)
            {
                Console.WriteLine(node.Name);
            }
        }
        else
        {
            Console.WriteLine("Caminho não encontrado!");
        }
    }
}
