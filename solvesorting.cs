using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int numSwaps = 0;

        for (int i = 0; i < n; i++)
        {
            // Track whether a swap has occurred in this pass
            bool swapped = false;

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in the wrong order
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    numSwaps++;
                    swapped = true;
                }
            }

            // If no elements were swapped during this pass, the array is sorted
            if (!swapped)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[n - 1]}");
    }
}
