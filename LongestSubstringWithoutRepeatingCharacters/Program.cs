public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int maxLength = 0;
        int i = 0;
        int j = 0;

        while (j < s.Length) {
            if (!set.Contains(s[j])) {
                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
                j++;
            } else {
                set.Remove(s[i]);
                i++;
            }
        }

        return maxLength;
    }
}
