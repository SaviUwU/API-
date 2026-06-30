public class RouteOptimizer
{
    public Route FindShortestPath(Graph graph, string start, string end)
    {
        if (!graph.AdjacencyList.ContainsKey(start) || !graph.AdjacencyList.ContainsKey(end))
            return new Route(); // Rota inexistente

        var distances = new Dictionary<string, int>();
        var previous = new Dictionary<string, string>();
        var priorityQueue = new PriorityQueue<string, int>();

        foreach (var node in graph.AdjacencyList.Keys)
        {
            distances[node] = int.MaxValue;
        }

        distances[start] = 0;
        priorityQueue.Enqueue(start, 0);

        while (priorityQueue.Count > 0)
        {
            var current = priorityQueue.Dequeue();

            if (current == end) break;

            foreach (var neighbor in graph.GetNeighbors(current))
            {
                int newDist = distances[current] + neighbor.Cost;
                if (newDist < distances[neighbor.Target])
                {
                    distances[neighbor.Target] = newDist;
                    previous[neighbor.Target] = current;
                    priorityQueue.Enqueue(neighbor.Target, newDist);
                }
            }
        }

        if (distances[end] == int.MaxValue)
            return new Route(); // Caminho não alcançável

        var path = new List<string>();
        var currNode = end;
        while (currNode != null)
        {
            path.Insert(0, currNode);
            previous.TryGetValue(currNode, out currNode);
        }

        return new Route { Path = path, TotalCost = distances[end] };
    }
}