namespace LinqExercises.Exercises;

public class FindTest
{
  [Fact]
  public void FindFirstSevenLetterWord()
  {
      var words = new List<string>
          { "capricious", "berry", "unicorn", "bag", "apple", "festering", "pretzel", "pencil" };
      var found = words.Find(w => w.Length == 7);
      Assert.Equal("unicorn", found);
  }
    
  [Fact(Skip="Unskip when your code has been added")]
  public void NoWaldo()
  {
    var words = new List<string> { "scarf", "sandcastle", "flag", "pretzel", "crow", "key" };
    var found = words.Find(w =>
      w == w // replace with your code .. can collapse into one line above
    );
    Assert.Null(found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindWaldo()
  {
    var words = new List<string> { "noise", "dog", "fair", "house", "waldo", "bucket", "fish" };
    var found = ""; // replace "" with your code
    Assert.Equal("waldo", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void CannotFind3LetterWords()
  {
    var words = new List<string> { "piglet", "porridge", "bear", "blueberry" };
    var found = ""; // replace "" with your code
    Assert.Null(found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void Find13()
  {
    var numbers = new List<int> { 2, 13, 19, 8, 3, 27 };
    var found =  0; // replace 0 with your code
    Assert.Equal(13, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstEvenNumber()
  {
    var numbers = new List<int> { 3, 7, 13, 11, 10, 2, 17 };
    var found =  0; // replace 0 with your code
    Assert.Equal(10, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstMultipleOf3()
  {
    var numbers = new List<int> { 2, 8, 9, 27, 24, 5 };
    var found =  0; // replace 0 with your code
    Assert.Equal(9, found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstWordStartingWithQ()
  {
    var words = new List<string> { "weirdo", "quill", "fast", "quaint", "quitter", "koala" };
    var found =  ""; // replace "" with your code
    Assert.Equal("quill", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstWordEndingWithEr()
  {
    var words = new List<string> { "biggest", "pour", "blight", "finger", "pie", "border" };
    var found =  ""; // replace "" with your code
    Assert.Equal("finger", found);
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void FindFirstNumberGreaterThan20()
  {
    var numbers = new List<int> { 1, 8, 19, 21, 29, 31, 34 };
    var found =  0; // replace 0 with your code
    Assert.Equal(21, found);
  }
}