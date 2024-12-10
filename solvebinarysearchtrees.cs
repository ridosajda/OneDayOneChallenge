using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static int getHeight(Node root) {
    // Base case: jika root adalah null, maka tingginya -1
    if (root == null) {
        return -1;
    }

    // Rekursif menghitung tinggi kiri dan kanan
    int leftHeight = getHeight(root.left);
    int rightHeight = getHeight(root.right);

    // Tinggi tree adalah maksimum dari tinggi kiri dan kanan, ditambah 1
    return Math.Max(leftHeight, rightHeight) + 1;
}


	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}