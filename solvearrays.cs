using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        // Membaca jumlah elemen dalam array
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Membaca elemen array
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        // Membalikkan array
        arr.Reverse();

        // Mencetak elemen array yang sudah dibalik dalam satu baris, dipisahkan dengan spasi
        Console.WriteLine(string.Join(" ", arr));
    }
}
