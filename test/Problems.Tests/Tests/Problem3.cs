using Problems.Solutions;

namespace Problems.Tests.Tests;

public class Problem3Tests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test1(String str, int expected)
    {
        // Arrange
        var sut = new Problem3();

        // Act
        var actual = sut.LengthOfLongestSubstring(str);

        // Assert
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> GetData()
    {
        yield return new Object[] { "abcabcbb", 3 };
        yield return new Object[] { "bbbbb", 1 };
        yield return new Object[] { "pwwkew", 3 };
        yield return new Object[] { " ", 1 };
        yield return new Object[] { "", 0 };
        yield return new Object[] { "au", 2 };
    }
}