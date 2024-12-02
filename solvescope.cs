using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;



    // Constructor
    public Difference(int[] elements) {
        this.elements = elements;
    }

    // Method to compute the maximum difference
    public void computeDifference() {
        int maxElement = elements.Max();
        int minElement = elements.Min();
        maximumDifference = Math.Abs(maxElement - minElement);
    }



} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}