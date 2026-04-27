public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int check in nums) {
            if (duplicates.Contains(check))
            return true;
            duplicates.Add(check);
        };
        return false;
    }
};