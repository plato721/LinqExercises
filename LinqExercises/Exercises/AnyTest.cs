namespace LinqExercises.Exercises;

public class AnyTest
{
    [Fact]
    public void HasAtLeastOneZero()
    {
        var numbers = new List<int> { 2, 0, 9, 3, 0, 1 };
        var hasZero = numbers.Any(n => n == 0);
        Assert.True(hasZero);
    }

    [Fact]
    public void DoesNotHaveAnyZeros()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var hasZero = numbers.Any(n =>
            n == n // replace with your code .. can collapse into one line above
        );
        Assert.False(hasZero);
    }

    [Fact]
    public void HasAtLeastOneAlice()
    {
        var names = new List<string> { "Bill", "Bob", "Burton", "Alice", "Brandon" };
        var hasAlice = false; // replace with your code;
        Assert.True(hasAlice);
    }

    [Fact]
    public void NoAlices()
    {
        var names = new List<string> { "Chuck", "Charlene", "Cory", "Chris", "Carl" };
        var hasAlice = false; // replace with your code;
        Assert.False(hasAlice);
    }

    [Fact]
    public void HasAMultiWordPhrase()
    {
        var phrases = new List<string> { "Sure!", "OK.", "I have no idea.", "Really?Whatever." };
        var hasMultiwordPhrase = false; // replace with your code;
        Assert.True(hasMultiwordPhrase);
    }

    [Fact]
    public void NoMonkeys()
    {
        var animals = new List<string> { "elephant", "hippo", "jaguar", "python" };
        var hasMonkeys = false; // replace with your code;
        Assert.False(hasMonkeys);
    }

    [Fact]
    public void NoMultiplesOfFive()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var multiplesOf5 = false; // replace with your code;
        Assert.False(multiplesOf5);
    }
}