using System;
using System.Collections.Generic;
using System.Text;

namespace stack_using_array
{
    public class CustomStack
    {
        protected int[] data;

        private readonly int DEFAULT_SIZE;
        public int ptr = -1;
        public CustomStack()
        {
            this.DEFAULT_SIZE = 10;
            this.data = new int[this.DEFAULT_SIZE];
        }

        public CustomStack(int size)
        {
            this.data = new int[size];
        }

        // This will insert data into your stack of array type
        // for inserting we need to maintain a pointer, let say 'ptr', ptr will keep on incrementing it's count as and when data is inserted
        public Boolean Push(int val)
        {
            //before inserting check if stack is full
            if (isFull())
            {
                Console.WriteLine("Oops! Stack has enough in it's plate!!");
                return false;
            }
            data[++ptr] = val;
            return true;
        }

        // removes last inserted value. LIFO
        public int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Oops! Stack is already empty!");
                return -1;
            }
            var valRemoved = data[ptr];
            ptr--;
            return valRemoved;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!!");
                return -1;
            }
            return data[ptr];
        }
        protected Boolean isEmpty()
        {
            return ptr == -1;
        }

        protected Boolean isFull()
        {
            return ptr == data.Length - 1;
        }
    }
}
