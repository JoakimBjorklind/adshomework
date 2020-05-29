using System;
using System.Text;
using System.Collections.Generic;

namespace part4
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        public LinkedList()
        {
          this.head = null;
          this.tail = null;
        }
        public void AddFirst(int n)
        {
            Node node = new Node(n, null, null);

            if (this.head == null)
            {
                this.head = node;
                this.tail = this.head;
            }
            else
            {
                this.head.previous = node;
                node.next = this.head;
                this.head = node;
            }

        }

        public void AddLast(int n)
        {
            Node node = new Node(n, null, this.tail);

            if (this.tail == null)
            {
                this.tail = node;
                this.head = this.tail;
            }
            else
            {
                this.tail.next = node;
                node.previous = this.tail;
                this.tail = node;
            }


        }
        
        public void RemoveFirst()
        {
            this.head = this.head.next;
            this.head.previous = null;

        }

        public void RemoveLast()
        {
            this.tail = this.tail.previous;
            this.tail.next = null;

        }
        

        public int GetNode(int x)
        {
            Node current = this.head;
            int count = 0;
            

            while (current != null)
            {
                if (count == x)
                {
                    return current.value;
                }
                count ++;
                current = current.next;
            }
            return 0;


        }
        

        public override string ToString()
        {
            //return this.head.value.ToString();
            string result = "";
            Node current = this.head;

            while (current != null)
            {
                result += current.value + " ";
                current = current.next;
            }
            return result;
        } 

    }

}