using Problems.Solutions;

namespace Problems.Tests.Tests;

public class Problem2Tests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test1(Problem2.ListNode l1, Problem2.ListNode l2, Problem2.ListNode expected)
    {
        // Arrange
        var sut = new Problem2();

        // Act
        var actual = sut.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(expected, actual, new Problem2.ListNodeComparer());
    }

    public static IEnumerable<Object[]> GetData()
    {
        yield return new Object[]
        {
            new Problem2.ListNode
            {
                val = 2, next = new Problem2.ListNode { val = 4, next = new Problem2.ListNode { val = 3 } }
            },
            new Problem2.ListNode
            {
                val = 5, next = new Problem2.ListNode { val = 6, next = new Problem2.ListNode { val = 4 } }
            },
            new Problem2.ListNode
            {
                val = 7, next = new Problem2.ListNode { val = 0, next = new Problem2.ListNode { val = 8 } }
            }
        };

        yield return new Object[] { new Problem2.ListNode(0), new Problem2.ListNode(0), new Problem2.ListNode(0) };

        yield return new Object[]
        {
            new Problem2.ListNode
            {
                val = 9,
                next = new Problem2.ListNode
                {
                    val = 9,
                    next = new Problem2.ListNode
                    {
                        val = 9,
                        next =
                            new Problem2.ListNode
                            {
                                val = 9,
                                next =
                                    new Problem2.ListNode
                                    {
                                        val = 9,
                                        next =
                                            new Problem2.ListNode { val = 9, next = new Problem2.ListNode { val = 9 } }
                                    }
                            }
                    }
                }
            },
            new Problem2.ListNode
            {
                val = 9,
                next = new Problem2.ListNode
                {
                    val = 9, next = new Problem2.ListNode { val = 9, next = new Problem2.ListNode { val = 9 } }
                }
            },
            new Problem2.ListNode
            {
                val = 8,
                next = new Problem2.ListNode
                {
                    val = 9,
                    next = new Problem2.ListNode
                    {
                        val = 9,
                        next = new Problem2.ListNode
                        {
                            val = 9,
                            next = new Problem2.ListNode
                            {
                                val = 0,
                                next = new Problem2.ListNode
                                {
                                    val = 0,
                                    next = new Problem2.ListNode
                                    {
                                        val = 0, next = new Problem2.ListNode { val = 1 }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}