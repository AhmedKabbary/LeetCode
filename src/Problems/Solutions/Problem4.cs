namespace Problems.Solutions;

public class Problem4
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] merged = new int[nums1.Length + nums2.Length];

        int i1 = 0, i2 = 0, i3 = 0;
        while (true)
        {
            int? num1 = nums1.GetValueOrNull(i1);
            int? num2 = nums2.GetValueOrNull(i2);

            if (num1 is null && num2 is null)
                break;

            if (num1 is null)
            {
                merged[i3] = num2!.Value;
                i2++;
            }
            else if (num2 is null)
            {
                merged[i3] = num1!.Value;
                i1++;
            }
            else
            {
                if (num1.Value < num2.Value)
                {
                    merged[i3] = num1.Value;
                    i1++;
                }
                else
                {
                    merged[i3] = num2.Value;
                    i2++;
                }
            }

            i3++;
        }

        if (merged.Length % 2 == 0)
        {
            int e1 = (merged.Length - 1) / 2;
            int e2 = merged.Length / 2;

            return (merged[e1] + merged[e2]) / 2.0;
        }

        return merged[merged.Length / 2];
    }
}

public static class Extensions
{
    public static int? GetValueOrNull(this int[] arr, int index)
    {
        if (index >= 0 && index < arr.Length)
        {
            return arr[index];
        }

        return null;
    }
}