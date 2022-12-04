namespace LinqExercises.Exercises;

public class AllTest
{
    [Fact]
    public void AllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        var allZeros = numbers.All(n => n == 0);
        Assert.True(allZeros);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void NotAllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
        var allZeros = false; // replace with your code
        Assert.False(allZeros);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
        var allGone = false; // replace with your code;
        Assert.True(allGone);
    }
    
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
        var allGone = false; // replace with your code;
        Assert.False(allGone);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllEmpty()
    {
        var strings = new List<string> { "", "", "", "", "", "", "" };
        var allEmpty = false; // replace with your code;
        Assert.True(allEmpty);
    }
    
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllEmpty()
    {
        var strings = new List<string> { "", "", "", "Full", "", "", "" };
        var allEmpty = false; // replace with your code;
        Assert.False(allEmpty);
    }
    
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllUppercase()
    {
        var words = new List<string> { "DOUGHNUT", "CASH", "MAIN", "bOWl", "SMACK", "SAND" };
        var allCaps = false; // replace with your code;
        Assert.False(allCaps);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllLies()
    {
        var lies = new List<bool> { false, false, false, false };
        var allLies = false; // replace with your code;
        Assert.True(allLies);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllMultiplesOf7()
    {
        var numbers = new List<int> { 42, 14, 35, 49, 28, 56, 21, 7 };
        var allMultiplesOf7 = false; // replace with your code;
        Assert.True(allMultiplesOf7);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void NotAll3DigitsLong()
    {
        var numbers = new List<int> { 981, 831, 509, 332, 892, 8999, 110 };
        var all3Digits = false; // replace with your code;
        Assert.False(all3Digits);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void All4LetterWords()
    {
        var words = new List<string> { "love", "hate", "fire", "bird", "call" };
        var all4Letters = false; // replace with your code;
        Assert.True(all4Letters);
    }
}