public class Edge
{
    public string Target { get; set; }
    public int Cost { get; set; }
}

public class Graph
{
    public Dictionary<string, List<Edge>> AdjacencyList { get; private set; } = new Dictionary<string, List<Edge>>();

    public void AddEdge(string source, string target, int cost)
    {
        if (!AdjacencyList.ContainsKey(source))
            AdjacencyList[source] = new List<Edge>();
            
        if (!AdjacencyList.ContainsKey(target))
            AdjacencyList[target] = new List<Edge>();

        AdjacencyList[source].Add(new Edge { Target = target, Cost = cost });
    }

    public List<Edge> GetNeighbors(string node)
    {
        return AdjacencyList.ContainsKey(node) ? AdjacencyList[node] : new List<Edge>();
    }
}