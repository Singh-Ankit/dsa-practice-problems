using System;
using System.Collections.Generic;
using System.Text;

namespace stack_using_array
{
    public class DynamicStack : CustomStack
    {
        public DynamicStack(): base()
        {
           // base();
        }

        public DynamicStack(int size): base(size)
        {

        }

        public new Boolean Push(int val)
        {
            if (this.isFull())
            {
                //double the existing array size
                int[] temp = new int[data.Length * 2];

                //copy values from existing array to new array
                for (int i = 0; i < data.Length-1; i++)
                {
                    temp[j] = data[j];
                }

                data = temp;
                return true;
            }

            //else, here we know that array is not full. So, will use existing Push to add values
            base.Push(val);
            return true;
        }
    }
}
