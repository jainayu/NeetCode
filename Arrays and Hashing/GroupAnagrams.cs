public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
            {
                count[c - 'a'] += 1;
            }
            string key = String.Join(", ", count);
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new List<string>() { s });
            }
            else
            {
                dict[key].Add(s);
            }
        }


        return new List<IList<string>>(dict.Values.ToList());
    }
}