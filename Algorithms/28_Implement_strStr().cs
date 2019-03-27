public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) return 0;
        if ((needle.Length > haystack.Length) || (needle.Length==null) || haystack==null) return -1;

        for(int i = 0; i < haystack.Length-needle.Length+1; i++)
        {
            var j = 0;
            for(j=0;j<needle.Length;j++)
            {
                if (haystack[i+j] != needle[j])
                {
                    break;
                }
            }
            if(j==needle.Length)
            {
                return i;
            }
        }

        return -1;
    }
}