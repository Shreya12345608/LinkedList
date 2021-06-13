using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// method for add element
        /// </summary>
        /// <param name="data">value send to th user</param>
        internal void Add(int data)
        {
            //creating a node with given data
            Node node = new Node(data);
            //if head is null means the list is empty
            ////the first  node is head
            if (this.head == null)
                this.head = node;
            else
            {
                //esle add the element to the end
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //print and inserted into the linked list
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        //UC2
        //method for Seconf Linkedlist
        internal void Add2(int data)
        {
            //creating a node with given data
            Node node = new Node(data);
            //if head is null means the list is empty
            ////the first  node is head
            if (this.head == null)
                this.head = node;
            else
            {
                //esle add the element to the end
                node.next = head;
                this.head = node;
            }
            //print
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        /// <summary>
        /// method for insert at particular Position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node InsertAtParticularPosition(int position, int data)
        {
            //position < 1
            if (position < 1)
                //invaid position
                Console.WriteLine("Invalid position");
            Console.WriteLine("Inserting " + data + " in positon " + position);
          /// if position == 1
            if (position == 1)
            {
                //creating a node with given data
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            //position - position -1 ! = 0
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        /// <summary>
        /// /Remove first Node
        /// </summary>
        /// <returns></returns>
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            Node firstElement = this.head;
            this.head = this.head.next;
            return firstElement;
        }
       
        /// for display
        internal void Display()
        {
            Node temp = this.head;
            ////if head is null means the list is empty
            if (temp == null)
            {
                //print linked list is empty
                Console.WriteLine("Linked list is empty");
                return;
            }
            //UC3
            Console.WriteLine("Sequence of LinkedList :-");
            // traverse and print data from head to last
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
