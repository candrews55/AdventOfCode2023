namespace AdventOfCode2023;

public class Day1
{
    private static readonly string[] numberWords =
        { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public int Day1Part1(List<string> listOfStrings)
    {
        var total = 0;
        foreach (var line in listOfStrings)
        {
            var firstNumber = string.Empty;
            var lastNumber = string.Empty;
            foreach (var column in line.ToCharArray())
            {
                if (char.IsNumber(column))
                {
                    if (string.IsNullOrWhiteSpace(firstNumber))
                    {
                        firstNumber = column.ToString();
                    }

                    lastNumber = column.ToString();
                }
            }

            total += int.Parse(firstNumber + lastNumber);
        }

        return total;
    }

    public int Day1Part2(List<string> listOfStrings)
    {
        var total = 0;
        foreach (var line in listOfStrings)
        {
            var listOfNumbers = new List<int>();
            var stringNumber = string.Empty;

            foreach (var column in line.ToCharArray())
            {
                if (char.IsNumber(column))
                {
                    listOfNumbers.Add(int.Parse(column.ToString()));
                    stringNumber = string.Empty;
                }
                else
                {
                    stringNumber += column.ToString().ToLower();
                    if (stringNumber.Length < 3) continue;
                    foreach (var numberWord in numberWords)
                    {
                        if (!stringNumber.Contains(numberWord)) continue;
                        listOfNumbers.Add(ConvertToNumber(numberWord));
                        var index = stringNumber.IndexOf(numberWord);
                        var offset = numberWord.Length - 1;
                        stringNumber = stringNumber.Remove(0, index + offset);
                        break;
                    }
                }
            }


            total += (listOfNumbers.First() * 10) + listOfNumbers.Last();
        }

        return total;
    }

    public int ConvertToNumber(string number)
    {
        return number.ToLower() switch
        {
            "one" => 1,
            "two" => 2,
            "three" => 3,
            "four" => 4,
            "five" => 5,
            "six" => 6,
            "seven" => 7,
            "eight" => 8,
            "nine" => 9,
            _ => int.Parse(number)
        };
    }
}