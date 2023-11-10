namespace Problems.Solutions;

public class Problem3
{
    public int LengthOfLongestSubstring(String s)
    {
        int lengthOfLongestSubstring = 0;

        int left = 0;
        int right = 0;

        var set = new HashSet<char>();
        for (; right < s.Length; right++)
        {
            char c = s[right];
            bool exists = set.Contains(c);
            if (exists)
            {
                while (true)
                {
                    char oldChar = s[left];

                    set.Remove(oldChar);
                    left++;

                    if (oldChar == c) break;
                }
            }

            set.Add(c);
            lengthOfLongestSubstring = Math.Max(lengthOfLongestSubstring, (right - left) + 1);
        }

        return lengthOfLongestSubstring;
    }
}