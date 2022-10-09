public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> res = new List<IList<int>>();
        res.Add(new List<int>() { 1 });
        for (int i = 1; i < numRows; i++)
        {
            List<int> temp = new List<int>(res[i - 1]);
            temp.Insert(0, 0);
            temp.Add(0);
            List<int> newRow = new List<int>();
            for (int j = 0; j < res[i - 1].Count + 1; j++)
            {
                newRow.Add(temp[j] + temp[j + 1]);
            }
            res.Add(newRow);
        }
        return res;

    }
}