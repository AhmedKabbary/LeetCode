using Problems.Solutions;

namespace Problems.Tests.Tests;

public class Problem3Tests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    [InlineData("", 0)]
    [InlineData("au", 2)]
    public void Test1(String str, int expected)
    {
        // Arrange
        var sut = new Problem3();

        // Act
        var actual = sut.LengthOfLongestSubstring(str);

        // Assert
        Assert.Equal(expected, actual);
    }
}