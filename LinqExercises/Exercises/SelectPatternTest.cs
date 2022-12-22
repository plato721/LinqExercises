using System.Text.RegularExpressions;

namespace LinqExercises.Exercises;

public class SelectPatternTest
{
  [Fact]
  public void Capitalize()
  {
    var names = new List<string> { "alice", "bob", "charlie" };
    
    var capitalizedNames = new List<string>();
    foreach (var name in names)
    {
      var capitalizedName = name[..1].ToUpper() + name[1..]; 
      capitalizedNames.Add(capitalizedName);
    }
    
    var expectedNames = new List<string> { "Alice", "Bob", "Charlie" };
    Assert.Equal(capitalizedNames, expectedNames);
  }

  [Fact]
  public void Doubles()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5 };
    
    var doubles = new List<int>();
    foreach (var number in numbers)
    {
      // Your code here
    }
    
    Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, doubles);
  }

  [Fact]
  public void Squares()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5 };
    
    var squares = new List<int>();
    
    // Your code here
    
    Assert.Equal(new List<int> { 1, 4, 9, 16, 25 }, squares);
  }

  [Fact]
  public void Lengths()
  {
    var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };
    
    var lengths = new List<int>();

    // Your code here
    
    Assert.Equal(new List<int> { 5, 3, 7, 5, 3 }, lengths);
  }

  [Fact]
  public void NormalizeZipCodes()
  {
    var numbers = new List<int> { 234, 10, 9119, 38881 };
    
    var zipCodes = new List<string>();

    // Your code here
    
    Assert.Equal(new List<string>{ "00234", "00010", "09119", "38881" }, zipCodes);
  }

  [Fact]
  public void Backwards()
  {
    var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };
    
    var backwards = new List<string>();

    // Your code here
    
    Assert.Equal(new List<string> { "ecila", "bob", "eilrahc", "divad", "eve" }, backwards);
  }

  [Fact]
  public void WordsWithNoVowels()
  {
    var words = new List<string> { "green", "sheep", "travel", "least", "boat" };
    
    var withoutVowels = new List<string>();

    // Your code here
    
    Assert.Equal(new List<string> { "grn", "shp", "trvl", "lst", "bt" }, withoutVowels);
  }

  [Fact]
  public void TrimLastLetter()
  {
    var animals = new List<string> { "dog", "cat", "mouse", "frog", "platypus" };
    
    var trimmed = new List<string>();

    // Your code here
    
    Assert.Equal(new List<string> { "do", "ca", "mous", "fro", "platypu" }, trimmed);
  }
}