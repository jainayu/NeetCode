public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if ((mapST.ContainsKey(c1) && mapST[c1] != c2)
               || (mapTS.ContainsKey(c2) && mapTS[c2] != c1))
            {
                return false;
            }

            mapST[c1] = c2;
            mapTS[c2] = c1;
        }

        return true;
    }
}