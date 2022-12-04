namespace LinqExercises.Exercises;

public class AllPatternTest
{
    [Fact]
    public void AllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        var allZeros = true;
        foreach (var number in numbers)
        {
            if (number != 0) allZeros = false;
        }
        Assert.True(allZeros);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void NotAllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
        var allZeros = true;
        foreach (var number in numbers)
        {
            // Your code goes here
        }
        Assert.False(allZeros);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
        var allGone = true;
        // Your code goes here
        Assert.True(allGone);
    }
    
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
        var allGone = true;
        // Your code goes here
        Assert.False(allGone);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllEmpty()
    {
        var strings = new List<string> { "", "", "", "", "", "", "" };
        var allEmpty = true;
        // Your code goes here
        Assert.True(allEmpty);
    }
    
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllEmpty()
    {
        var strings = new List<string> { "", "", "", "Full", "", "", "" };
        var allEmpty = true;
        // Your code goes here
        Assert.False(allEmpty);
    }
    
        
    [Fact(Skip="Remove this when code is complete")]
    public void NotAllUppercase()
    {
        var words = new List<string> { "DOUGHNUT", "CASH", "MAIN", "bOWl", "SMACK", "SAND" };
        var allCaps = true;
        // Your code goes here
        Assert.False(allCaps);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllLies()
    {
        var lies = new List<bool> { false, false, false, false };
        var allLies = true;
        // Your code goes here
        Assert.True(allLies);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void AllMultiplesOf7()
    {
        var numbers = new List<int> { 42, 14, 35, 49, 28, 56, 21, 7 };
        var allMultiplesOf7 = true;
        // Your code goes here
        Assert.True(allMultiplesOf7);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void NotAll3DigitsLong()
    {
        var numbers = new List<int> { 981, 831, 509, 332, 892, 8999, 110 };
        var all3Digits = true;
        // Your code goes here
        Assert.False(all3Digits);
    }

    [Fact(Skip="Remove this when code is complete")]
    public void All4LetterWords()
    {
        var words = new List<string> { "love", "hate", "fire", "bird", "call" };
        var all4Letters = true;
        // Your code goes here
        Assert.True(all4Letters);
    }
}