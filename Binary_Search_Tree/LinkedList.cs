using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class LinkedList : IEnumerable<Node>
    {
        public Node root;

        public Random rnd = new Random();

        private LinkedList<Node> Nodes;

        public LinkedList() // constructor
        {
            LinkedList<Node> Nodes = new LinkedList<Node>() { }; // has 100 items
        }

        public int IEnumerator<Node> GetNumerator()
        {
            for (int i = 0; i <= Nodes.Count - 1; i++)
            {
                Nodes.Add(i);
            }
        }

        public void MakeTree()
        {
            

            for (int i = 0; i <= 100; i++) // not going in order
            {
                Add(Convert.ToInt32(rnd));
                Console.WriteLine(); // print left or right
            }

        }

        public void Add(int number) // to get from one node to the next
        {
            Node node = new Node(number);
            if (root == null) // is there a root?
            {
                root = node;
                return;
            } // if the root already has something in it
            Node currentNode = root; // temporarily hold each node as we traverse down the tree
            while (currentNode.next != null)
            {
                currentNode = currentNode.next; // find a node that has a next member variable that is empty. That is where new node will go.
            }
            currentNode.next = node;
        }


        public int GetNumberToSearchFor()
        {
            Console.WriteLine("Please enter a number to find its location in the binary tree.");
            int numberToSearchFor = Convert.ToInt32(Console.ReadLine());
            return numberToSearchFor;
        }

        public void Search()
        {
            /*Find(tree);*/    // Finds the first node that contains the specified value.

            //tree.Find(numberSearchedFor);

        }

        public void PrintPathToData()
        {

        }


    }
}
