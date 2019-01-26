using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.myClass
{
 public class queue
    {
        public int rear=0;
        public int front=0;
        public int[] arr = new int[9];

        int isfull()
        {
            if (front == (rear + 1) % 9)
                return 1;
            return 0;
        }
        int isEmpty()
        {
            if (front == rear)
                return 1;
            return 0;
        } 
        public  int read()
        {
            if (isEmpty() != 1)
            {
                if(front == 9 && rear == 0)
                    return 0;

                front++;
                int result = arr[front - 1];
                arr[front - 1] = 0;
                return result;
            }
            return 0;
        }
        public void add(int a)
        {
            if (isfull() != 1)
            {
                arr[rear] = a;
                if (rear == 9)
                    rear = 0;
                else
                    rear++;
            }
        }
    }
}
