using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    // Instance variables for stack and queue
    private Stack<char> stack = new Stack<char>();
    private Queue<char> queue = new Queue<char>();

    // Method to push a character onto the stack
    public void pushCharacter(char ch) {
        stack.Push(ch);
    }

    // Method to enqueue a character into the queue
    public void enqueueCharacter(char ch) {
        queue.Enqueue(ch);
    }

    // Method to pop a character from the stack
    public char popCharacter() {
        return stack.Pop();
    }

    // Method to dequeue a character from the queue
    public char dequeueCharacter() {
        return queue.Dequeue();
    }

    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}