using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class BSTNode
    {
        public int key; public BSTNode left; public BSTNode right; public BSTNode(int key) { this.key = key; this.left = null; this.right = null; }
    }
    class BST 
    { public BSTNode root;
        public void Insert(int key) 
        { root = InsertHelper(root, key); }
        private BSTNode InsertHelper(BSTNode node, int key)
        { if (node == null) { return new BSTNode(key); } if (key < node.key) { node.left = InsertHelper(node.left, key); } else if (key > node.key) { node.right = InsertHelper(node.right, key); } return node; } public void Visualize() { VisualizeHelper(root, "", true); } private void VisualizeHelper(BSTNode node, string prefix, bool isLeft) { if (node == null) { return; } string nodeStr = node.key.ToString(); string line = prefix + (isLeft ? "├── " : "└── ");
            Console.WriteLine(line + nodeStr);
            string childPrefix = prefix + (isLeft ? "│ " : " "); VisualizeHelper(node.left, childPrefix, true);
            VisualizeHelper(node.right, childPrefix, false); } public void InOrderTraversal() { InOrderTraversalHelper(root);
            Console.WriteLine(); } private void InOrderTraversalHelper(BSTNode node) { if (node != null) { InOrderTraversalHelper(node.left); 
                Console.Write(node.key + " "); InOrderTraversalHelper(node.right); } } public void PreOrderTraversal() { PreOrderTraversalHelper(root); Console.WriteLine(); } private void PreOrderTraversalHelper(BSTNode node) { if (node != null) { Console.Write(node.key + " "); PreOrderTraversalHelper(node.left); 
                PreOrderTraversalHelper(node.right); } } }
}

