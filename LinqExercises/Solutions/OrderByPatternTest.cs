namespace LinqExercises.Solutions;

public class OrderByPatternTest
{
  [Fact]
  public void SortAlphabetically()
  {
    var words = new List<string> { "broccoli", "Carrots", "FISH", "Bacon", "candy" };

    var transformed = new List<(string sortKey, string word)>();
    foreach (var word in words)
    {
      transformed.Add((word.ToLower(), word));
    }
    transformed.Sort();

    var sorted = new List<string>();
    foreach (var (sortKey, thing) in transformed)
    {
      sorted.Add(thing);
    }

    var expected = new List<string> { "Bacon", "broccoli", "candy", "Carrots", "FISH" };
    Assert.Equal(expected, sorted);
  }

  [Fact]
  public void SortAlphabeticallyByLastLetter()
  {
    var things = new List<string> { "pill", "box", "glass", "water", "sponge" };

    var transformed = new List<(char sortKey, string thing)>();
    foreach (var thing in things)
    {
      transformed.Add((thing[^1], thing));
    }
    transformed.Sort();

    var sorted = new List<string>();
    foreach (var (sortKey,thing ) in transformed)
    {
      sorted.Add(thing);
    }

    var expected = new List<string> { "sponge", "pill", "water", "glass", "box" };
    Assert.Equal(expected, sorted);
  }

  [Fact]
  public void SortByDistance()
  {
    var distances = new List<string> { "1cm", "9cm", "30cm", "4cm", "2cm" };

    var transformed = new List<(int rawDistance, string distanceWithUnit)>();
    foreach (var distance in distances)
    {
      var withoutUnits = distance.Replace("cm", "");
      var numericDistance = Convert.ToInt32(withoutUnits);
      transformed.Add((numericDistance, distance));
    }
    transformed.Sort();

    var sorted = new List<string>();
    foreach (var (rawDistance, distance) in transformed)
    {
      sorted.Add(distance);
    }

    var expected = new List<string> { "1cm", "2cm", "4cm", "9cm", "30cm" };
    Assert.Equal(expected, sorted);
  }

  [Fact]
  public void SortByLength()
  {
    var words = new List<string> { "heteromorph", "ancyloceratina", "bioengineering", "mathematical", "bug" };

    var transformed = new List<(int length, string word)>();
    foreach (var word in words)
    {
      transformed.Add((word.Length, word));
    }
    transformed.Sort();

    var sorted = new List<string>();
    foreach (var (length, word) in transformed)
    {
      sorted.Add(word);
    }

    var expected = new List<string> { "bug", "heteromorph", "mathematical", "ancyloceratina", "bioengineering" };
    Assert.Equal(expected, sorted);
  }

  [Fact]
  public void SortByProximityToTen()
  {
    var prices = new List<double> { 3.02, 9.91, 17.9, 10.01, 11.0 };

    var transformed = new List<(double proximityToTen, double number)>();
    foreach (var price in prices)
    {
      var proximity = Math.Abs(10.0 - price);
      transformed.Add((proximity, price));
    }
    transformed.Sort();

    var sorted = new List<double>();
    foreach (var (proximityToTen, price) in transformed)
    {
      sorted.Add(price);
    }

    var expected = new List<double> { 10.01, 9.91, 11.0, 3.02, 17.9 };
    Assert.Equal(expected, sorted);
  }

  [Fact]
  public void SortByNumberOfCents()
  {
    var prices = new List<double> { 3.02, 9.91, 7.9, 10.01, 11.0 };

    var transformed = new List<(double cents, double price)>();
    foreach (var price in prices)
    {
      var cents = price - Math.Floor(price);
      transformed.Add((cents, price));
    }
    transformed.Sort();

    var sorted = new List<double>();
    foreach (var (cents, price) in transformed)
    {
      sorted.Add(price);
    }

    var expected = new List<double> { 11.0, 10.01, 3.02, 7.9, 9.91 };
    Assert.Equal(expected, sorted);
  }
}
