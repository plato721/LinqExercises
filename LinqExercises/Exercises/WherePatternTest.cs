namespace LinqExercises.Exercises;

public class WherePatternTest
{
    [Fact]
    public void PickOddNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var odds = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 2 == 1) odds.Add(number);
        }

        var expectedNumbers = new List<int> { 1, 3, 5, 7, 9 };
        Assert.Equal(expectedNumbers, odds);
    }
}