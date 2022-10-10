public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int[] fb = new int[flowerbed.Length + 2];
        fb[0] = 0;
        fb[flowerbed.Length - 1] = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            fb[i + 1] = flowerbed[i];
        }

        for (int i = 1; i < fb.Length - 1; i++)
        {
            if (fb[i - 1] == 0 && fb[i] == 0 && fb[i + 1] == 0)
            {
                fb[i] = 1;
                n--;
            }
        }

        return n <= 0;
    }
}