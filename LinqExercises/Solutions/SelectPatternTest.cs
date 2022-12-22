using System.Text.RegularExpressions;

namespace LinqExercises.Solutions;

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
      doubles.Add(number * 2);
    }
    
    Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, doubles);
  }

  [Fact]
  public void Squares()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5 };
    
    var squares = new List<int>();
    foreach (var number in numbers)
    {
      squares.Add(number * number);
    }
    
    Assert.Equal(new List<int> { 1, 4, 9, 16, 25 }, squares);
  }

  [Fact]
  public void Lengths()
  {
    var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };
    
    var lengths = new List<int>();
    foreach (var name in names)
    {
      lengths.Add(name.Length);
    }
    
    Assert.Equal(new List<int> { 5, 3, 7, 5, 3 }, lengths);
  }

  [Fact]
  public void NormalizeZipCodes()
  {
    var numbers = new List<int> { 234, 10, 9119, 38881 };
    
    var zipCodes = new List<string>();
    foreach (var number in numbers)
    {
      var normalized = number.ToString().PadLeft(5, '0');
      zipCodes.Add(normalized);
    }
    
    Assert.Equal(new List<string>{ "00234", "00010", "09119", "38881" }, zipCodes);
  }

  [Fact]
  public void Backwards()
  {
    string ReverseString(string word)
    {
      char[] charArray = word.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
    var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };
    
    var backwards = new List<string>();
    foreach (var name in names)
    {
      backwards.Add(ReverseString(name));
    }
    
    Assert.Equal(new List<string> { "ecila", "bob", "eilrahc", "divad", "eve" }, backwards);
  }

  [Fact]
  public void WordsWithNoVowels()
  {
    var words = new List<string> { "green", "sheep", "travel", "least", "boat" };
    
    var withoutVowels = new List<string>();
    foreach (var word in words)
    {
      var noVowelsWord = Regex.Replace(word, "[aeiou]", "");
      withoutVowels.Add(noVowelsWord);
    }
    
    Assert.Equal(new List<string> { "grn", "shp", "trvl", "lst", "bt" }, withoutVowels);
  }

  [Fact]
  public void TrimLastLetter()
  {
    var animals = new List<string> { "dog", "cat", "mouse", "frog", "platypus" };
    
    var trimmed = new List<string>();
    foreach (var animal in animals)
    {
      trimmed.Add(animal[..^1]);
    }
    
    Assert.Equal(new List<string> { "do", "ca", "mous", "fro", "platypu" }, trimmed);
  }
}
