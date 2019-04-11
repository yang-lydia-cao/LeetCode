public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> results = new List<IList<int>>();
        
        if(candidates==null|| candidates.Length==0){
            return results;
        }
        Array.Sort(candidates);
        
        Find(results, candidates, target, 0, new List<int>());
        return results;
    }
    
    private void Find(IList<IList<int>> results, int[] arr, int target, int start, IList<int> curr)
    {
        if (target == 0)
        {
            results.Add(new List<int>(curr));
            return;
        }
        
        for (int i = start; i < arr.Length && arr[i] <= target; i++)
        {
            if(arr[i]>target){
                break;
            }
            curr.Add(arr[i]);
            Find(results, arr, target - arr[i], i, curr);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}