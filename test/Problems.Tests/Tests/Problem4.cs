using Problems.Solutions;

namespace Problems.Tests.Tests;

public class Problem4Tests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test1(int[] nums1, int[] nums2, double expected)
    {
        // Arrange
        var sut = new Problem4();

        // Act
        var actual = sut.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> GetData()
    {
        yield return new Object[] { new[] { 1, 3 }, new[] { 2 }, 2 };
        yield return new Object[] { new[] { 1, 2 }, new[] { 3, 4 }, 2.5 };
    }
}