using AdventOfCode2023;
using Xunit.Abstractions;

namespace TestAdventOfCode;

public class Day1Tests
{
    private readonly Day1 _day1 = new();
    private readonly ITestOutputHelper _testOutputHelper;

    public Day1Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }


    [Fact]
    public void ShouldGet142()
    {
        var path = Path.Combine(UsefulConstants.DataFilesPath, "Day1Part1ExampleData.txt");
        var testValues = File.ReadAllLines(path);
        var results = _day1.Day1Part1(testValues.ToList());
        Assert.Equal(142, results);
    }

    [Fact]
    public void Day1Part1()
    {
        var path = Path.Combine(UsefulConstants.DataFilesPath, "Day1Data.txt");
        var testValues = File.ReadAllLines(path);
        var results = _day1.Day1Part1(testValues.ToList());
        _testOutputHelper.WriteLine(results.ToString());
        Assert.Equal(53921, results);
    }
    
    [Fact]
    public void ShouldGet281()
    {
        var path = Path.Combine(UsefulConstants.DataFilesPath, "Day1Part2ExampleData.txt");
        var testValues = File.ReadAllLines(path);
        var results = _day1.Day1Part2(testValues.ToList());
        Assert.Equal(281, results);
    }
    
    [Fact]
    public void Day1Part2()
    {
        var path = Path.Combine(UsefulConstants.DataFilesPath, "Day1Data.txt");
        var testValues = File.ReadAllLines(path);
        var results = _day1.Day1Part2(testValues.ToList());
        _testOutputHelper.WriteLine(results.ToString());
        Assert.Equal(54676, results);
    }
    
}