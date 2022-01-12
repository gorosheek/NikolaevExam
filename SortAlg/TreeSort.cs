using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{
    public class TreeSort
    {
        public static int[] Sort(int[] numbers)    
        {
            var tree = new BinTree() { Value = numbers[0]};
            for (int i = 1; i < numbers.Length; i++)
            {
                tree = BuildBinTree(numbers[i], tree);
            }
            int index = 0;
            tree.Bypass(numbers, ref index);
            return numbers;
        }
        private static BinTree BuildBinTree(int number, BinTree node)
        {
            if (number < node.Value)
            {
                if (node.LeftNode is null)
                    node.LeftNode = new BinTree() { Value = number };
                else
                    node.LeftNode = BuildBinTree(number, node.LeftNode);
            }
            else
            {
                if (node.RightNode is null)
                    node.RightNode = new BinTree() { Value = number };
                else
                    node.RightNode = BuildBinTree(number, node.RightNode);
            }
            return node;
        }
    }
    class BinTree
    {
        public int Value { get; set; }
        public BinTree LeftNode { get; set; }
        public BinTree RightNode { get; set; }
        public void Bypass(int[] numbers, ref int count)
        {
            if (LeftNode != null)
                LeftNode.Bypass(numbers, ref count);
            numbers[count++] = Value;
            if (RightNode != null)
                RightNode.Bypass(numbers, ref count);
        }
    }
}
//                   24
//                /      \ 
//               2        33
//                \     /    \ 
//                  2  31    94
//                   \     /    
//                    6   33
//                           \ 
//                           81
//                         /     
//                        56      

// 24, 2, 2, 33, 94, 31, 33, 81, 6, 56