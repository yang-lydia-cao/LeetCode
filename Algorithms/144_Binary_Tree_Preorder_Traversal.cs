/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var result=new List<int>();
        var stack=new Stack<TreeNode>();
        
        if(root==null){
            return result;
        }
        
        stack.Push(root);
        while(stack.Count !=0){
            TreeNode node=stack.Pop();
            result.Add(node.val);
            
            if(node.right!=null){
                stack.Push(node.right);
            }
            
            if(node.left!=null){
                stack.Push(node.left);            
            }
        }
        return result;
    }
}