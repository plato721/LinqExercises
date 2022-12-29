namespace LinqExercises.Exercises;

public class WhereTest
{
    [Fact]
    public void PickOddNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        var odds = numbers.Where(n => n % 2 == 1);
        var expectedNumbers = new List<int> { 1, 3, 5, 7, 9 };
        
        Assert.Equal(expectedNumbers, odds);
    }
}