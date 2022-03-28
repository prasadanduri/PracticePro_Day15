using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            binaryTrees binaryTree = new binaryTrees();

            binaryTree.Add(6);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(6);

            binaryTrees.TravarsePreorder(binaryTree.Root);
        }
    }
}