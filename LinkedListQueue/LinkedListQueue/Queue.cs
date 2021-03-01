using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListQueue
{
    class Queue
    {
        // Members
        private int head;    // The index of item at the top of the queue
        private int maxSize; // The max number of items the queue can contain
        private List<string> stackItems;

        public Queue()
        {
            this.maxSize = 5;
            this.head = -1;
            this.stackItems = new List<string>();
        }

        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            this.head = -1;
            this.stackItems = new List<string>();
        }

        public bool IsFull()
        {
            return stackItems.Count == maxSize; //Returns bool representing whether count is equal to maxSize
        }

        public bool IsEmpty()
        {
            //Checks if the first element in the array is empty
            if (stackItems.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            if(stackItems.Count != 0)
            {
                return stackItems.Count();
            }
            else
            {
                throw new Exception("Stack empty");
            }
        }

        public string Peek()
        {
            SetHead();
            string currentItem = stackItems[head];

            if (currentItem == null)
            {
                throw new Exception("Queue empty");
            }

            return currentItem;
        }

        public int SetHead()
        {
            head = stackItems.Count - 1;
            return head;
        }

        public string Dequeue()
        {
            SetHead();

            if (stackItems.Count == 0)
            {
                throw new Exception("Queue empty");
            }
            else
            {
                string itemAtHead = stackItems[head];
                stackItems.RemoveAt(head);
                return itemAtHead; //Return item that was dequeued
            }
        }

        public void Enqueue(string item)
        {
            if (stackItems.Count == 0)
            {
                stackItems.Add(item);
            }
            else if(!(stackItems.Count == maxSize))
            {
                stackItems.Insert(0, item);
            }
            else
            {
                throw new Exception("Queue full");
            }
        }

        public string PrintQueue()
        {
            string stackString = "";

            if (IsEmpty())
            {
                throw new Exception("Queue empty");
            }
            else
            {
                stackItems.Reverse(); //Reverses order of elements in list
                for (int i = 0; i < stackItems.Count; i++)
                {
                    //Prints each item on a new line
                    stackString += stackItems[i] + "\n";
                }
                stackItems.Reverse(); //Reverses back to original order
            }
            return stackString;
        }
    }
}
