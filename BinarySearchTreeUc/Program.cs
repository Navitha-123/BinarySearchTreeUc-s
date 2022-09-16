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
            Console.WriteLine("choose option 1.create binary tree \t 2.Binarytree creation \t 3. searchbinarytree");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    UC1BinaryTreeAddNode<int> tree = new UC1BinaryTreeAddNode<int>(56);
                    tree.Insert(30);
                    tree.Insert(70);

                    tree.Display();
                    break;

                case 2:
                    UC2BinaryTreeCreate<int> tree1 = new UC2BinaryTreeCreate<int>(56);
                    tree1.Insert(30);
                    tree1.Insert(70);
                    tree1.Insert(22);
                    tree1.Insert(40);
                    tree1.Insert(60);
                    tree1.Insert(95);
                    tree1.Insert(11);
                    tree1.Insert(65);
                    tree1.Insert(3);
                    tree1.Insert(16);
                    tree1.Insert(63);
                    tree1.Insert(67);

                    tree1.Display();

                    tree1.Getsize();

                    break;

                case 3:
                    UC3SearchBinaryTree<int> tree2 = new UC3SearchBinaryTree<int>(56);
                    tree2.Insert(30);
                    tree2.Insert(70);
                    tree2.Insert(22);
                    tree2.Insert(40);
                    tree2.Insert(60);
                    tree2.Insert(95);
                    tree2.Insert(11);
                    tree2.Insert(65);
                    tree2.Insert(3);
                    tree2.Insert(16);
                    tree2.Insert(63);
                    tree2.Insert(67);

                    tree2.Display();

                    tree2.Getsize();

                    bool result = tree2.IfExists(40, tree2);
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;

                    Console.ReadLine();
                  
            }
        } 
    }
}     


