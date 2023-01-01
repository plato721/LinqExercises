namespace LinqExercises.Exercises;

public class WherePatternTest
{
  [Fact]
  public void PickEvenNumbers()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var evens = new List<int>();
    foreach (var number in numbers)
    {
      if (number % 2 == 0) evens.Add(number);
    }
    Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, evens);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickOddNumbers()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var odds = new List<int>();
    foreach (var number in numbers)
    {
      // Your code here
    }
    Assert.Equal(new List<int> { 1, 3, 5, 7, 9 }, odds);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickWordsWithThreeLetters()
  {
    var words = new List<string> { "pill", "bad", "finger", "cat", "blue", "dog", "table", "red" };
    var selected = new List<string>();

    // Your code here

    Assert.Equal(new List<string> { "bad", "cat", "dog", "red" }, selected);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickWordsWithMoreThanThreeLetters()
  {
    var words = new List<string> { "pill", "bad", "finger", "cat", "blue", "dog", "table", "red" };

    var selected = new List<string>();
    // Your code here

    Assert.Equal(new List<string> { "pill", "finger", "blue", "table" }, selected);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickWordsEndingInE()
  {
    var words = new List<string> { "are", "you", "strike", "thinking", "belt", "piece", "warble", "sing", "pipe" };

    var selected = new List<string>();
    // Your code here

    Assert.Equal(new List<string> { "are", "strike", "piece", "warble", "pipe" }, selected);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickWordsEndingInIng()
  {
    var words = new List<string> { "bring", "finger", "drought", "singing", "bingo", "purposeful" };

    var selected = new List<string>();
    // Your code here

    Assert.Equal(new List<string> { "bring", "singing" }, selected);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickWordsContainingE()
  {
    var words = new List<string> { "four", "red", "five", "blue", "pizza", "purple" };

    var selected = new List<string>();
    // Your code here

    Assert.Equal(new List<string> { "red", "five", "blue", "purple" }, selected);
  }

  [Fact(Skip="Remove this when code is complete")]
  public void PickDinosaurs()
  {
    var animals = new List<string> { "tyrannosaurus", "narwhal", "eel", "achillesaurus", "qingxiusaurus" };

    var dinosaurs = new List<string>();
    // Your code here

    Assert.Equal(new List<string> { "tyrannosaurus", "achillesaurus", "qingxiusaurus" }, dinosaurs);
  }
}
