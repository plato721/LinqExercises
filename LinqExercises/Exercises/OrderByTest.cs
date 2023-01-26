namespace LinqExercises.Exercises;

public class OrderByTest
{
  [Fact(Skip = "Remove this when your code is in place")]
  public void SortAlphabetically()
  {
    var words = new List<string> { "broccoli", "Carrots", "FISH", "Bacon", "candy" };

    var sorted = words.OrderBy(w => w.ToLowerInvariant()).ToList();

    var expected = new List<string> { "Bacon", "broccoli", "candy", "Carrots", "FISH" };
    Assert.Equal(expected, sorted);
  }

  [Fact(Skip = "Remove this when your code is in place")]
  public void SortAlphabeticallyByLastLetter()
  {
    var things = new List<string> { "pill", "box", "glass", "water", "sponge" };

    var sorted = things.OrderBy(t =>
      1 // Your code here - replace '1' - can collapse into line above
    ).ToList();

    var expected = new List<string> { "sponge", "pill", "water", "glass", "box" };
    Assert.Equal(expected, sorted);
  }

  [Fact(Skip = "Remove this when your code is in place")]
  public void SortByDistance()
  {
    var distances = new List<string> { "1cm", "9cm", "30cm", "4cm", "2cm" };

    var sorted = distances.OrderBy(d =>
      1 // Your code here - replace '1' - can collapse into line above
    ).ToList();

    var expected = new List<string> { "1cm", "2cm", "4cm", "9cm", "30cm" };
    Assert.Equal(expected, sorted);
  }

  [Fact(Skip = "Remove this when your code is in place")]
  public void SortByLength()
  {
    var words = new List<string> { "heteromorph", "ancyloceratina", "bioengineering", "mathematical", "bug" };

    var sorted = words.OrderBy(w =>
      1 // Your code here - replace '1' - can collapse into line above
    ).ToList();

    var expected = new List<string> { "bug", "heteromorph", "mathematical", "ancyloceratina", "bioengineering" };
    Assert.Equal(expected, sorted);
  }

  [Fact(Skip = "Remove this when your code is in place")]
  public void SortByProximityToTen()
  {
    var prices = new List<double> { 3.02, 9.91, 17.9, 10.01, 11.0 };

    var sorted = prices.OrderBy(p =>
      1 // Your code here - replace '1' - can collapse into line above
    ).ToList();

    var expected = new List<double> { 10.01, 9.91, 11.0, 3.02, 17.9 };
    Assert.Equal(expected, sorted);
  }

  [Fact(Skip = "Remove this when your code is in place")]
  public void SortByNumberOfCents()
  {
    var prices = new List<double> { 3.02, 9.91, 7.9, 10.01, 11.0 };

    var sorted = prices.OrderBy(p =>
      1 // Your code here - replace '1' - can collapse into line above
    ).ToList();

    var expected = new List<double> { 11.0, 10.01, 3.02, 7.9, 9.91 };
    Assert.Equal(expected, sorted);
  }
}
