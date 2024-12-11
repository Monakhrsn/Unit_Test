using MainApp.Helpers;

namespace MainApp.Tests.Helpers;

public class UniqueIdentifierGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        // act
        string id = UniqueIdentifierGenerator.Generate();
        
        // assert
        Assert.False(string.IsNullOrEmpty(id));
        Assert.True(Guid.TryParse(id, out _));
    }
}