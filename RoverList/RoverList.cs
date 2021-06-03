using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        public int count;
        
        public RoverList ()
        {
            count = 0;
        }

        public override int Count
        {
            get
            {
                return count;
            }
        }

        public override void Add(T data)
        {
            Node n = new RoverListBase<T>.Node(data);

            if (head == null)
            {
                head = n;
                count++;
            }
            else
            {
                head.Next = n;
                count++;
            }

        }

        public override void Add(int Position, T data)
        {
            if (Position < 0 || Position >= count)
                throw new IndexOutOfRangeException();

            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                if (Position == 0)
                {
                    newNode.Next = head;
                    head.Next = newNode;
                    head = newNode;
                }
                

            }
        }


        public override void Clear()
        {
            head = null;
        }



        public override T ElementAt(int Position)
        {
            current = head;
            int pos = 0;
            while (pos != Position && current != null)
            {
                pos++;
                current = head.Next;
            }
            if (current != null && pos == Position)
                return current.Data;
            else
                return default(T); 
        }

        public override void ListNodes()
        {
            current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            bool removed = false;
            if (Position == 0)
            {
                head = head.Next;
            }

            return removed;

        }

    }
}
