public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == null || s == "") return 0;

        var global = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var hashSet = new HashSet<char>();

            int local = 0;
            for (int j = i; j < s.Length; j++)
            {
                var curChar = s[j];

                if (hashSet.Contains(curChar)) break;

                hashSet.Add(curChar);

                local++;
            }

            global = Math.Max(local, global);
        }

        return global;
    }
}