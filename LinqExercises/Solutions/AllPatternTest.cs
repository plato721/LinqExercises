namespace LinqExercises.Solutions;

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

    [Fact]
    public void NotAllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
        var allZeros = true;
        foreach (var number in numbers)
        {
            if (number != 0) allZeros = false;
        }
        Assert.False(allZeros);
    }

    [Fact]
    public void AllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
        var allGone = true;
        foreach (var word in words)
        {
            if (word != "gone") allGone = false;
        }
        Assert.True(allGone);
    }
    
    [Fact]
    public void NotAllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
        var allGone = true;
        foreach (var word in words)
        {
            if (word != "gone") allGone = false;
        }
        Assert.False(allGone);
    }

    [Fact]
    public void AllEmpty()
    {
        var strings = new List<string> { "", "", "", "", "", "", "" };
        var allEmpty = true;
        foreach (var s in strings)
        {
            if (!String.IsNullOrEmpty(s)) allEmpty = false;
        }
        Assert.True(allEmpty);
    }
    
    [Fact]
    public void NotAllEmpty()
    {
        var strings = new List<string> { "", "", "", "Full", "", "", "" };
        var allEmpty = true;
        foreach (var s in strings)
        {
            if (!String.IsNullOrEmpty(s)) allEmpty = false;
        }
        Assert.False(allEmpty);
    }
    
    [Fact]
    public void NotAllUppercase()
    {
        var words = new List<string> { "DOUGHNUT", "CASH", "MAIN", "bOWl", "SMACK", "SAND" };
        var allCaps = true;
        foreach (var word in words)
        {
            if (word.ToUpper() != word) allCaps = false;
        }
        Assert.False(allCaps);
    }

    [Fact]
    public void AllLies()
    {
        var lies = new List<bool> { false, false, false, false };
        var allLies = true;
        foreach (var lie in lies)
        {
            if (lie) allLies = false;
        }
        Assert.True(allLies);
    }

    [Fact]
    public void AllMultiplesOf7()
    {
        var numbers = new List<int> { 42, 14, 35, 49, 28, 56, 21, 7 };
        var allMultiplesOf7 = true;
        foreach (var number in numbers)
        {
            if (number % 7 != 0) allMultiplesOf7 = false;
        }
        Assert.True(allMultiplesOf7);
    }

    [Fact]
    public void NotAll3DigitsLong()
    {
        var numbers = new List<int> { 981, 831, 509, 332, 892, 8999, 110 };
        var all3Digits = true;
        foreach (var number in numbers)
        {
            if (Convert.ToString(number).Length != 3) all3Digits = false;
        }
        Assert.False(all3Digits);
    }

    [Fact]
    public void All4LetterWords()
    {
        var words = new List<string> { "love", "hate", "fire", "bird", "call" };
        var all4Letters = true;
        foreach (var word in words)
        {
            if (word.Length != 4) all4Letters = false;
        }
        Assert.True(all4Letters);
    }
}
