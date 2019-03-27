public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        // Declare a new StringBuilder.
        var result = new StringBuilder();
        //
        var firstWord = strs[0];
        //
        for (int j = 0; j < firstWord.Length; j++)
        {
            // iterate column first.
            for(int i = 1; i < strs.Length; i++)
            {
                var curWord = strs[i];

                if (j == curWord.Length) return result.ToString();

                if (firstWord[j] != curWord[j])
                {
                    return result.ToString();
                }
            }
            result.Append(firstWord[j]);
        }
        // This returns the buffer. 
        // We will almost always want ToString—it will return the contents as a string.
        return result.ToString(); 
    }       
}