namespace LinqExercises.Solutions;

public class AnyPatternTest
{
    [Fact]
    public void HasAtLeastOneZero()
    {
        var numbers = new List<int> { 2, 0, 9, 3, 0, 1 };
        var hasZero = false;
        foreach (var number in numbers)
        {
            if (number == 0) hasZero = true;
        }
        Assert.True(hasZero);
    }

    [Fact]
    public void DoesNotHaveAnyZeros()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var hasZero = false;
        foreach (var number in numbers)
        {
            if (number == 0) hasZero = true;
        }
        Assert.False(hasZero);
    }

    [Fact]
    public void HasAtLeastOneAlice()
    {
        var names = new List<string> { "Bill", "Bob", "Burton", "Alice", "Brandon" };
        var hasAlice = false;
        foreach (var name in names)
        {
            if (names.Contains("Alice")) hasAlice = true;
        }
        Assert.True(hasAlice);
    }

    [Fact]
    public void NoAlices()
    {
        var names = new List<string> { "Chuck", "Charlene", "Cory", "Chris", "Carl" };
        var hasAlice = false;
        foreach (var name in names)
        {
            if (names.Contains("Alice")) hasAlice = true;
        }
        Assert.False(hasAlice);
    }

    [Fact]
    public void HasAMultiWordPhrase()
    {
        var phrases = new List<string> { "Sure!", "OK.", "I have no idea.", "Really?Whatever." };
        var hasMultiwordPhrase = false;
        foreach (var phrase in phrases)
        {
            if (phrase.Contains(" ")) hasMultiwordPhrase = true;
        }
        Assert.True(hasMultiwordPhrase);
    }

    [Fact]
    public void NoMonkeys()
    {
        var animals = new List<string> { "elephant", "hippo", "jaguar", "python" };
        var hasMonkeys = false;
        foreach (var animal in animals)
        {
            if (animal == "monkey") hasMonkeys = true;
        }
        Assert.False(hasMonkeys);
    }

    [Fact]
    public void NoMultiplesOfFive()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var multiplesOf5 = false;
        foreach (var number in numbers)
        {
            if (number % 5 == 0) multiplesOf5 = true;
        }
        Assert.False(multiplesOf5);
    }
}
