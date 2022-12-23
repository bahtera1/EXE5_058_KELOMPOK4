using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_058_KELOMPOK4
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Naufal, saputra;
        public queue()
        {
            Naufal = null;
            saputra=null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("MAsukan Element:");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (naufal == null)
            {
                Naufal = newnode;
                saputra = newnode;
                return;
            }
            Naufal.next = newnode;
            Naufal=newnode;
        }
        public void delete()
        {
            if(Naufal==null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Naufal = Naufal.next;
            if(Naufal==null)
                saputra=null;
        }
    }













        static void Main(string[] args)
        {
        }

}
