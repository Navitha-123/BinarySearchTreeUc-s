using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUc
{
    public class UC1BinaryTreeAddNode<T> where T:IComparable<T>
    {
        public T NodeData { get; set; }
        public UC1BinaryTreeAddNode<T> LeftTree { get; set; }   
        public UC1BinaryTreeAddNode<T> RightTree { get; set; }
        public UC1BinaryTreeAddNode(T nodeData)
        {
            this.NodeData =  nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftcount = 0;
        int rightcount = 0;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if((currentNodeValue.CompareTo(item))>0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new UC1BinaryTreeAddNode<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new UC1BinaryTreeAddNode<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display()
        {
            if(this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }


    }

}
