namespace LinqExercises.Solutions;

public class FindPatternTest
{
  [Fact]
  public void FindFirstSevenLetterWord()
  {
    var words = new List<string>
      { "capricious", "berry", "unicorn", "bag", "apple", "festering", "pretzel", "pencil" };
    string? found = null;
    foreach (var word in words)
    {
      if (word.Length == 7)
      {
        found = word;
        break;
      }
    }
    Assert.Equal("unicorn", found);
  }

  [Fact]
  public void NoWaldo()
  {
    var words = new List<string> { "scarf", "sandcastle", "flag", "pretzel", "crow", "key" };
    string? found = null;
    foreach (var word in words)
    {
      if (word == "waldo")
      {
        found = word;
        break;
      }
    }
    Assert.Null(found);
  }

  [Fact]
  public void FindWaldo()
  {
    var words = new List<string> { "noise", "dog", "fair", "house", "waldo", "bucket", "fish" };
    string? found = null;
    foreach (var word in words)
    {
      if (word == "waldo")
      {
        found = word;
        break;
      }
    }
    Assert.Equal("waldo", found);
  }

  [Fact]
  public void CannotFind3LetterWords()
  {
    var words = new List<string> { "piglet", "porridge", "bear", "blueberry" };
    string? found = null;
    foreach (var word in words)
    {
      if (word.Length == 3)
      {
        found = word;
        break;
      }
    }
    Assert.Null(found);
  }

  [Fact]
  public void Find13()
  {
    var numbers = new List<int> { 2, 13, 19, 8, 3, 27 };
    int? found = null;
    foreach (var number in numbers)
    {
      if (number == 13)
      {
        found = number;
        break;
      }
    }
    Assert.Equal(13, found);
  }

  [Fact]
  public void FindFirstEvenNumber()
  {
    var numbers = new List<int> { 3, 7, 13, 11, 10, 2, 17 };
    int? found = null;
    foreach (var number in numbers)
    {
      if (number % 2 == 0)
      {
        found = number;
        break;
      }
    }
    Assert.Equal(10, found);
  }

  [Fact]
  public void FindFirstMultipleOf3()
  {
    var numbers = new List<int> { 2, 8, 9, 27, 24, 5 };
    int? found = null;
    foreach (var number in numbers)
    {
      if (number % 3 == 0)
      {
        found = number;
        break;
      }
    }
    Assert.Equal(9, found);
  }

  [Fact]
  public void FindFirstWordStartingWithQ()
  {
    var words = new List<string> { "weirdo", "quill", "fast", "quaint", "quitter", "koala" };
    string found = null;
    foreach (var word in words)
    {
      if (word.StartsWith('q'))
      {
        found = word;
        break;
      }
    }
    Assert.Equal("quill", found);
  }

  [Fact]
  public void FindFirstWordEndingWithEr()
  {
    var words = new List<string> { "biggest", "pour", "blight", "finger", "pie", "border" };
    string? found = null;
    foreach (var word in words)
    {
      if (word.EndsWith("er"))
      {
        found = word;
        break;
      }
    }
    Assert.Equal("finger", found);
  }

  [Fact]
  public void FindFirstNumberGreaterThan20()
  {
    var numbers = new List<int> { 1, 8, 19, 21, 29, 31, 34 };
    int? found = null;
    foreach (var number in numbers)
    {
      if (number > 20)
      {
        found = number;
        break;
      }
    }
    Assert.Equal(21, found);
  }
}
