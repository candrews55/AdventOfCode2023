using AdventOfCode2023;

namespace TestAdventOfCode;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var class1 = new Class1();
        var test = class1.Test();
        Assert.Equal("Hello", test);
    }
}