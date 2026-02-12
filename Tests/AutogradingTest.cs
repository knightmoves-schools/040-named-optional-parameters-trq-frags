namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Replace_Both_Constructors_With_A_Single_Constructor_That_Takes_A_Required_FirstName_And_LastName_With_An_Optional_Age_That_Is_Set_To_14_If_It_Is_Not_Provided()
    {
        var personWithAge = new Person(firstName: "mary", lastName: "smith", age: 5);

        Assert.Equal("mary", personWithAge.FirstName);
        Assert.Equal("smith", personWithAge.LastName);
        Assert.Equal(5, personWithAge.Age);

        var personWithoutAge = new Person(firstName: "mary", lastName: "smith");

        Assert.Equal("mary", personWithoutAge.FirstName);
        Assert.Equal("smith", personWithoutAge.LastName);
        Assert.Equal(14, personWithoutAge.Age);
    }
}
