namespace LinqExercises.Solutions;

public class AggregatePatternTest
{
  [Fact]
  public void SumAListOfNumbers()
  {
    var numbers = new List<int> { 32, 1, 21, 5, 81, 333 };
    var result = 0;
    foreach (var number in numbers)
    {
      result += number;
    }
    Assert.Equal(473, result);
  }

  [Fact]
  public void SubtractListOfNumbers()
  {
    var numbers = new List<int> { 28, 12, 38, 1, 91 };
    var result = 0;
    foreach (var number in numbers)
    {
      result -= number;
    }
    Assert.Equal(-170, result);
  }

  [Fact]
  public void MultiplyListOfNumber()
  {
    var numbers = new List<int> { 2, 3, 5, 7 };
    var result = 1;
    foreach (var number in numbers)
    {
      result *= number;
    }
    Assert.Equal(result, 210);
  }

  [Fact]
  public void CapitalizeKeywordsInPhraseOneFishTwoFishRedFishBlueFish()
  {
    var keywords = new List<string> { "fish", "blue" };
    var result = "one fish two fish red fish blue fish";
    foreach (var keyword in keywords)
    {
      result = result.Replace(keyword, keyword.ToUpper());
    }
    Assert.Equal("one FISH two FISH red FISH BLUE FISH", result);
  }

  [Fact]
  public void Divide560ByABunchOfNumbers()
  {
    var numbers = new List<int>() { 2, 2, 2, 5, 7 };
    var result = 560;
    foreach (var number in numbers)
    {
      result /= number;
    }
    Assert.Equal(2, result);
  }

  [Fact]
  public void SubtractSmallestValuesFrom100()
  {
    var elements = new List<List<int>>
    {
      new() { 8, 5, 3 },
      new() { 1, 9, 11 },
      new() { 4, 7, 2 },
      new() { 19, 34, 6 }
    };
    var result = 100;
    foreach (var element in elements)
    {
      result -= element.Min();
    }
    Assert.Equal(88, result);
  }

  [Fact]
  public void AddAllTheSecondValuesTogether()
  {
    var elements = new List<List<object>>
    {
      new() { "a", 1 },
      new() { "b", 9 },
      new() { "c", 21 }
    };
    var result = 0;
    foreach (var element in elements)
    {
      result += (int)element[1];
    }
    Assert.Equal(31, result);
  }
}