public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hSet = new HashSet<int>();
        foreach (int num in nums)
        {
            if (hSet.Contains(num))
            {
                return true;
            }
            hSet.Add(num);
        }
        return false;
    }
}