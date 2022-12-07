namespace LinqExercises.Exercises;

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

  [Fact(Skip="Unskip when your code has been added")]
  public void NoWaldo()
  {
    var words = new List<string> { "scarf", "sandcastle", "flag", "pretzel", "crow", "key" };
    string? found = null;
    foreach (var word in words)
    {
      if (word == "waldo")
      {
        // Your code here
      }
    }
    Assert.Null(found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindWaldo()
  {
    var words = new List<string> { "noise", "dog", "fair", "house", "waldo", "bucket", "fish" };
    string? found = null;
    
    // Your code here

    Assert.Equal("waldo", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void CannotFind3LetterWords()
  {
    var words = new List<string> { "piglet", "porridge", "bear", "blueberry" };
    string? found = null;
    
    // Your code here
    
    Assert.Null(found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void Find13()
  {
    var numbers = new List<int> { 2, 13, 19, 8, 3, 27 };
    int? found = null;
    
    // Your code here
    
    Assert.Equal(13, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstEvenNumber()
  {
    var numbers = new List<int> { 3, 7, 13, 11, 10, 2, 17 };
    int? found = null;
    
    // Your code here

    Assert.Equal(10, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstMultipleOf3()
  {
    var numbers = new List<int> { 2, 8, 9, 27, 24, 5 };
    int? found = null;
    
    // Your code here

    Assert.Equal(9, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstWordStartingWithQ()
  {
    var words = new List<string> { "weirdo", "quill", "fast", "quaint", "quitter", "koala" };
    string found = null;
    
    // Your code here

    Assert.Equal("quill", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstWordEndingWithEr()
  {
    var words = new List<string> { "biggest", "pour", "blight", "finger", "pie", "border" };
    string? found = null;
    
    // Your code here
    
    Assert.Equal("finger", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstNumberGreaterThan20()
  {
    var numbers = new List<int> { 1, 8, 19, 21, 29, 31, 34 };
    int? found = null;
    
    // Your code here

    Assert.Equal(21, found);
  }
}
