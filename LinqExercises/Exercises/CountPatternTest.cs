namespace LinqExercises.Exercises;

public class CountPatternTest
{
    [Fact]
    public void CountWordsWithE()
    {
        var words = new List<string> { "thing", "phone", "bark", "belt", "shoe", "bath" };
        var tally = 0;
        foreach (var word in words)
        {
            if (word.Contains('e')) tally++;
        }
        Assert.Equal(3, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountNumbersGreaterThan17()
    {
        var numbers = new List<int> { 9, 18, 12, 17, 1, 3, 99 };
        var tally = 0;
        foreach (var number in numbers)
        {
            // Your code here
        }
        Assert.Equal(2, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountWordsThatAreUppercase()
    {
        var words = new List<string> { "trousers", "SOCKS", "sweater", "Cap", "SHOE", "TIE" };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(3, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountWordsEndingInIng()
    {
        var words = new List<string> { "thought", "brake", "shin", "juice", "trash" };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(0, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountEventNumbers()
    {
        var numbers = new List<int> { 9, 2, 1, 3, 18, 39, 71, 4, 6 };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(4, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountMultiplesOf5()
    {
        var numbers = new List<int> { 2, 5, 19, 25, 35, 67 };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(3, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountRoundPrices()
    {
        var prices = new List<double> { 1.0, 3.9, 5.99, 18.5, 20.0 };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(2, tally);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void CountFourLetterWords()
    {
        var words = new List<string> { "bake", "bark", "corn", "apple", "wart", "bird", "umbrella", "fart" };
        var tally = 0;
        
        // Your code here
        
        Assert.Equal(6, tally);
    }
}