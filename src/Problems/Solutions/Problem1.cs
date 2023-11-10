namespace Problems.Solutions;

public class Problem1
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            for (var j = i + 1; j < nums.Length; j++)
            {
                var next = nums[j];
                if (current + next == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }
}