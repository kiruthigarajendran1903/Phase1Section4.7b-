using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }


        public static void runApp()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.add(n);
            Console.WriteLine("Enter Data");
            int DLength=int.Parse(Console.ReadLine());
            for (int i = 1; i <= DLength; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }


        }
    }
}
