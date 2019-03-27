public class Solution {
    public bool IsValid(string s) {
        // Stack<int> stack = new Stack<int>();
        Stack<char> stack = new Stack<char>();
        //
        int i = 0;
        // ToCharArray method converts strings to character arrays. 
        // It is called on a string and returns a new char array. 
        //The original string is left unchanged.
        foreach(var c in s.ToCharArray()){
            if(c == '(' || c=='{' || c =='['){
                // stack.Push(100);
                stack.Push(c);
                i++;
            }else if(stack.Count >0 && 
                  ((c == ')' && '(' == stack.Peek()) || 
                   (c == '}' && '{' == stack.Peek()) ||
                   (c == ']' && '[' == stack.Peek()) )){
                    stack.Pop();
                    i--;
            }else{
                i++;
            }
        }
        return (stack.Count >0 || i > 0)? false: true;
        
    }

}