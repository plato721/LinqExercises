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

    [Fact]
    public void NotAllZeros()
    {
        var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
        var allZeros = false; // replace with your code
        Assert.False(allZeros);
    }

    [Fact]
    public void AllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
        var allGone = false; // replace with your code;
        Assert.True(allGone);
    }
    
    [Fact]
    public void NotAllGone()
    {
        var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
        var allGone = false; // replace with your code;
        Assert.False(allGone);
    }

    [Fact]
    public void AllEmpty()
    {
        var strings = new List<string> { "", "", "", "", "", "", "" };
        var allEmpty = false; // replace with your code;
        Assert.True(allEmpty);
    }
    
    [Fact]
    public void NotAllEmpty()
    {
        var strings = new List<string> { "", "", "", "Full", "", "", "" };
        var allEmpty = false; // replace with your code;
        Assert.False(allEmpty);
    }
}