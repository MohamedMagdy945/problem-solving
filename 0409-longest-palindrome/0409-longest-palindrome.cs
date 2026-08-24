public class Solution
{
    public int LongestPalindrome(string s)
    {
        int[] count = new int[128];

        foreach (char c in s)
        {
            count[c]++;
        }

        int length = 0;
        bool hasOdd = false;

        foreach (int freq in count)
        {
            length += (freq / 2) * 2;

            if (freq % 2 == 1)
                hasOdd = true;
        }

        // One odd-frequency character can be placed in the center.
        if (hasOdd)
            length++;

        return length;
    }
}
