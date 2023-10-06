namespace ConsoleApp13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BST bst = new BST(); 
            // Insert nodes into the
            int[] anArrayNodes = { 17, 6, 5, 20, 19, 18, 11, 14, 12, 13, 2, 4, 10 };
            foreach (int node in anArrayNodes) { bst.Insert(node); } 
            // Visualize the BST
            bst.Visualize();
            // In-order traversal of BST
            Console.Write("In-order Traversal: "); bst.InOrderTraversal();
            // Pre-order traversal of BST
           Console.Write("Pre-order Traversal: "); bst.PreOrderTraversal(); 
        
          Console.ReadLine();
        
        }



       
    }
        
    
}