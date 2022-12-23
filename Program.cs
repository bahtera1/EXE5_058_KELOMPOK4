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
            if (Naufal == null)
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

        public void display()
        {
            if (Naufal = null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Node display;
            int nd = 1;
            for(display=Naufal;display!=null;display=display.next)
                Console.WriteLine(display.name);
        }
    }













        static void Main(string[] args)
        {
        }

}
