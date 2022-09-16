using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUc
{
    public  class UC3SearchBinaryTree<T> where T:IComparable<T>
    {
        public T NodeData { get; set; }
        public UC3SearchBinaryTree<T> LeftTree { get; set; }
        public UC3SearchBinaryTree<T> RightTree { get; set; }
        public UC3SearchBinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftcount = 0;
        int rightcount = 0;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new UC3SearchBinaryTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new UC3SearchBinaryTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }

        public void Getsize()
        {
            Console.WriteLine("size" + ":" + (1 + this.leftcount + this.rightcount));
        }

        public bool IfExists(T element, UC3SearchBinaryTree<T> node)
        {
            if (node == null)
            {
                Console.WriteLine("Element not found in binary search tree");
                return false;
            }
            if(node.NodeData.Equals(element))
            {
                Console.WriteLine("found the element in binary search tree " +node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("current element is {0} in binary search tree",node.NodeData);

            }
            if(element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if(element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return true;
        } 
    }
}
