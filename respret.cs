using System;
using System.Collections.Generic;

public class Route : IComparable<Route>
{
    public List<string> Path { get; set; } = new List<string>();
    public int TotalCost { get; set; }
    public int Stops => Path.Count;

    public int CompareTo(Route other)
    {
        if (other == null) return 1;

        // Primeiro critério: Menor custo
        int costComparison = TotalCost.CompareTo(other.TotalCost);
        if (costComparison != 0)
            return costComparison; 

        // Segundo critério de desempate: Menos paradas
        return Stops.CompareTo(other.Stops); 
    }
}