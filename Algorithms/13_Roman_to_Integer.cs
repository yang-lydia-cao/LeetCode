public class Solution {
    public int RomanToInt(string s) {        
        // Input is guaranteed to be within the range from 1 to 3999.
        var n = s.Length;
        // Create a Dictionary with an initializer.
        var romanAndInt = new Dictionary<char, int>()
        {
            {'I', 1}, 
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        // Iterate from the back to the front
        var result = romanAndInt[s[n - 1]];
        // Compare
        for(int i = s.Length - 2; i >= 0; i--)
        {
            var cur = romanAndInt[s[i]];
            var post = romanAndInt[s[i+1]];

            if (cur < post)
            {
                result -= cur;
            }
            else
            {
                result += cur;
            }
        }

        return result;
    }
}