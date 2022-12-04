namespace LinqExercises.Solutions;

public class AllTest
{
    [Fact]
    public void AllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        var allZeros = numbers.All(n => n == 0);
        Assert.True(allZeros);
    }

    [Fact]
    public void NotAllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
        var allZeros = numbers.All(n => n == 0);
        Assert.False(allZeros);
    }

    [Fact]
    public void AllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
        var allGone = words.All(w => w == "gone");
        Assert.True(allGone);
    }
    
    [Fact]
    public void NotAllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
        var allGone = words.All(w => w == "gone");
        Assert.False(allGone);
    }

    [Fact]
    public void AllEmpty()
    {
        var strings = new List<string> { "", "", "", "", "", "", "" };
        var allEmpty = strings.All(string.IsNullOrEmpty);
        Assert.True(allEmpty);
    }
    
    [Fact]
    public void NotAllEmpty()
    {
        var strings = new List<string> { "", "", "", "Full", "", "", "" };
        var allEmpty = strings.All(string.IsNullOrEmpty);
        Assert.False(allEmpty);
    }
}