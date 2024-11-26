using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        // Read number of entries in the phone book
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // Populate the phone book
        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string phoneNumber = entry[1];
            phoneBook[name] = phoneNumber;
        }

        // Read and process queries
        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(query))
            {
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
