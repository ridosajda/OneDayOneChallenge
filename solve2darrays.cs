using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        // Membaca input array 6x6
        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int maxSum = int.MinValue; // Nilai awal untuk maksimum *hourglass sum*

        // Iterasi untuk menemukan semua *hourglass sum*
        for (int i = 0; i < 4; i++) // Baris 0-3
        {
            for (int j = 0; j < 4; j++) // Kolom 0-3
            {
                // Hitung *hourglass sum* untuk posisi saat ini
                int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] // Baris atas
                               + arr[i + 1][j + 1]                       // Tengah
                               + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]; // Baris bawah

                // Perbarui nilai maksimum jika *hourglass sum* saat ini lebih besar
                maxSum = Math.Max(maxSum, currentSum);
            }
        }

        // Cetak hasil maksimum
        Console.WriteLine(maxSum);
    }
}
