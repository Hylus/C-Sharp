using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST_c_sharp
{
    public class Node
    {
        private int data;
        private Node left, right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

        public void Add (int data)
        {
            if (data > this.data)
            {
                if (this.right !=  null)
                {
                    this.right.Add(data);                    
                }
                else
                {
                    this.right = new Node (data);
                }
            }
            else
            {
                if (this.left != null)
                {
                    this.left.Add(data);
                }
                else
                {
                    this.left = new Node (data);
                }
            }
        }

        public void Clear(Node root)
        {
                if (root.left != null)
                {
                    Clear(root.left);
                    root.left = null;
                }
                if (root.right != null)
                {
                    Clear(root.right);
                    root.right = null;
                }                
        }

        int l = 0, p = 0;
        public void Wyswietl(Node root)
        {            
            Console.WriteLine("{0}\n", root.data);
            if (root.left != null)
            {
                ++l;
                Console.WriteLine("l: {0}", l);
                Wyswietl(root.left);
                p = 0;// ooooo
            }
            if (root.right != null)
            {
                ++p;
                Console.WriteLine("p: {0}", p);
                Wyswietl(root.right);
            }
        }

        public bool Contains (int value, Node root)
        {
            if (value == root.data) return true;
            if (value > root.data)
            {
                if (root.right != null) return Contains(value, root.right);
                else return false;                
            }
            if (value < root.data)
            {
                if (root.left != null) return Contains(value, root.left);
                else return false;                
            }            
            else return false;
        }
        
        public Node GetMaxValueNode(Node root)
        {
         //   Node Temp;

            if (root.right != null)
            {
                return GetMaxValueNode(root.right);
                //  return GetMaxValueNode(root.right);
                //Temp = GetMaxValueNode(root.right);
                //return Temp;
            }
            else return root;
        }

         public int Zwrocdane (Node root)
         {
             return root.data;
         }


    };
     
    public class Drzewo
    {
        private Node root;
        private int licznik;
        private Node max;

        public Drzewo()
        {
            root = null;
            licznik = 0;
        }

        public int ZwrocWartosc(Node root)
        {
            return root.Zwrocdane(root);
        }

        public Drzewo(int data)
        {
            root = new Node(data);
        }

        public bool Contains(int value)
        {
            if (root.Contains(value, root)) return true;            
            else return false;
        }

        public void Add(int data)
        {
            root.Add(data);
        }

        public void Clear(Drzewo tree)
        {
            root.Clear(root);
            root = null;
            tree = null;
        }

        public void Wyswietl()
        {
            root.Wyswietl(root);
        }

        public Node GetMaxValueNode()
        {
       //     Node Temp;
       //     return root.GetMaxValueNode(root);
       //     Temp= root.GetMaxValueNode(root);
       //     return Temp;
            return root.GetMaxValueNode(root);
        }

       
        
    };


    class Program
    {
        static void Main(string[] args)
        {            
            Drzewo drzewo = new Drzewo(20);
            drzewo.Add(10);
            drzewo.Add(5);
            drzewo.Add(15);

            drzewo.Add(27);
            drzewo.Add(25);
            drzewo.Add(24);
            drzewo.Add(22);
            drzewo.Add(26);
            drzewo.Add(30);
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj wartosc do wpsiania do drzewka");
                string a = Console.ReadLine();
                if (drzewo.Contains(Int16.Parse(a)).Equals(true)) Console.WriteLine("Ta cygfra juz jest");
                else Console.WriteLine("Wpisano");
            }
            Console.WriteLine("\n");
            drzewo.Wyswietl();
           */


            Console.WriteLine("\n");

            Console.WriteLine("Najwieksza wartosc {0}\n", drzewo.ZwrocWartosc(drzewo.GetMaxValueNode()));
                



            drzewo.Clear(drzewo);
        }
    }
}
