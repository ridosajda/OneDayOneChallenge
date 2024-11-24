using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        // Read the number of test cases
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++) {
            // Read the input string for the current test case
            string S = Console.ReadLine();
            int N = S.Length;

            // Initialize the even and odd output strings
            string even = "";
            string odd = "";

            // Iterate through the string and extract the even and odd characters
            for (int j = 0; j < N; j++) {
                if (j % 2 == 0) {
                    even += S[j];
                } else {
                    odd += S[j];
                }
            }

            // Print the output for the current test case
            Console.WriteLine(even + " " + odd);
        }
    }
}
