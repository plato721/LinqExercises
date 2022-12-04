namespace LinqExercises;

public class MapPatternTest
{
    [Fact]
    public void Capitalize()
    {
        string CapitalizeWord(string word)
        {
            if (word.Length == 0) return word;
            if (word.Length == 1) return word.ToUpper();

            return char.ToUpper(word[0]) + word.Substring(1);
        }
        
        var names = new List<string> { "alice", "bob", "charlie" };
        var capitalizedNames = new List<string>();
        
        foreach (var name in names)
        {
            capitalizedNames.Add(CapitalizeWord(name));
        }

        var expectedNames = new List<string> { "Alice", "Bob", "Charlie" };
        Assert.Equal(capitalizedNames, expectedNames);
    }
}