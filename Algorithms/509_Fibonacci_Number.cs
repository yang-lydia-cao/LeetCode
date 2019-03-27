public class Solution {
    public int Fib(int N) {
        if (N < 2){
           return N; 
        }       
        int f0 = 0, f1 = 1, f2=1 ;
        for (var i = 2; i <= N; i++) {
            f2 = f1 + f0;
            f0 = f1;
            f1 = f2;
        }
        return f2;
    }
}