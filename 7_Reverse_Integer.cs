public class Solution {
    public int Reverse(int x) {
        // 123 -> 321
        // -123 -> -321

        var result = Reverse((long)x);
        // Numeric types (int, uint, short and ushort) have specific max values. 
        // These are constants—they never change. 
        // But we do not need to memorize them to use them.
        if (result >= int.MinValue && result <= int.MaxValue)
        {
            // The (int) cast never rounds the value up.
            return (int)result;
        }
        return 0;        
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