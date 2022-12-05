namespace LinqExercises.Exercises;

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

    [Fact(Skip="Unskip when your code has been added")]
    public void DoesNotHaveAnyZeros()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var hasZero = false;
        foreach (var number in numbers)
        {
            // your code here
        }
        Assert.False(hasZero);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void HasAtLeastOneAlice()
    {
        var names = new List<string> { "Bill", "Bob", "Burton", "Alice", "Brandon" };
        var hasAlice = false;
        
        // your code here

        Assert.True(hasAlice);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void NoAlices()
    {
        var names = new List<string> { "Chuck", "Charlene", "Cory", "Chris", "Carl" };
        var hasAlice = false;
        foreach (var name in names)

        // your code here

        Assert.False(hasAlice);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void HasAMultiWordPhrase()
    {
        var phrases = new List<string> { "Sure!", "OK.", "I have no idea.", "Really?Whatever." };
        var hasMultiwordPhrase = false;
        
        // your code here
        
        Assert.True(hasMultiwordPhrase);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void NoMonkeys()
    {
        var animals = new List<string> { "elephant", "hippo", "jaguar", "python" };
        var hasMonkeys = false;
        
        // your code here
        
        Assert.False(hasMonkeys);
    }

    [Fact(Skip="Unskip when your code has been added")]
    public void NoMultiplesOfFive()
    {
        var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
        var multiplesOf5 = false;
        
        // your code here
        
        Assert.False(multiplesOf5);
    }
}
