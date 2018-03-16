using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program // Your task is to make a binary search tree. It must have an Add method and a Search method. Print to the console whether we’re going left or right (path to data).
    {
        static void Main(string[] args)
        {
            Console.Title = "Binary Search Tree";

            LinkedList tree = new LinkedList();
            tree.MakeTree();
            tree.GetNumberToSearchFor();
            tree.Search();
            tree.PrintPathToData();

            Console.ReadLine();
        }

    }
}
