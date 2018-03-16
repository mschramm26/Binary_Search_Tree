using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node : IComparable<Node>
    {
        public Random rnd = new Random();

        public int data;
        public Node next;

        //public int Direction 
        //{
        //    get
        //    {
        //        return direction;
        //    }
        //}


        public Node() // constructor
        {

        }

        public Node(int number) // constructor
        {
            data = number;
            number = Convert.ToInt32(rnd);
        }


        public int CompareTo(Node next)
        {
            if (this.data > next.data) return -1;
            if (this.data == next.data) return 0;
            return 1;
        }

    }
}
