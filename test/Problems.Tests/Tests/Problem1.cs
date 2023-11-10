namespace Problems.Tests.Tests;

public class Problem1Tests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test1(int[] nums, int target, int[] expected)
    {
        // Arrange
        var sut = new Solutions.Problem1();

        // Act
        var actual = sut.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> GetData()
    {
        yield return new Object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } };
        yield return new Object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } };
        yield return new Object[] { new[] { 3, 3 }, 6, new[] { 0, 1 } };
    }
}