using System;

class Solution
{
    public static void Main(string[] args)
    {
        // Baca input
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        // Konversi ke representasi biner
        string binary = Convert.ToString(n, 2);
        
        // Hitung urutan maksimal angka 1
        int maxConsecutiveOnes = 0;
        int currentCount = 0;

        foreach (char bit in binary)
        {
            if (bit == '1')
            {
                currentCount++;
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentCount);
            }
            else
            {
                currentCount = 0;
            }
        }
        
        // Cetak hasil
        Console.WriteLine(maxConsecutiveOnes);
    }
}
