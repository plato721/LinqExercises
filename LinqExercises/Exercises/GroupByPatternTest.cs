using System.Collections;

namespace LinqExercises.Exercises;

public class GroupByPatternTest
{
  private record Group<TKey, TValue>(TKey Key) : IGrouping<TKey, TValue>
  {
    private readonly List<TValue> _values = new ();

    public void Add(TValue value) => _values.Add(value);
    public IEnumerator<TValue> GetEnumerator() => _values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
  
  [Fact]
  public void GroupWordsByLength()
  {
    var words = new List<string> { "sue", "alice", "steve", "sally", "adam", "fort", "tops", "dog", "cat" };
    var grouped = new List<Group<int, string>>();
    
    foreach (var word in words)
    {
      if (grouped.Any(g => g.Key == word.Length))
      {
        grouped.First(g => g.Key == word.Length)
          .Add(word);
      }
      else
      {
        var group = new Group<int, string>(word.Length);
        group.Add(word);
        grouped.Add(group);
      }
    }
    
    Assert.Equal(new List<string>{ "sue", "dog", "cat" }, grouped.First(g => g.Key == 3));
    Assert.Equal(new List<string>{ "adam", "fort", "tops" }, grouped.First(g => g.Key == 4));
    Assert.Equal(new List<string>{ "alice", "steve", "sally" }, grouped.First(g => g.Key == 5));
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void GroupNumbersByOddAndEven()
  {
    var numbers = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
    var oddAndEven = new List<Group<int, int>>();
    
    foreach (var number in numbers)
    {
      if (oddAndEven.Any(g => g.Key == number % 2))
      {
        // Your code here
      }
      else
      {
        // Your code here
      }
    }

    var expectedOdd = new List<int> { 1, 1, 3, 5, 13, 21, 55 };
    var expectedEven = new List<int> { 2, 8, 34 };
    
    Assert.Equal(expectedOdd, oddAndEven.Find(g => g.Key == 1));
    Assert.Equal(expectedEven, oddAndEven.Find(g => g.Key == 0));
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void GroupWordsByFirstLetter()
  {
    var words = new List<string> { "ant", "axis", "albatross", "bolt", "badge", "butter", "car", "cdr", "column" };
    var wordsByFirstLettter = new List<Group<char, string>>();
    foreach (var word in words)
    {
      // Your code here
    }
    Assert.Equal(new List<string> { "ant", "axis", "albatross" }, wordsByFirstLettter.Find(g => g.Key == 'a'));
    Assert.Equal(new List<string> { "bolt", "badge", "butter" }, wordsByFirstLettter.Find(g => g.Key == 'b'));
    Assert.Equal(new List<string> { "car", "cdr", "column" }, wordsByFirstLettter.Find(g => g.Key == 'c'));
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void GroupWordsByUniqueness()
  {
    var words = new List<string> { "one", "two", "one", "TWO", "three", "one", "three", "three", "three" };
    var grouped = new List<Group<string, string>>();
    
    // Your code here

    Assert.Equal(new List<string> { "one", "one", "one" }, grouped.Find(g => g.Key == "one"));
    Assert.Equal(new List<string> { "two", "TWO" }, grouped.Find(g => g.Key == "two"));
    Assert.Equal(new List<string> { "three", "three", "three", "three" }, grouped.Find(g => g.Key == "three"));
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void GroupByNumberOfZeros()
  {
    var numbers = new List<int> { 1, 3, 500, 200, 4000, 3000, 10000, 90, 20, 500000 };
    var grouped = new List<Group<int, int>>();

    // Your code here

    Assert.Equal(new List<int> { 1, 3 }, grouped.Find(g => g.Key == 0));
    Assert.Equal(new List<int> { 90, 20 }, grouped.Find(g => g.Key == 1));
    Assert.Equal(new List<int> { 500, 200 }, grouped.Find(g => g.Key == 2));
    Assert.Equal(new List<int> { 4000, 3000 }, grouped.Find(g => g.Key == 3));
    Assert.Equal(new List<int> { 10000 }, grouped.Find(g => g.Key == 4));
    Assert.Equal(new List<int> { 500000 }, grouped.Find(g => g.Key == 5));
  }

  [Fact(Skip="Unskip when your code has been added")]
  public void GroupByOrderOfMagnitude()
  {
    var numbers = new List<int> { 1, 3, 503, 239, 4938, 3932, 19982, 93, 21, 501787 };
    var grouped = new List<Group<int, int>>();
    
    // Your code here

    Assert.Equal(new List<int> { 1, 3 }, grouped.Find(g => g.Key == 1));
    Assert.Equal(new List<int> { 93, 21 }, grouped.Find(g => g.Key == 2));
    Assert.Equal(new List<int> { 503, 239 }, grouped.Find(g => g.Key == 3));
    Assert.Equal(new List<int> { 4938, 3932 }, grouped.Find(g => g.Key == 4));
    Assert.Equal(new List<int> { 19982 }, grouped.Find(g => g.Key == 5));
    Assert.Equal(new List<int> { 501787 }, grouped.Find(g => g.Key == 6));
  }
}
