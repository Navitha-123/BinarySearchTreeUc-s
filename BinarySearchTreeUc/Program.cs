using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.create binary tree");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    UC1BinaryTreeAddNode<int> tree = new UC1BinaryTreeAddNode<int>(56);
                    tree.Insert(30);
                    tree.Insert(70);

                    tree.Display();
                    break;

                default:
                    Console.WriteLine("enter wrong choice");
                    break;

                    Console.ReadLine();
                  
            }
        } 
    }
}     


