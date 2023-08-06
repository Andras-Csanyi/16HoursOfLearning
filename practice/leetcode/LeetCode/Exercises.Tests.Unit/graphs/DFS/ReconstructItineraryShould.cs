namespace Exercises.Tests.Unit.graphs.DFS;

using Exercises.graphs.DFS;
using FluentAssertions;
using Xunit;

public class ReconstructItineraryShould
{
    private ReconstructItinerary _sut = new();

    [Fact]
    public void First()
    {
        // Arrange
        IList<IList<string>> input = new List<IList<string>>
        {
            new List<string> { "MUC", "LHR" },
            new List<string> { "JFK", "MUC" },
            new List<string> { "SFO", "SJC" },
            new List<string> { "LHR", "SFO" },
        };
        List<string> expectedResult = new List<string> { "JFK", "MUC", "LHR", "SFO", "SJC" };

        // Act
        IList<string> result = _sut.FindItinerary(input);

        // Assert
        result.Should().Equal(expectedResult);
    }

    [Fact]
    public void Second()
    {
        // Arrange
        IList<IList<string>> input = new List<IList<string>>
        {
            new List<string> { "JFK", "SFO" },
            new List<string> { "JFK", "ATL" },
            new List<string> { "SFO", "ATL" },
            new List<string> { "ATL", "JFK" },
            new List<string> { "ATL", "SFO" },
        };
        List<string> expectedResult = new List<string> { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" };

        // Act
        IList<string> result = _sut.FindItinerary(input);

        // Assert
        result.Should().Equal(expectedResult);
    }

    [Fact]
    public void Third()
    {
        // Arrange
        IList<IList<string>> input = new List<IList<string>>
        {
            new List<string> { "JFK", "KUL" },
            new List<string> { "JFK", "NRT" },
            new List<string> { "NRT", "JFK" },
        };
        List<string> expectedResult = new List<string> { "JFK", "NRT", "JFK", "KUL" };

        // Act
        IList<string> result = _sut.FindItinerary(input);

        // Assert
        result.Should().Equal(expectedResult);
    }
}