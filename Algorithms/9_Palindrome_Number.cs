public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        var reversedNumber = Reverse((long)x);

        if (reversedNumber == (long)x) return true;

        return false; 
    }
    
    private long Reverse(long x)
    {
        long result = 0;
        var cur = x;
        while(cur != 0)
        {
            result = result * 10 + cur % 10;
            cur /= 10;
        }
        return result;
    }
}