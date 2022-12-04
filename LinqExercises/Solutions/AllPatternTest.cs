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
}