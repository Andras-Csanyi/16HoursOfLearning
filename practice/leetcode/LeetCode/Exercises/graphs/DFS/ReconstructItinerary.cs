namespace Exercises.graphs.DFS;

public class ReconstructItinerary
{
    private Dictionary<string, List<string>?> flights = new Dictionary<string, List<string>?>();
    private Dictionary<string, List<string>?> flightsTracker = new Dictionary<string, List<string>?>();
    private List<string> result = new List<string>();
    private int flightsCounter;

    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        flightsCounter = tickets.Count;
        // put it into a dictionary for better reach
        for (int i = 0; i < tickets.Count; i++)
        {
            if (!flights.ContainsKey(tickets[i][0]))
            {
                flights.Add(tickets[i][0], new List<string> { tickets[i][1] });
            }
            else
            {
                flights[tickets[i][0]].Add(tickets[i][1]);
            }
        }

        DFS("JFK", "");

        return result;
    }

    private void DFS(string currentAirport, string previousAirport)
    {
        // backtracking
        // if we were here already as many times as the tickets allow us we leave
        if (!string.IsNullOrEmpty(previousAirport)
            && flightsTracker.Any()
            && flightsTracker.ContainsKey(previousAirport)
            && flightsTracker[previousAirport].Contains(currentAirport)
            && flightsTracker[previousAirport].Count(p => p == currentAirport)
            == flightsTracker[previousAirport].Count(p => p == currentAirport))
        {
            return;
        }

        flightsCounter--;

        // remove the from airport to airport pair from the list for tracking
        if (!flightsTracker.ContainsKey(previousAirport))
        {
            flightsTracker.Add(previousAirport, new List<string>());
        }
        else
        {
            flightsTracker[previousAirport].Add(currentAirport);
        }

        result.Add(currentAirport);

        flights.TryGetValue(currentAirport, out List<string>? possibleDestinations);

        // if no route from where I am
        if (possibleDestinations == null || !possibleDestinations.Any())
        {
            // going back
            if (flightsCounter > 0)
            {
                result.RemoveAt(result.Count - 1);
            }

            return;
        }

        possibleDestinations.Sort();
        foreach (string possibleDestination in possibleDestinations)
        {
            DFS(possibleDestination, currentAirport);
        }
    }
}