public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var output = new List<IList<int>>();
        var current = new List<int>();
        Array.Sort(candidates);
        Helper(output, current, 0, candidates, target);
        return output;
    }
    
    private void Helper(IList<IList<int>> list, IList<int> current, int index, int[] candidates, int target){
        if(target == 0){
            list.Add(current.ToList());
            return;
        }
        if(target < 0){
            return;
        }
        
        for(int i = index; i < candidates.Length; ++i){
            if(i != 0 && candidates[i] == candidates[i - 1]){
                continue;
            }
                
            if(candidates[i] == 0){
                continue;
            }
            
            int tmp = candidates[i];
            candidates[i] = 0;
            current.Add(tmp);
            Helper(list, current, i + 1, candidates, target - tmp);
            candidates[i] = tmp;
            current.RemoveAt(current.Count - 1);
        }
    }
}